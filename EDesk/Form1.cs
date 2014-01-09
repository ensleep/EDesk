using System;
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
    [System.Runtime.InteropServices.ComVisible(true)] 
    public partial class Form1 : Form
    {
        public Form1()
        {
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
        }
        public void OpenMyComputer()
        {
            System.Diagnostics.Process.Start("::{20D04FE0-3AEA-1069-A2D8-08002B30309D}");
        }
        public void ChangeTaskBar()
        {
            if (this.Height != Screen.PrimaryScreen.WorkingArea.Height)
            {
                this.WindowState = FormWindowState.Normal;
                this.Top = 0;
                this.Left = 0;
                this.Width = Screen.PrimaryScreen.WorkingArea.Width;
                this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }
    }
}
