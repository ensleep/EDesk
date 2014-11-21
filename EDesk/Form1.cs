using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
        public DateTime t1 = DateTime.Now;
        /// <summary>
        /// 构造方法
        /// </summary>
        public Form1()
        {
            //setFormOnDesktop();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IntPtr pWnd =(IntPtr) FindWindow("Progman", null);
            //pWnd = FindWindowEx(pWnd, IntPtr.Zero, "SHELLDLL_DefVIew", null);
            //pWnd = FindWindowEx(pWnd, IntPtr.Zero, "SysListView32", null);
            //IntPtr tWnd = new System.Windows.Interop.WindowInteropHelper(this).Handle;

            ///win8
            IntPtr dwndparent;
            IntPtr dwndviem=IntPtr.Zero;
            IntPtr dwdesktopicon;
            dwndparent=FindWindowEx(IntPtr.Zero,IntPtr.Zero,"WorkerW","");//获得第一个WorkerW类的窗口
            while((IntPtr.Zero==dwndviem)&&IntPtr.Zero!=dwndparent)
            {
            dwndviem=FindWindowEx(dwndparent,IntPtr.Zero,"SHELLDLL_DefView","");
            dwndparent=FindWindowEx(IntPtr.Zero,dwndparent,"WorkerW","");
            }
            dwdesktopicon=FindWindowEx(dwndviem,IntPtr.Zero,"SysListView32","FolderView");
            SetParent((int)this.Handle, (int)dwdesktopicon);

            ///
            //SetParent((int)this.Handle,(int) pWnd);
            //this.Top = 0;
            //this.Left = 0;
            //this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            //this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            string url = @"file:///" + Application.StartupPath + @"\Html\Desk.html?t="+DateTime.Now.ToString("yyyyMMddhhmmssfffff");
            url = url.Replace("\\", "/").Replace(" ","%20");
            WBDesk.Url = new Uri(url);
            WBDesk.ObjectForScripting = this;
            WBDesk.ScriptErrorsSuppressed = false;
            ResetWin();
            Hashtable[] hsDesk = FileHelper.GetDeskTop();
            ChangeTaskBar();
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
            if (t1.AddSeconds(3) < DateTime.Now)
            {
                notify.ShowBalloonTip(3000);
                t1 = DateTime.Now;
            }
        }

        private void changeTaskBarColor_Click(object sender, EventArgs e)
        {
            if (colorDialogNotify.ShowDialog() == DialogResult.OK)
            {
                var s = colorDialogNotify.Color;
                panel1.BackColor = s;
            }
        }
        private void about_Click(object sender, EventArgs e)
        {
            AboutMe am = new AboutMe();
            am.Show();
        }



        
    }
}
