using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mCopernicus
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (!string.IsNullOrWhiteSpace(string.Join("", args)))
            {
                Application.Run(new urlForm(string.Join("", args)));
            }
            else
            {
                Application.Run(new mainForm());
            }
        }
    }
}
