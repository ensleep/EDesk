using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Windows.Forms;

namespace EDesk
{
    /// <summary>
    /// 主窗体
    /// </summary>
    [System.Runtime.InteropServices.ComVisible(true)] 
    public partial class Form1 : Form
    {
        /// <summary>
        /// 构造方法
        /// </summary>
        public Form1()
        {
            setFormOnDesktop();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {  
            //this.Top = 0;
            //this.Left = 0;
            //this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            //this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            string url = @"file:///" + Application.StartupPath + @"\Html\Desk.html?t="+DateTime.Now.ToString("yyyyMMddhhmmssfffff");
            url = url.Replace("\\", "/").Replace(" ","%20");
            WBDesk.Url = new Uri(url);
            WBDesk.ObjectForScripting = this;
            WBDesk.ScriptErrorsSuppressed = false;
            ChangeTaskBar();
            Hashtable[] hsDesk = FileHelper.GetDeskTop();
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            this.notify.Visible = false;
            base.OnClosing(e);
        }
        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                ResetWin();
            }
        }

        private void notify_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ResetWin();
        }

        private void notify_MouseMove(object sender, MouseEventArgs e)
        {
            notify.ShowBalloonTip(3000);
        }


        
    }
}
