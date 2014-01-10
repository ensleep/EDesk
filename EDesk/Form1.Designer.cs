namespace EDesk
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.WBDesk = new System.Windows.Forms.WebBrowser();
            this.notify = new System.Windows.Forms.NotifyIcon(this.components);
            this.nofityMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.changeTaskBarColor = new System.Windows.Forms.ToolStripMenuItem();
            this.about = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.colorDialogNotify = new System.Windows.Forms.ColorDialog();
            this.nofityMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // WBDesk
            // 
            this.WBDesk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WBDesk.Location = new System.Drawing.Point(0, 0);
            this.WBDesk.MinimumSize = new System.Drawing.Size(20, 20);
            this.WBDesk.Name = "WBDesk";
            this.WBDesk.ScrollBarsEnabled = false;
            this.WBDesk.Size = new System.Drawing.Size(862, 388);
            this.WBDesk.TabIndex = 0;
            this.WBDesk.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // notify
            // 
            this.notify.BalloonTipText = "│＼＿＿╭╭╭╭╭＿＿／│ \r\n│　　　　　　　　　　　│ \r\n│　　　　　　　　　　　│ \r\n│　＞　　　　　　　●　 │ \r\n│≡　　╰┬┬┬╯　　≡│ \r\n" +
    "│　　　　╰─╯　　　　│ \r\n╰──┬Ｏ───Ｏ┬──╯ \r\n　　　│EDesk │ \r\n　　　╰┬───┬╯";
            this.notify.BalloonTipTitle = "EDesk为自由而战";
            this.notify.ContextMenuStrip = this.nofityMenu;
            this.notify.Icon = ((System.Drawing.Icon)(resources.GetObject("notify.Icon")));
            this.notify.Text = "EDesk";
            this.notify.Visible = true;
            this.notify.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notify_MouseDoubleClick);
            this.notify.MouseMove += new System.Windows.Forms.MouseEventHandler(this.notify_MouseMove);
            // 
            // nofityMenu
            // 
            this.nofityMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeTaskBarColor,
            this.about});
            this.nofityMenu.Name = "notifyMenu";
            this.nofityMenu.Size = new System.Drawing.Size(185, 70);
            // 
            // changeTaskBarColor
            // 
            this.changeTaskBarColor.Name = "changeTaskBarColor";
            this.changeTaskBarColor.Size = new System.Drawing.Size(184, 22);
            this.changeTaskBarColor.Text = "更改任务栏后方颜色";
            this.changeTaskBarColor.Click += new System.EventHandler(this.changeTaskBarColor_Click);
            // 
            // about
            // 
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(184, 22);
            this.about.Text = "关于...";
            this.about.Click += new System.EventHandler(this.about_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(0, 369);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(862, 30);
            this.panel1.TabIndex = 1;
            // 
            // colorDialogNotify
            // 
            this.colorDialogNotify.AnyColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 388);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.WBDesk);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "EDesk";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.nofityMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser WBDesk;
        private System.Windows.Forms.NotifyIcon notify;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ContextMenuStrip nofityMenu;
        private System.Windows.Forms.ToolStripMenuItem changeTaskBarColor;
        private System.Windows.Forms.ToolStripMenuItem about;
        private System.Windows.Forms.ColorDialog colorDialogNotify;
    }
}

