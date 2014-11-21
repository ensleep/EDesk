using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Drawing;
namespace EDesk
{
    public partial class Form1 : Form
    {
        public const int SE_SHUTDOWN_PRIVILEGE = 0x13;
        [DllImport("user32.dll", EntryPoint = "FindWindowEx", SetLastError = true)]
        static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string lpszClass, string lpszWindow);
        [DllImport("user32.dll", EntryPoint = "ShowWindow", SetLastError = true)]
        static extern bool ShowWindow(IntPtr hWnd, uint nCmdShow);
        [DllImport("user32.dll", EntryPoint = "SetParent")]

        public static extern int SetParent(int hWndChild, int hWndNewParent);

        [DllImport("user32.dll", EntryPoint = "FindWindow")]
        public static extern int FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll")]
        public static extern bool SetWindowPos(IntPtr hWnd, int hWndInsertAfter, int X, int Y, int cx,
        int cy, uint uFlags);
        public void OpenFold(string path)
        {
            if (Directory.Exists(path))
            {
                System.Diagnostics.Process.Start("explorer.exe",path);
            }
        }
        public void setFormOnDesktop()
        {
            try
            {
                if (Environment.OSVersion.Version.Major < 6)
                {
                    base.SendToBack();
                    SetParent(base.Handle.ToInt32(), FindWindow("Progman", null));
                }
                else
                {
                    SetWindowPos(base.Handle, 1, 0, 0, 0, 0, SE_SHUTDOWN_PRIVILEGE);
                }
            }
            catch (ApplicationException exx)
            {
                MessageBox.Show(this, exx.Message, "Pin to Desktop");
            }
        }
        private void Form1_Activated(object sender, EventArgs e)
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                SetWindowPos(base.Handle, 1, 0, 0, 0, 0, SE_SHUTDOWN_PRIVILEGE);
            }
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                SetWindowPos(base.Handle, 1, 0, 0, 0, 0, SE_SHUTDOWN_PRIVILEGE);
            }
        }
        /// <summary>
        /// 打开系统的目录，比如我的电脑等
        /// </summary>
        /// <param name="FoldCode">系统目录的代码，比如我的电脑为"::{20D04FE0-3AEA-1069-A2D8-08002B30309D}"</param>
        public void ExecSysFold(string FoldCode)
        {
            System.Diagnostics.Process.Start("::{20D04FE0-3AEA-1069-A2D8-08002B30309D}");
        }
        public void ExecPro(string ProPath)
        {
            Process.Start(ProPath);
        }
        public void ShowTaskBar()
        {
            IntPtr trayHwnd = FindWindowEx(IntPtr.Zero, IntPtr.Zero, "Shell_TrayWnd", null);
            //IntPtr trayHwnd = FindWindow("Shell_TrayWnd", null);
            if (trayHwnd != IntPtr.Zero) { ShowWindow(trayHwnd, 1);}
        }
        public void HiddenTaskBar()
        {
            IntPtr trayHwnd = FindWindowEx(IntPtr.Zero, IntPtr.Zero, "Shell_TrayWnd", null);
            //IntPtr trayHwnd = FindWindow("Shell_TrayWnd", null);
            if (trayHwnd != IntPtr.Zero) { ShowWindow(trayHwnd, 0); }
        }
        ///打开我的电脑
        public void OpenMyComputer()
        {
            ExecSysFold("::{20D04FE0-3AEA-1069-A2D8-08002B30309D}");
            //WBDesk.Document.InvokeScript("show",new string[]{ "这是用cs代码调用的js"});调用js的代码
        }

        /// <summary>
        /// 更改任务栏的显示与隐藏状态,此方法与遮罩滚动条冲突，已停止使用
        /// </summary>
        public void ChangeTaskBar()
        {
            if (this.Height != Screen.PrimaryScreen.WorkingArea.Height)
            {
                this.WindowState = FormWindowState.Normal;
                this.Top = 0;
                this.Left = 0;
                this.Width = Screen.PrimaryScreen.WorkingArea.Width;
                this.Height = Screen.PrimaryScreen.WorkingArea.Height;
                ShowTaskBar();
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                HiddenTaskBar();
            }
        }
        public void ResetWin()
        {
            this.FormBorderStyle = FormBorderStyle.SizableToolWindow;
            this.WindowState = FormWindowState.Normal;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Width = Screen.PrimaryScreen.Bounds.Width;
            //this.Height = Screen.GetBounds(this).Height;
            this.Height = Screen.PrimaryScreen.Bounds.Height;
            this.Top = 0;
            this.Left = 0;
            panel1.Top = this.Height - 30;
        }
    }
}
