using Info.Windows;

namespace Info
{
    sealed partial class NotificationForm : FormShadow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotificationForm));
            this.PanelHead = new System.Windows.Forms.Panel();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.LabelHead = new System.Windows.Forms.Label();
            this.PanelMain = new System.Windows.Forms.Panel();
            this.LabelNotif = new System.Windows.Forms.Label();
            this.ButtonNotifClose = new System.Windows.Forms.Button();
            this.PanelHead.SuspendLayout();
            this.PanelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelHead
            // 
            this.PanelHead.BackColor = System.Drawing.Color.Transparent;
            this.PanelHead.Controls.Add(this.ButtonClose);
            this.PanelHead.Controls.Add(this.LabelHead);
            this.PanelHead.Location = new System.Drawing.Point(0, 0);
            this.PanelHead.Name = "PanelHead";
            this.PanelHead.Size = new System.Drawing.Size(375, 30);
            this.PanelHead.TabIndex = 3;
            // 
            // ButtonClose
            // 
            this.ButtonClose.FlatAppearance.BorderSize = 0;
            this.ButtonClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(46)))), ((int)(((byte)(52)))));
            this.ButtonClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(52)))), ((int)(((byte)(59)))));
            this.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonClose.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.ButtonClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ButtonClose.Location = new System.Drawing.Point(342, 0);
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
            this.PanelMain.Controls.Add(this.ButtonNotifClose);
            this.PanelMain.Controls.Add(this.LabelNotif);
            this.PanelMain.Location = new System.Drawing.Point(1, 30);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(374, 154);
            this.PanelMain.TabIndex = 16;
            // 
            // LabelNotif
            // 
            this.LabelNotif.AutoSize = true;
            this.LabelNotif.Font = new System.Drawing.Font("Tahoma", 12.5F);
            this.LabelNotif.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LabelNotif.Location = new System.Drawing.Point(63, 18);
            this.LabelNotif.MaximumSize = new System.Drawing.Size(270, 0);
            this.LabelNotif.Name = "LabelNotif";
            this.LabelNotif.Size = new System.Drawing.Size(249, 42);
            this.LabelNotif.TabIndex = 2;
            this.LabelNotif.Text = "Данные о Вашей системной информации занесены в базу.";
            // 
            // ButtonNotifClose
            // 
            this.ButtonNotifClose.BackColor = System.Drawing.Color.Silver;
            this.ButtonNotifClose.FlatAppearance.BorderSize = 0;
            this.ButtonNotifClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonNotifClose.Font = new System.Drawing.Font("Courier New", 13.25F, System.Drawing.FontStyle.Bold);
            this.ButtonNotifClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.ButtonNotifClose.Location = new System.Drawing.Point(143, 97);
            this.ButtonNotifClose.Name = "ButtonNotifClose";
            this.ButtonNotifClose.Size = new System.Drawing.Size(89, 29);
            this.ButtonNotifClose.TabIndex = 3;
            this.ButtonNotifClose.Text = "OK";
            this.ButtonNotifClose.UseVisualStyleBackColor = false;
            // 
            // NotificationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(374, 184);
            this.ControlBox = false;
            this.Controls.Add(this.PanelMain);
            this.Controls.Add(this.PanelHead);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NotificationForm";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Info Notification";
            this.Load += new System.EventHandler(this.NotificationForm_Load);
            this.PanelHead.ResumeLayout(false);
            this.PanelHead.PerformLayout();
            this.PanelMain.ResumeLayout(false);
            this.PanelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PanelHead;
        private System.Windows.Forms.Label LabelHead;
        private System.Windows.Forms.Panel PanelMain;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.Label LabelNotif;
        private System.Windows.Forms.Button ButtonNotifClose;
    }
}

