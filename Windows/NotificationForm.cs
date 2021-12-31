using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using Info.Classes;
using Info.Windows;

/* 
    Автор: Костромин Даниил, 131-ПИо.
    Информационные системы
 */

namespace Info
{
    public sealed partial class NotificationForm : FormShadow
    {
        public NotificationForm(int code)
        {
#if DEBUG
            TopMost = false;
#endif
            InitializeComponent();

            // Позволяем таскать за заголовок Label и Panel
            new List<Control> { LabelHead, PanelHead }.ForEach(x =>
            {
                x.MouseDown += (s, a) =>
                {
                    x.Capture = false; Capture = false; var m = Message.Create(Handle, 0xA1, new IntPtr(2), IntPtr.Zero); base.WndProc(ref m);
                };
            });

            // Красим форму
            this.Draw(Color.FromArgb(44, 57, 67), Color.FromArgb(35, 44, 55), new[] { 0, 0.1f, 0.9f, 1 }, 90);

            Dictionary<int, string> dictionary = new()
            {
                [1] = "Данные о Вашей системной информации занесены в базу.",
                [2] = "Данные о Вашей системной информации были удалены из базы.",
                [3] = "Файл базы скачан и расположен рядом с Info."
            };

            LabelNotif.Text = dictionary[code];
            LabelNotif.Left = (ClientSize.Width - LabelNotif.Width) / 2;

            ButtonNotifClose.Click += (s, a) => ButtonClose.PerformClick();
        }

        private async void ButtonClose_Click(object sender, EventArgs e)
        {
            for (Opacity = 1; Opacity > .0; Opacity -= .2) await Task.Delay(7);
            Dispose();
        }

        private async void NotificationForm_Load(object sender, EventArgs e)
        {
            for (Opacity = 0; Opacity < 1; Opacity += .2) await Task.Delay(5);
        }
    }
}