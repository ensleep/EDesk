using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Win32;

namespace EDesk
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            RegistryKey rsg = null;
            try
            {
                rsg = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Internet Explorer\MAIN\FeatureControl\FEATURE_BROWSER_EMULATION", true);   //true表可以修改
            }
            catch (Exception ex)
            {
                Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Microsoft\Internet Explorer\MAIN\FeatureControl\FEATURE_BROWSER_EMULATION");
            }
            if (rsg.GetValue("EDesk.exe") == null)
            {
                rsg.SetValue("EDesk.exe", 0x00002328, RegistryValueKind.DWord);       //写入
                rsg.SetValue("EDesk.vshost.exe", 0x00002328, RegistryValueKind.DWord);
                rsg.Close();
            }
            else
            {
                rsg.Close();
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
