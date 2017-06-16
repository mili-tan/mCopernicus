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
        public static void Reg(string point)
        {
            RegistryKey surekamKey = Registry.ClassesRoot.CreateSubKey(point);
            RegistryKey shellKey = surekamKey.CreateSubKey("shell");
            RegistryKey openKey = shellKey.CreateSubKey("open");
            RegistryKey commandKey = openKey.CreateSubKey("command");
            surekamKey.SetValue("URL Protocol", "");
            var exePath = Process.GetCurrentProcess().MainModule.FileName;
            commandKey.SetValue("", "\"" + exePath + "\"" + " \"%1\"");
        }
        public static void UnReg(string point)
        {
            Registry.ClassesRoot.DeleteSubKeyTree(point);
        }
    }
}
