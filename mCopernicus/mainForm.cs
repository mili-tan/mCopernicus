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
        Process process;
        public mainForm()
        {
            InitializeComponent();
        }

        class SSParameter
        {
            public string ConfigFile = "-c ";

        }

        private void mianForm_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;

            DirectoryInfo folder = new DirectoryInfo(@"./config");

            foreach (FileInfo file in folder.GetFiles("*.json"))
            {
                mlListView.Items.Add(file.Name.Replace(".json",""));
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
                runSS("./shadowsocks-libqss.exe", string.Format(@"{0} .\config\{1}.json", "-c", fileName));
                mlListView.Items[selectedIndex[0]].Selected = true;
                mlListView.Items[selectedIndex[0]].Focused = true;
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
                MessageBox.Show(process.StandardOutput.ReadToEnd().ToString());
                process.Close();
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            new addForm(null,null,null,null).ShowDialog();
        }

        private void mlListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
