using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace mCopernicus
{
    public partial class Form1 : MaterialForm
    {
        Process process = new Process();
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
            runSS("./shadowsocks-libqss.exe", "-T");
        }

        public void runSS(string ssFile, string cmdStr)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = ssFile;
            startInfo.Arguments = cmdStr;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardInput = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.CreateNoWindow = true;
            process.StartInfo = startInfo;
            process.Start();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!process.HasExited)
            {
                process.Kill();
            }
            MessageBox.Show(process.StandardOutput.ReadToEnd().ToString());
            process.Close();
        }
    }
}
