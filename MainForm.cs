using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using Microsoft.Win32;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

/* 
    Автор: Костромин Даниил, 131-ПИо.
    Информационные системы
 */

namespace Info
{
    public partial class MainForm : FormShadow
    {
        private readonly ListViewColumnSorter _lvwColumnSorter = new();
        private PerformanceCounter _performanceCounterCpu;
        private readonly Information _systemInformation = new();
        private bool _checkedFirebase;

        public MainForm()
        {
#if DEBUG
            TopMost = false;
#endif
            InitializeComponent();

            if (!InstanceChecker.TakeMemory()) { LabelHead.Text += "(копия)"; LabelHead.ForeColor = Color.BurlyWood;}

            // Позволяем таскать за заголовок Label и Panel
            new List<Control> { LabelHead, PanelHead }.ForEach(x =>
            {
                x.MouseDown += (s, a) =>
                {
                    x.Capture = false; Capture = false; Message m = Message.Create(Handle, 0xA1, new IntPtr(2), IntPtr.Zero); base.WndProc(ref m);
                };
            });

            // Предоставить пользователю скопировать название аппаратуры при нажатии на текст
            PanelMain.Controls.OfType<Label>().ToList().ForEach(x => x.Click += (s, a) => Clipboard.SetText(x.Text));

            // Подсказка при наведении на LinkLabelPerformanceDrives (СМАРТ)
            ToolTip tool = new();
            tool.SetToolTip(LinkSMART, "S.M.A.R.T");
            tool.InitialDelay = 100;

            // Сортировка listview
            ListViewProcesses.ListViewItemSorter = _lvwColumnSorter;

            // Двойная буферизация
            ListViewHelper.EnableDoubleBuffer(ListViewProcesses);
            ListViewHelper.EnableDoubleBuffer(ListViewSMART);

            // Красим форму
            this.Draw(Color.FromArgb(44, 57, 67), Color.FromArgb(35, 44, 55), new[] { 0, 0.058f, 0.058f, 1 }, 90);

            // Событие на левый щелчок по значку в трее
            var contexMenu1 = new ContextMenu();
            contexMenu1.MenuItems.AddRange(new[] {
                new MenuItem("Закрыть", (s, e) => Application.Exit()),});
            notifyIcon1.ContextMenu = contexMenu1;
            notifyIcon1.Icon = Properties.Resources.loader_77;
            notifyIcon1.Click += async (s, a) => { if (!Visible) { Show(); for (Opacity = 0; Opacity < 1; Opacity += .2) await Task.Delay(7); notifyIcon1.Text = $"{Text}"; } };
            
            // FIREBASE
            KeyDown += async (_, a) => {

                // Конфиг
                IFirebaseConfig fireCon = new FirebaseConfig
                {
                    AuthSecret = "uISamWgrSMKr4z8Qc7xg4q3lE9dV3o4vyyWv7cs5",
                    BasePath = "https://info-d8750-default-rtdb.europe-west1.firebasedatabase.app/"
                };
                
                var info = new Information();

                // Занесение в базу
                if (a.KeyValue == (char)Keys.D5)
                {
                    // Соединение. Затем занесение данных о ПК в базу с
                    // уникальным идентификатором, который записывается в реестр.
                    try
                    {
                        using var key = Registry.CurrentUser.CreateSubKey(@"Software\Info");
                        IFirebaseClient client = new FirebaseClient(fireCon);

                        if (key?.GetValue("ID") is null)
                        {
                            // Генерация 7ми символьного хэша
                            key?.SetValue("ID", Convert.ToBase64String(Encoding.UTF8.GetBytes(Guid.NewGuid().ToString())).Remove(7));
                            await client.SetAsync($"Computer Components/{Environment.UserName}{key.GetValue("ID")}", info);
                        }
                        else await client.UpdateAsync($"Computer Components/{Environment.UserName}{key.GetValue("ID")}", info);
                    }
                    catch (Exception) {
                        // ignored
                    }
                }

                // Удаление из базы
                if (a.KeyValue == (char)Keys.D6)
                {
                    // Тоже самое что и выше только удаление.
                    try
                    {
                        using var key = Registry.CurrentUser.CreateSubKey(@"Software\Info");
                        IFirebaseClient client = new FirebaseClient(fireCon);
                        if (await client.DeleteAsync($"Computer Components/{Environment.UserName}{key?.GetValue("ID")}") is not null)
                        {
                            key.DeleteValue("ID");
                            if (!Application.OpenForms.OfType<NotificationForm>().Any()) new NotificationForm(2).Show();
                        }
                    }
                    catch (Exception) {
                        // ignored
                    }
                }

                // Чтение всех данных с базы
                if (a.KeyValue == (char)Keys.D7 && !_checkedFirebase) {

                    // Переключение флага для раскрытия/скрытия панели с данными
                    _checkedFirebase = !_checkedFirebase;

                    // Остановка таймера
                    TimerUpdateInfo.Enabled = !TimerUpdateInfo.Enabled; 

                    // Чтение json базы.
                    try
                    {
                       Dictionary<string, Information> dictionary;
                       var list = new List<string>() { };

                       var webRequest = WebRequest.Create(new Uri($"{fireCon.BasePath}Computer%20Components.json"));
                       using (var response = webRequest.GetResponse())
                       using (var content = response.GetResponseStream())
                       using (var reader = new StreamReader(content!))
                       {
                           var strContent = reader.ReadToEnd();
                           dictionary = JsonConvert.DeserializeObject<Dictionary<string, Information>>(strContent);
                           list.AddRange(dictionary?.Keys);
                           PanelFirebase.Show(); ListOfKeys.Clear();
                           foreach (var value in list)
                               ListOfKeys.Items.Add(new ListViewItem(value));
                       }

                       ListOfKeys.Click += (s, a) =>
                       {
                           BeginInvoke((MethodInvoker)((() =>
                           {
                                   var selectedItem = ListOfKeys.SelectedItems[0].Text;
                                   LabelOS.Text = $"Операционная система: {dictionary?[selectedItem]?.OperationSystem}";
                                   LabelCPU.Text = $"Процессор: {dictionary?[selectedItem]?.CPU}";
                                   LabelGPU.Text = $"Видеокарта: {dictionary?[selectedItem].GPU}";
                                   LabelMotherboard.Text = $"Материнская плата: {dictionary?[selectedItem]?.Motherboard}";
                                   LabelMonitor.Text = $"Монитор: {dictionary?[selectedItem]?.Monitor}";
                                   LabelRAM.Text = $"Оперативная память: {dictionary?[selectedItem]?.RAM}";
                                   LinkSMART.Text = $"{dictionary?[selectedItem]?.Drives}";
                                   LinkSMART.Click -= LinkSmartClick;
                                   LabelDispatcher.Hide();
                                   LinkLabelOfProcesses.Hide();
                           })));
                       };
                    }
                    catch (Exception) {
                        // ignored
                    }
                } 
                else {
                            Invoke((MethodInvoker)(() =>
                            {
                                TimerUpdateInfo.Enabled = !TimerUpdateInfo.Enabled;
                                _checkedFirebase = !_checkedFirebase;
                                LabelOS.Text = $"Операционная система: {_systemInformation.OperationSystem}";
                                LabelRAM.Text = $"Оперативная память: {Hardware.UsageRAM}";
                                LabelMonitor.Text = $"Монитор: {_systemInformation.Monitor}";
                                LinkSMART.Text = Hardware.Drives;
                                LabelCPU.Text = $"Процессор: ({string.Format("{0:0.0}%", _performanceCounterCpu?.NextValue())}) {_systemInformation.CPU}";
                                LabelMotherboard.Text = $"Материнская плата: {_systemInformation.Motherboard}";
                                LabelGPU.Text = $"Видеокарта: {_systemInformation.GPU}";
                                LinkLabelOfProcesses.Text = $"Процессы ({Process.GetProcesses().Length})";
                                LinkSMART.Click += LinkSmartClick;
                                LabelDispatcher.Show(); LinkLabelOfProcesses.Show();
                                PanelFirebase.Hide();
                            }));
                }

                if (a.KeyValue == (char)Keys.Escape) ButtonClose.PerformClick();
            };
            PanelHead.Click += (_, _) => SendKeys.Send(Keys.D7.ToString());
        }

        // Плавное открытие формы
        private void MainForm_Load(object sender, EventArgs e)
        {
            new Thread(() =>
            {
                BeginInvoke((MethodInvoker)(async () =>
                {
                    SendKeys.Send(Keys.D5.ToString());
                    new Thread(StartInfo).Start();
                    for (Opacity = 0; Opacity < 1; Opacity += .2) await Task.Delay(20);
                    TimerUpdateInfo.Start();
                }));
            }).Start();
        }
        
        // Закрытие
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            InstanceChecker.ReleaseMemory();
        }

        // Заполнение начальных данных и определение locationX у контролов
        // после центрирования информации об операционной системе.
        private void StartInfo()
        {
            new Thread(() =>
            {
                BeginInvoke((MethodInvoker)(() =>
                {
                    var howMuch = TextRenderer.MeasureText("Операционная система:", LabelOS.Font).Width;
                    LabelOS.Text = $"Операционная система: {_systemInformation.OperationSystem}";

                    LabelOS.Left = (ClientSize.Width - LabelOS.Width) / 2;
                    var list = new List<Control> { LabelRAM, LabelMonitor,LabelCPU, LabelMotherboard, LabelGPU};
                    list.ForEach(x => x.Location = new Point(LabelOS.Location.X + howMuch - x.Width, x.Location.Y));
                    
                    LabelRAM.Text = $"Оперативная память: {Hardware.UsageRAM}";
                    LabelMonitor.Text = $"Монитор: {_systemInformation.Monitor}";
                    LinkSMART.Text = Hardware.Drives;

                    LabelCPU.Text = $"Процессор: ({string.Format("{0:0.0}%", _performanceCounterCpu?.NextValue())}) {_systemInformation.CPU}";

                    LabelMotherboard.Text = $"Материнская плата: {_systemInformation.Motherboard}";
                    LabelGPU.Text = $"Видеокарта: {_systemInformation.GPU}";
                    LinkLabelOfProcesses.Text = $"Процессы ({Process.GetProcesses().Length})";

                    LinkLabelOfProcesses.Location = new Point(LinkLabelOfProcesses.Location.X, LinkSMART.Size.Height + LinkSMART.Location.Y + 30 - LinkLabelOfProcesses.Size.Height);
                    LabelDispatcher.Location = new Point(LabelDispatcher.Location.X, LinkSMART.Size.Height + LinkSMART.Location.Y + 30 - LabelDispatcher.Size.Height);
                }));
            })
            { IsBackground = true, Priority = ThreadPriority.AboveNormal }.Start();

            _performanceCounterCpu = new PerformanceCounter("Сведения о процессоре", "% загруженности процессора", "_Total");

            // Смарт панель
            new Thread(() =>
                {
                    BeginInvoke((MethodInvoker)(() =>
                    {

                        var list = Smart.GetInfo().Item1.ToArray();
                        var count = Smart.GetInfo().Item2;
                        ListViewSMART.Items.Clear();
                        ListViewSMART.Items.AddRange(list);

                        ListViewSMART.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
                        ListViewSMART.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.HeaderSize);
                        ListViewSMART.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.HeaderSize);
                        ListViewSMART.AutoResizeColumn(3, ColumnHeaderAutoResizeStyle.HeaderSize);
                        ListViewSMART.AutoResizeColumn(4, ColumnHeaderAutoResizeStyle.ColumnContent);
                        ListViewSMART.AutoResizeColumn(5, ColumnHeaderAutoResizeStyle.HeaderSize);

                        LabelSMART.Text = $"Сканировано устройств: {count}";
                        LabelSMART.Left = (ClientSize.Width - LabelSMART.Width) / 2;
                    }));
                })
            { IsBackground = true, Priority = ThreadPriority.AboveNormal }.Start();
        }

        // Обновление данных каждую секунду
        private void TimerUpdateInfo_Tick(object sender, EventArgs e)
        {
            BeginInvoke((MethodInvoker)(() =>
            {
                LabelCPU.Text = $"Процессор: ({string.Format("{0:0.0}%", _performanceCounterCpu?.NextValue())}) {_systemInformation.CPU}";
                LinkSMART.Text = Hardware.Drives;
                LabelRAM.Text = $"Оперативная память: {Hardware.UsageRAM}";
                LinkLabelOfProcesses.Text = $"Процессы ({Process.GetProcesses().Length})";
                LinkLabelOfProcesses.Location = new Point(LinkLabelOfProcesses.Location.X, LinkSMART.Size.Height + LinkSMART.Location.Y + 30 - LinkLabelOfProcesses.Size.Height);
                LabelDispatcher.Location = new Point(LabelDispatcher.Location.X, LinkSMART.Size.Height + LinkSMART.Location.Y + 30 - LabelDispatcher.Size.Height);
            }));
        }

        // Событие клика на линклейбл накопителей
        private void LinkSmartClick(object sender, EventArgs e)
        {
            PanelSMART.Click += (s, a) => PanelInfo.Demonstrate(this);
            PanelSMART.Demonstrate(this);
        }

        // Плавное закрытие программы
        private async void ButtonClose_Click(object sender, EventArgs e)
        {
            notifyIcon1.Visible = !notifyIcon1.Visible;
            notifyIcon1.Dispose();
            for (Opacity = 1; Opacity > .0; Opacity -= .2) await Task.Delay(7);
            Dispose();
        }

        // Плавное скрытие программы
        private async void ButtonHide_Click(object sender, EventArgs e)
        {
            for (Opacity = 1; Opacity > .0; Opacity -= .2)
                await Task.Delay(7);
            Hide(); notifyIcon1.Text = $"{Text} (фоновый режим)";
        }

        // Удаление значка из трея
        private void NotifyIcon1_BalloonTipClosed(object sender, EventArgs e)
        {
            var thisIcon = (NotifyIcon)sender;
            thisIcon.Visible = false;
            thisIcon.Dispose();
        }

        // Открытие панели с процессами
        private void LinkLabelOfProcesses_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            void RefreshList()
            {
                new Thread(() =>
                    {
                        BeginInvoke((MethodInvoker)(() =>
                        {
                            var list = new List<ListViewItem>();
                            {
                                foreach (var process in Process.GetProcesses())
                                    try
                                    {
                                        list.Add(new ListViewItem(new[] {
                                        $"{process.ProcessName} ({process.Id})",
                                        $"{process.WorkingSet64 / (1024 * 1024)} MB"}));
                                    }
                                    catch
                                    {
                                        // ignored
                                    }
                            }

                            int topItemIndex = 0;
                            try { topItemIndex = ListViewProcesses.TopItem.Index; }
                            catch (Exception) { }
                            ListViewProcesses.BeginUpdate();
                            ListViewProcesses.Items.Clear();

                            // Заполнить
                            ListViewProcesses.Items.AddRange(list.ToArray());

                            ListViewProcesses.EndUpdate();
                            try { ListViewProcesses.TopItem = ListViewProcesses.Items[topItemIndex]; }
                            catch (Exception) { }

                            LabelProcess.Text = $"Запущено процессов: {list.Count}";
                            LabelProcess.Left = (ClientSize.Width - LabelProcess.Width) / 2;
                        }));
                    })
                { Priority = ThreadPriority.Highest }.Start();
            }

            TimerUpdateProcesses.Tick += (_, _) => new Thread(RefreshList) { IsBackground = true, Priority = ThreadPriority.Highest }.Start();
            new Thread(RefreshList) { IsBackground = true, Priority = ThreadPriority.Highest }.Start();

            PanelProcess.Demonstrate(this);
            TimerUpdateProcesses.Start();

            PanelProcess.Click += (s, a) => PanelInfo.Demonstrate(this);
        }

        // Сортировка listview
        private void ListView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column == _lvwColumnSorter.SortColumn)
                _lvwColumnSorter.Order = _lvwColumnSorter.Order == SortOrder.Ascending ? SortOrder.Descending : SortOrder.Ascending;
            else
            {
                _lvwColumnSorter.SortColumn = e.Column;
                _lvwColumnSorter.Order = SortOrder.Ascending;
            }

            ListViewProcesses.Sort();
        }
    }
}