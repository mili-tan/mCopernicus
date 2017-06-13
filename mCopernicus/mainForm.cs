using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mCopernicus
{
    public partial class mainForm : MaterialForm
    {
        Process process;
        public mainForm()
        {
            InitializeComponent();
        }

        private void mianForm_Load(object sender, EventArgs e)
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
            process = new Process();
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
            if (process != null)
            {
                if (!process.HasExited)
                {
                    process.Kill();
                }
                MessageBox.Show(process.StandardOutput.ReadToEnd().ToString());
                process.Close();
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            new addForm(null,null,null,null).ShowDialog();
        }
    }
}
