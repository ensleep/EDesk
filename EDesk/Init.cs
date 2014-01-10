using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;
using System.IO;

namespace EDesk
{
    public static class Init
    {
        public static void SetIe9Version()
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
        }
        public static void CheckConfig()
        {
            if (!File.Exists("App.config"))
            {
                throw new Exception("对不起，由于App.config文件丢失，无法启动软件"+AllResource.BugCommitString);
            }
        }
    }
}
