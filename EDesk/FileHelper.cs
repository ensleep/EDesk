using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace EDesk
{
    public static class FileHelper
    {
        /// <summary>
        /// 获取用户的桌面文件夹以及文件
        /// </summary>
        /// <returns>返回两个哈希表，第一个是文件夹，第二个是文件</returns>
        public static Hashtable[] GetDeskTop()
        {
            Hashtable htDeskFold = new Hashtable();
            Hashtable htDeskFiles=new Hashtable();
            DirectoryInfo allUserDir = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));

            foreach (DirectoryInfo d in allUserDir.GetDirectories())
            {
                htDeskFold.Add(d.Name, d.FullName);
            }
            foreach (FileInfo f in allUserDir.GetFiles())
            {
                htDeskFiles.Add(f.Name, f.FullName);
            }
            return new Hashtable[]{htDeskFold,htDeskFiles};
        }
    }
}
