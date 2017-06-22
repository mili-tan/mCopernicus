using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mCopernicus
{
    class UrlReg
    {
        public static void Reg(string urlLink)
        {
            RegistryKey regKey = Registry.ClassesRoot.CreateSubKey(urlLink);
            RegistryKey cmdKey = regKey.CreateSubKey("shell");
            cmdKey = cmdKey.CreateSubKey("open");
            cmdKey = cmdKey.CreateSubKey("command");
            regKey.SetValue("URL Protocol", "");
            string filePath = Process.GetCurrentProcess().MainModule.FileName;
            cmdKey.SetValue("", "\"" + filePath + "\"" + " \"%1\"");
        }
        public static void UnReg(string urlLink)
        {
            Registry.ClassesRoot.DeleteSubKeyTree(urlLink);
        }
    }
}
