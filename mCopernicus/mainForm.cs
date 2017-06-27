using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mCopernicus
{
    public partial class mainForm : MaterialForm
    {
        Icon mIco = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
        Process process;
        DirectoryInfo folder;
        string logStr = null;
        public mainForm()
        {
            InitializeComponent();
            Process[] processes = Process.GetProcessesByName(Application.CompanyName);
            if (processes.Length > 1)
            {
                MessageBox.Show("已有一个mCopernicus实例正在运行,请不要重复启动", "mCopernicus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Environment.Exit(1);
            }

            notifyIcon.Icon = mIco;
            notifyIcon.Visible = false;
        }

        class SSParameter
        {
            public string ConfigFile = "-c ";
        }

        private void mianForm_Load(object sender, EventArgs e)
        {
            UrlReg.Reg("ss");
            MaximizeBox = false;

            if (!Directory.Exists(string.Format(@"{0}/config", Application.StartupPath)))
            {
                Directory.CreateDirectory(string.Format(@"{0}/config", Application.StartupPath));
            }

            folder = new DirectoryInfo(string.Format(@"{0}/config", Application.StartupPath));

            foreach (FileInfo file in folder.GetFiles("*.json"))
            {
                mlListView.Items.Add(file.Name.Replace(".json", ""));
            }

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey500, Primary.BlueGrey700, Primary.BlueGrey700, Accent.Blue400, TextShade.WHITE);
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            ListView.SelectedIndexCollection selectedIndex = null;
            string fileName = null;
            if (mlListView.SelectedIndices != null && mlListView.SelectedIndices.Count > 0)
            {
                selectedIndex = mlListView.SelectedIndices;
                fileName = mlListView.Items[selectedIndex[0]].Text;
            }
            if (fileName == null || fileName == "")
            {
                MessageBox.Show("请选择您的连接", "mCopernicus", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                runSS("./shadowsocks-libqss.exe", string.Format("-c {0}/config/{1}.json", Application.StartupPath, fileName));
            }
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
                logStr = logStr + process.StandardOutput.ReadToEnd().ToString();
                MessageBox.Show(logStr);
                File.WriteAllText(string.Format("{0}/m.log", Application.StartupPath), string.Format("{0}\n\r{1}", DateTime.Now.ToString(), logStr));
                process.Close();
            }
            UrlReg.UnReg("ss");
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            new addForm(null, null, null, null, null).ShowDialog();
            mlListView.Items.Clear();
            foreach (FileInfo file in folder.GetFiles("*.json"))
            {
                mlListView.Items.Add(file.Name.Replace(".json", ""));
            }
        }

        private void timerRefresh_Tick(object sender, EventArgs e)
        {
            mlListView.Items.Clear();
            foreach (FileInfo file in folder.GetFiles("*.json"))
            {
                mlListView.Items.Add(file.Name.Replace(".json", ""));
            }
        }

        private void mainForm_Activated(object sender, EventArgs e)
        {
            mlListView.Items.Clear();
            foreach (FileInfo file in folder.GetFiles("*.json"))
            {
                mlListView.Items.Add(file.Name.Replace(".json", ""));
            }
        }

        private void timerCheckSelect_Tick(object sender, EventArgs e)
        {
            if (mlListView.SelectedItems.Count > 0)
            {
                editButton.Enabled = true;
            }
            else
            {
                editButton.Enabled = false;
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            ListView.SelectedIndexCollection selectedIndex = null;
            string fileName = null;
            if (mlListView.SelectedIndices != null && mlListView.SelectedIndices.Count > 0)
            {
                selectedIndex = mlListView.SelectedIndices;
                fileName = mlListView.Items[selectedIndex[0]].Text;
            }
            new addForm(null, null, null, null, fileName).ShowDialog();
        }

        private void mainForm_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (process != null)
            {
                //logStr = logStr + process.StandardOutput.ReadToEnd().ToString();
                //MessageBox.Show(logStr);
            }
        }

        private void mainForm_SizeChanged(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                ShowInTaskbar = false;
                notifyIcon.Visible = true;
            }
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                WindowState = FormWindowState.Normal;
                Activate();
                ShowInTaskbar = true;
                notifyIcon.Visible = false;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notifyIcon_MouseDoubleClick(null, null);
        }
    }
}
