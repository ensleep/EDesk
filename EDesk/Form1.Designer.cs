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
            this.SuspendLayout();
            // 
            // WBDesk
            // 
            this.WBDesk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WBDesk.Location = new System.Drawing.Point(0, 0);
            this.WBDesk.MinimumSize = new System.Drawing.Size(20, 20);
            this.WBDesk.Name = "WBDesk";
            this.WBDesk.Size = new System.Drawing.Size(862, 388);
            this.WBDesk.TabIndex = 0;
            this.WBDesk.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // notify
            // 
            this.notify.BalloonTipText = "│＼＿＿╭╭╭╭╭＿＿／│ \r\n│　　　　　　　　　　　│ \r\n│　　　　　　　　　　　│ \r\n│　＞　　　　　　　●　 │ \r\n│≡　　╰┬┬┬╯　　≡│ \r\n" +
    "│　　　　╰─╯　　　　│ \r\n╰──┬Ｏ───Ｏ┬──╯ \r\n　　　│EDesk │ \r\n　　　╰┬───┬╯";
            this.notify.BalloonTipTitle = "EDesk为自由而战";
            this.notify.Icon = ((System.Drawing.Icon)(resources.GetObject("notify.Icon")));
            this.notify.Text = "EDesk";
            this.notify.Visible = true;
            this.notify.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notify_MouseDoubleClick);
            this.notify.MouseMove += new System.Windows.Forms.MouseEventHandler(this.notify_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 388);
            this.Controls.Add(this.WBDesk);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "EDesk";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser WBDesk;
        private System.Windows.Forms.NotifyIcon notify;
    }
}

