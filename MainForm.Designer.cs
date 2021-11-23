namespace Info
{
    partial class MainForm : FormShadow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.PanelHead = new System.Windows.Forms.Panel();
            this.ButtonHide = new System.Windows.Forms.Button();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.LabelHead = new System.Windows.Forms.Label();
            this.PanelMain = new System.Windows.Forms.Panel();
            this.PanelInfo = new System.Windows.Forms.Panel();
            this.PanelFirebase = new System.Windows.Forms.Panel();
            this.ListOfKeys = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LabelDispatcher = new System.Windows.Forms.Label();
            this.LinkLabelOfProcesses = new System.Windows.Forms.LinkLabel();
            this.LinkSMART = new System.Windows.Forms.LinkLabel();
            this.LabelInfo = new System.Windows.Forms.Label();
            this.LabelOS = new System.Windows.Forms.Label();
            this.LabelDisk = new System.Windows.Forms.Label();
            this.LabelRAM = new System.Windows.Forms.Label();
            this.LabelMonitor = new System.Windows.Forms.Label();
            this.LabelGPU = new System.Windows.Forms.Label();
            this.LabelMotherboard = new System.Windows.Forms.Label();
            this.LabelCPU = new System.Windows.Forms.Label();
            this.PanelProcess = new System.Windows.Forms.Panel();
            this.LabelProcess = new System.Windows.Forms.Label();
            this.ListViewProcesses = new System.Windows.Forms.ListView();
            this.ColumnProcess = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnRAM = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PanelSMART = new System.Windows.Forms.Panel();
            this.LabelSMART = new System.Windows.Forms.Label();
            this.ListViewSMART = new System.Windows.Forms.ListView();
            this.ColumnHeaderAttributeName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeaderCurrent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeaderWorst = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeaderThreshold = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeaderData = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeaderStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TimerUpdateInfo = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.TimerUpdateProcesses = new System.Windows.Forms.Timer(this.components);
            this.PanelHead.SuspendLayout();
            this.PanelMain.SuspendLayout();
            this.PanelInfo.SuspendLayout();
            this.PanelFirebase.SuspendLayout();
            this.PanelProcess.SuspendLayout();
            this.PanelSMART.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelHead
            // 
            this.PanelHead.BackColor = System.Drawing.Color.Transparent;
            this.PanelHead.Controls.Add(this.ButtonHide);
            this.PanelHead.Controls.Add(this.ButtonClose);
            this.PanelHead.Controls.Add(this.LabelHead);
            this.PanelHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHead.Location = new System.Drawing.Point(0, 0);
            this.PanelHead.Name = "PanelHead";
            this.PanelHead.Size = new System.Drawing.Size(735, 30);
            this.PanelHead.TabIndex = 3;
            // 
            // ButtonHide
            // 
            this.ButtonHide.FlatAppearance.BorderSize = 0;
            this.ButtonHide.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(46)))), ((int)(((byte)(52)))));
            this.ButtonHide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(52)))), ((int)(((byte)(59)))));
            this.ButtonHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonHide.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.ButtonHide.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ButtonHide.Location = new System.Drawing.Point(670, 0);
            this.ButtonHide.Name = "ButtonHide";
            this.ButtonHide.Size = new System.Drawing.Size(33, 30);
            this.ButtonHide.TabIndex = 6;
            this.ButtonHide.TabStop = false;
            this.ButtonHide.Text = "—";
            this.ButtonHide.UseVisualStyleBackColor = true;
            this.ButtonHide.Click += new System.EventHandler(this.ButtonHide_Click);
            // 
            // ButtonClose
            // 
            this.ButtonClose.FlatAppearance.BorderSize = 0;
            this.ButtonClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(46)))), ((int)(((byte)(52)))));
            this.ButtonClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(52)))), ((int)(((byte)(59)))));
            this.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonClose.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.ButtonClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ButtonClose.Location = new System.Drawing.Point(702, 0);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(33, 30);
            this.ButtonClose.TabIndex = 4;
            this.ButtonClose.TabStop = false;
            this.ButtonClose.Text = "✖";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // LabelHead
            // 
            this.LabelHead.AutoSize = true;
            this.LabelHead.Font = new System.Drawing.Font("Courier New", 13.25F, System.Drawing.FontStyle.Bold);
            this.LabelHead.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LabelHead.Location = new System.Drawing.Point(12, 5);
            this.LabelHead.Name = "LabelHead";
            this.LabelHead.Size = new System.Drawing.Size(54, 21);
            this.LabelHead.TabIndex = 1;
            this.LabelHead.Text = "Info";
            // 
            // PanelMain
            // 
            this.PanelMain.BackColor = System.Drawing.Color.Transparent;
            this.PanelMain.Controls.Add(this.PanelInfo);
            this.PanelMain.Controls.Add(this.PanelProcess);
            this.PanelMain.Controls.Add(this.PanelSMART);
            this.PanelMain.Location = new System.Drawing.Point(1, 30);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(731, 489);
            this.PanelMain.TabIndex = 16;
            // 
            // PanelInfo
            // 
            this.PanelInfo.AutoScroll = true;
            this.PanelInfo.BackColor = System.Drawing.Color.Transparent;
            this.PanelInfo.Controls.Add(this.PanelFirebase);
            this.PanelInfo.Controls.Add(this.LabelDispatcher);
            this.PanelInfo.Controls.Add(this.LinkLabelOfProcesses);
            this.PanelInfo.Controls.Add(this.LinkSMART);
            this.PanelInfo.Controls.Add(this.LabelInfo);
            this.PanelInfo.Controls.Add(this.LabelOS);
            this.PanelInfo.Controls.Add(this.LabelDisk);
            this.PanelInfo.Controls.Add(this.LabelRAM);
            this.PanelInfo.Controls.Add(this.LabelMonitor);
            this.PanelInfo.Controls.Add(this.LabelGPU);
            this.PanelInfo.Controls.Add(this.LabelMotherboard);
            this.PanelInfo.Controls.Add(this.LabelCPU);
            this.PanelInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelInfo.Location = new System.Drawing.Point(0, 0);
            this.PanelInfo.Name = "PanelInfo";
            this.PanelInfo.Size = new System.Drawing.Size(731, 489);
            this.PanelInfo.TabIndex = 33;
            // 
            // PanelFirebase
            // 
            this.PanelFirebase.AutoScroll = true;
            this.PanelFirebase.Controls.Add(this.ListOfKeys);
            this.PanelFirebase.Location = new System.Drawing.Point(0, 0);
            this.PanelFirebase.Name = "PanelFirebase";
            this.PanelFirebase.Size = new System.Drawing.Size(87, 489);
            this.PanelFirebase.TabIndex = 50;
            // 
            // ListOfKeys
            // 
            this.ListOfKeys.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.ListOfKeys.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.ListOfKeys.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListOfKeys.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.ListOfKeys.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListOfKeys.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.ListOfKeys.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ListOfKeys.HideSelection = false;
            this.ListOfKeys.LabelWrap = false;
            this.ListOfKeys.Location = new System.Drawing.Point(0, 0);
            this.ListOfKeys.Name = "ListOfKeys";
            this.ListOfKeys.Size = new System.Drawing.Size(87, 489);
            this.ListOfKeys.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.ListOfKeys.TabIndex = 2;
            this.ListOfKeys.UseCompatibleStateImageBehavior = false;
            this.ListOfKeys.View = System.Windows.Forms.View.List;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 102;
            // 
            // LabelDispatcher
            // 
            this.LabelDispatcher.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelDispatcher.AutoSize = true;
            this.LabelDispatcher.Font = new System.Drawing.Font("Tahoma", 10.5F);
            this.LabelDispatcher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LabelDispatcher.Location = new System.Drawing.Point(185, 280);
            this.LabelDispatcher.Name = "LabelDispatcher";
            this.LabelDispatcher.Size = new System.Drawing.Size(124, 17);
            this.LabelDispatcher.TabIndex = 49;
            this.LabelDispatcher.Text = "Диспетчер задач:";
            this.LabelDispatcher.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LinkLabelOfProcesses
            // 
            this.LinkLabelOfProcesses.ActiveLinkColor = System.Drawing.Color.White;
            this.LinkLabelOfProcesses.AutoSize = true;
            this.LinkLabelOfProcesses.Font = new System.Drawing.Font("Tahoma", 10.5F);
            this.LinkLabelOfProcesses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LinkLabelOfProcesses.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.LinkLabelOfProcesses.Location = new System.Drawing.Point(308, 280);
            this.LinkLabelOfProcesses.MaximumSize = new System.Drawing.Size(400, 0);
            this.LinkLabelOfProcesses.Name = "LinkLabelOfProcesses";
            this.LinkLabelOfProcesses.Size = new System.Drawing.Size(72, 17);
            this.LinkLabelOfProcesses.TabIndex = 48;
            this.LinkLabelOfProcesses.TabStop = true;
            this.LinkLabelOfProcesses.Text = "Процессы";
            this.LinkLabelOfProcesses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LinkLabelOfProcesses.VisitedLinkColor = System.Drawing.Color.White;
            this.LinkLabelOfProcesses.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelOfProcesses_LinkClicked);
            // 
            // LinkSMART
            // 
            this.LinkSMART.ActiveLinkColor = System.Drawing.Color.White;
            this.LinkSMART.AutoSize = true;
            this.LinkSMART.Font = new System.Drawing.Font("Tahoma", 10.5F);
            this.LinkSMART.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LinkSMART.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.LinkSMART.Location = new System.Drawing.Point(307, 250);
            this.LinkSMART.MaximumSize = new System.Drawing.Size(400, 0);
            this.LinkSMART.Name = "LinkSMART";
            this.LinkSMART.Size = new System.Drawing.Size(0, 17);
            this.LinkSMART.TabIndex = 47;
            this.LinkSMART.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LinkSMART.VisitedLinkColor = System.Drawing.Color.White;
            this.LinkSMART.Click += new System.EventHandler(this.LinkSmartClick);
            // 
            // LabelInfo
            // 
            this.LabelInfo.AutoSize = true;
            this.LabelInfo.Font = new System.Drawing.Font("Tahoma", 13.25F, System.Drawing.FontStyle.Bold);
            this.LabelInfo.ForeColor = System.Drawing.Color.White;
            this.LabelInfo.Location = new System.Drawing.Point(199, 26);
            this.LabelInfo.Name = "LabelInfo";
            this.LabelInfo.Size = new System.Drawing.Size(336, 22);
            this.LabelInfo.TabIndex = 41;
            this.LabelInfo.Text = "Информация о данном устройстве";
            // 
            // LabelOS
            // 
            this.LabelOS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelOS.AutoSize = true;
            this.LabelOS.Font = new System.Drawing.Font("Tahoma", 10.5F);
            this.LabelOS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LabelOS.Location = new System.Drawing.Point(145, 70);
            this.LabelOS.Name = "LabelOS";
            this.LabelOS.Size = new System.Drawing.Size(164, 17);
            this.LabelOS.TabIndex = 40;
            this.LabelOS.Text = "Операционная система:";
            this.LabelOS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabelDisk
            // 
            this.LabelDisk.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelDisk.AutoSize = true;
            this.LabelDisk.Font = new System.Drawing.Font("Tahoma", 10.5F);
            this.LabelDisk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LabelDisk.Location = new System.Drawing.Point(182, 250);
            this.LabelDisk.Name = "LabelDisk";
            this.LabelDisk.Size = new System.Drawing.Size(127, 17);
            this.LabelDisk.TabIndex = 39;
            this.LabelDisk.Text = "Хранение данных:";
            this.LabelDisk.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabelRAM
            // 
            this.LabelRAM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelRAM.AutoSize = true;
            this.LabelRAM.Font = new System.Drawing.Font("Tahoma", 10.5F);
            this.LabelRAM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LabelRAM.Location = new System.Drawing.Point(161, 220);
            this.LabelRAM.MaximumSize = new System.Drawing.Size(600, 0);
            this.LabelRAM.Name = "LabelRAM";
            this.LabelRAM.Size = new System.Drawing.Size(148, 17);
            this.LabelRAM.TabIndex = 38;
            this.LabelRAM.Text = "Оперативная память:";
            this.LabelRAM.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabelMonitor
            // 
            this.LabelMonitor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelMonitor.AutoSize = true;
            this.LabelMonitor.Font = new System.Drawing.Font("Tahoma", 10.5F);
            this.LabelMonitor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LabelMonitor.Location = new System.Drawing.Point(238, 190);
            this.LabelMonitor.Name = "LabelMonitor";
            this.LabelMonitor.Size = new System.Drawing.Size(71, 17);
            this.LabelMonitor.TabIndex = 37;
            this.LabelMonitor.Text = "Монитор:";
            this.LabelMonitor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabelGPU
            // 
            this.LabelGPU.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelGPU.AutoSize = true;
            this.LabelGPU.Font = new System.Drawing.Font("Tahoma", 10.5F);
            this.LabelGPU.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LabelGPU.Location = new System.Drawing.Point(220, 160);
            this.LabelGPU.Name = "LabelGPU";
            this.LabelGPU.Size = new System.Drawing.Size(89, 17);
            this.LabelGPU.TabIndex = 35;
            this.LabelGPU.Text = "Видеокарта:";
            this.LabelGPU.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabelMotherboard
            // 
            this.LabelMotherboard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelMotherboard.AutoSize = true;
            this.LabelMotherboard.Font = new System.Drawing.Font("Tahoma", 10.5F);
            this.LabelMotherboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LabelMotherboard.Location = new System.Drawing.Point(170, 130);
            this.LabelMotherboard.MaximumSize = new System.Drawing.Size(600, 0);
            this.LabelMotherboard.Name = "LabelMotherboard";
            this.LabelMotherboard.Size = new System.Drawing.Size(139, 17);
            this.LabelMotherboard.TabIndex = 34;
            this.LabelMotherboard.Text = "Материнская плата:";
            this.LabelMotherboard.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabelCPU
            // 
            this.LabelCPU.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelCPU.AutoSize = true;
            this.LabelCPU.Font = new System.Drawing.Font("Tahoma", 10.5F);
            this.LabelCPU.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LabelCPU.Location = new System.Drawing.Point(226, 100);
            this.LabelCPU.Name = "LabelCPU";
            this.LabelCPU.Size = new System.Drawing.Size(83, 17);
            this.LabelCPU.TabIndex = 2;
            this.LabelCPU.Text = "Процессор:";
            this.LabelCPU.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PanelProcess
            // 
            this.PanelProcess.AutoScroll = true;
            this.PanelProcess.BackColor = System.Drawing.Color.Transparent;
            this.PanelProcess.Controls.Add(this.LabelProcess);
            this.PanelProcess.Controls.Add(this.ListViewProcesses);
            this.PanelProcess.Location = new System.Drawing.Point(0, 0);
            this.PanelProcess.Name = "PanelProcess";
            this.PanelProcess.Size = new System.Drawing.Size(735, 489);
            this.PanelProcess.TabIndex = 50;
            // 
            // LabelProcess
            // 
            this.LabelProcess.AutoSize = true;
            this.LabelProcess.Font = new System.Drawing.Font("Courier New", 13.25F, System.Drawing.FontStyle.Bold);
            this.LabelProcess.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LabelProcess.Location = new System.Drawing.Point(280, 459);
            this.LabelProcess.Name = "LabelProcess";
            this.LabelProcess.Size = new System.Drawing.Size(175, 21);
            this.LabelProcess.TabIndex = 2;
            this.LabelProcess.Text = "Диспетчер задач";
            // 
            // ListViewProcesses
            // 
            this.ListViewProcesses.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.ListViewProcesses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.ListViewProcesses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListViewProcesses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnProcess,
            this.ColumnRAM});
            this.ListViewProcesses.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.ListViewProcesses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ListViewProcesses.HideSelection = false;
            this.ListViewProcesses.LabelWrap = false;
            this.ListViewProcesses.Location = new System.Drawing.Point(108, 26);
            this.ListViewProcesses.Name = "ListViewProcesses";
            this.ListViewProcesses.Size = new System.Drawing.Size(518, 425);
            this.ListViewProcesses.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.ListViewProcesses.TabIndex = 1;
            this.ListViewProcesses.UseCompatibleStateImageBehavior = false;
            this.ListViewProcesses.View = System.Windows.Forms.View.Details;
            this.ListViewProcesses.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.ListView_ColumnClick);
            // 
            // ColumnProcess
            // 
            this.ColumnProcess.Text = "Процесс";
            this.ColumnProcess.Width = 300;
            // 
            // ColumnRAM
            // 
            this.ColumnRAM.Text = "Память";
            this.ColumnRAM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColumnRAM.Width = 130;
            // 
            // PanelSMART
            // 
            this.PanelSMART.AutoScroll = true;
            this.PanelSMART.BackColor = System.Drawing.Color.Transparent;
            this.PanelSMART.Controls.Add(this.LabelSMART);
            this.PanelSMART.Controls.Add(this.ListViewSMART);
            this.PanelSMART.Location = new System.Drawing.Point(0, 0);
            this.PanelSMART.Name = "PanelSMART";
            this.PanelSMART.Size = new System.Drawing.Size(735, 489);
            this.PanelSMART.TabIndex = 51;
            // 
            // LabelSMART
            // 
            this.LabelSMART.AutoSize = true;
            this.LabelSMART.Font = new System.Drawing.Font("Courier New", 13.25F, System.Drawing.FontStyle.Bold);
            this.LabelSMART.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LabelSMART.Location = new System.Drawing.Point(241, 459);
            this.LabelSMART.Name = "LabelSMART";
            this.LabelSMART.Size = new System.Drawing.Size(252, 21);
            this.LabelSMART.TabIndex = 3;
            this.LabelSMART.Text = "Сканировано устройств:";
            // 
            // ListViewSMART
            // 
            this.ListViewSMART.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.ListViewSMART.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.ListViewSMART.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListViewSMART.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeaderAttributeName,
            this.ColumnHeaderCurrent,
            this.ColumnHeaderWorst,
            this.ColumnHeaderThreshold,
            this.ColumnHeaderData,
            this.ColumnHeaderStatus});
            this.ListViewSMART.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.ListViewSMART.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ListViewSMART.HideSelection = false;
            this.ListViewSMART.LabelWrap = false;
            this.ListViewSMART.Location = new System.Drawing.Point(108, 26);
            this.ListViewSMART.Name = "ListViewSMART";
            this.ListViewSMART.Size = new System.Drawing.Size(518, 425);
            this.ListViewSMART.TabIndex = 1;
            this.ListViewSMART.UseCompatibleStateImageBehavior = false;
            this.ListViewSMART.View = System.Windows.Forms.View.Details;
            // 
            // ColumnHeaderAttributeName
            // 
            this.ColumnHeaderAttributeName.Text = "Attribute Name";
            this.ColumnHeaderAttributeName.Width = 350;
            // 
            // ColumnHeaderCurrent
            // 
            this.ColumnHeaderCurrent.Text = "Current";
            this.ColumnHeaderCurrent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColumnHeaderCurrent.Width = 130;
            // 
            // ColumnHeaderWorst
            // 
            this.ColumnHeaderWorst.Text = "Worst";
            this.ColumnHeaderWorst.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ColumnHeaderThreshold
            // 
            this.ColumnHeaderThreshold.Text = "Threshold";
            this.ColumnHeaderThreshold.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ColumnHeaderData
            // 
            this.ColumnHeaderData.Text = "Data";
            this.ColumnHeaderData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ColumnHeaderStatus
            // 
            this.ColumnHeaderStatus.Text = "Status";
            this.ColumnHeaderStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TimerUpdateInfo
            // 
            this.TimerUpdateInfo.Enabled = true;
            this.TimerUpdateInfo.Interval = 1000;
            this.TimerUpdateInfo.Tick += new System.EventHandler(this.TimerUpdateInfo_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "Info";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.BalloonTipClosed += new System.EventHandler(this.NotifyIcon1_BalloonTipClosed);
            // 
            // TimerUpdateProcesses
            // 
            this.TimerUpdateProcesses.Interval = 3000;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(735, 519);
            this.ControlBox = false;
            this.Controls.Add(this.PanelMain);
            this.Controls.Add(this.PanelHead);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Info";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.PanelHead.ResumeLayout(false);
            this.PanelHead.PerformLayout();
            this.PanelMain.ResumeLayout(false);
            this.PanelInfo.ResumeLayout(false);
            this.PanelInfo.PerformLayout();
            this.PanelFirebase.ResumeLayout(false);
            this.PanelProcess.ResumeLayout(false);
            this.PanelProcess.PerformLayout();
            this.PanelSMART.ResumeLayout(false);
            this.PanelSMART.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PanelHead;
        private System.Windows.Forms.Label LabelHead;
        private System.Windows.Forms.Panel PanelMain;
        private System.Windows.Forms.Button ButtonHide;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.Label LabelCPU;
        private System.Windows.Forms.Panel PanelInfo;
        private System.Windows.Forms.Label LabelMonitor;
        private System.Windows.Forms.Label LabelGPU;
        private System.Windows.Forms.Label LabelMotherboard;
        private System.Windows.Forms.Label LabelRAM;
        private System.Windows.Forms.Label LabelDisk;
        private System.Windows.Forms.Label LabelOS;
        private System.Windows.Forms.Label LabelInfo;
        private System.Windows.Forms.LinkLabel LinkSMART;
        private System.Windows.Forms.Timer TimerUpdateInfo;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.LinkLabel LinkLabelOfProcesses;
        private System.Windows.Forms.Label LabelDispatcher;
        private System.Windows.Forms.Panel PanelProcess;
        private System.Windows.Forms.ListView ListViewProcesses;
        private System.Windows.Forms.ColumnHeader ColumnProcess;
        private System.Windows.Forms.ColumnHeader ColumnRAM;
        private System.Windows.Forms.Label LabelProcess;
        private System.Windows.Forms.Timer TimerUpdateProcesses;
        private System.Windows.Forms.Panel PanelSMART;
        private System.Windows.Forms.ListView ListViewSMART;
        private System.Windows.Forms.ColumnHeader ColumnHeaderAttributeName;
        private System.Windows.Forms.ColumnHeader ColumnHeaderCurrent;
        private System.Windows.Forms.ColumnHeader ColumnHeaderWorst;
        private System.Windows.Forms.ColumnHeader ColumnHeaderThreshold;
        private System.Windows.Forms.ColumnHeader ColumnHeaderData;
        private System.Windows.Forms.ColumnHeader ColumnHeaderStatus;
        private System.Windows.Forms.Label LabelSMART;
        private System.Windows.Forms.Panel PanelFirebase;
        private System.Windows.Forms.ListView ListOfKeys;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}

