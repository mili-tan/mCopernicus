using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Diagnostics;

namespace mCopernicus
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey500, Primary.BlueGrey700, Primary.BlueGrey700, Accent.Blue400, TextShade.WHITE);
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            Text = runSS("./shadowsocks-libqss.exe", "-T");
        }

        public static string runSS(string ssFile, string cmdStr)
        {
            string outPut = "";
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = ssFile;
            startInfo.Arguments = cmdStr;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardInput = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.CreateNoWindow = true;
            process.StartInfo = startInfo;
            process.Start();
            try
            {
                if (process.Start())//开始进程   
                {
                    outPut = process.StandardOutput.ReadToEnd();//读取进程的输出   
                }
            }
            finally
            {
                if (process != null)
                {
                    process.Close();
                }
            }

            return outPut;
        }
    }
}
