using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace mCopernicus
{
    public partial class addForm : Form
    {
        class ServerInfo
        {
            public string server { get; set; } 
            public int server_port { get; set; }
            public string local_address { get; set; }
            public int local_port { get; set; }
            public string password { get; set; }
            public int timeout { get; set; }
            public string method { get; set; }
            public bool http_proxy { get; set; }
            public bool auth { get; set; }
        }

        ServerInfo serverInfoFile;

        public addForm(string method, string pass, string ip, string port, string fileName)
        {
            InitializeComponent();
            highDivider.Hide();
            highPanel.Hide();
            Height = Height - 220;
            if (fileName != null)
            {
                Text = Text + " : 编辑 - " + fileName;
                string jsonFileStr = File.ReadAllText(string.Format("{0}/config/{1}.json", Application.StartupPath, fileName));
                serverInfoFile = JsonConvert.DeserializeObject<ServerInfo>(jsonFileStr);

            }
            else if (method != null)
            {
                Text = Text + " : 新建";
                textBoxIP.Text = ip;
                textBoxPassWord.Text = pass;
                methodBox.Text = method;
                textBoxPort.Text = port;
            }
            else
            {
                Text = Text + " : 新建";
            }
        }

        private void addForm_Load(object sender, EventArgs e)
        {
            //TopMost = true;
            methodBox.SelectedIndex = 2;
            MaximizeBox = false;
            MinimizeBox = false;
        }

        private void moreButton_Click(object sender, EventArgs e)
        {
            if (Height < 400)
            {
                highDivider.Show();
                highPanel.Show();
                Height = Height + 220;
                moreButton.Icon = Properties.Resources.dots_horizontal_less;
            }
            else
            {
                highDivider.Hide();
                highPanel.Hide();
                Height = Height - 220;
                moreButton.Icon = Properties.Resources.dots_horizontal;
            }

        }

        private void inputURLButton_Click(object sender, EventArgs e)
        {
            Close();
            new urlForm(null).Show();
        }

        ServerInfo serverInfo = new ServerInfo();

        private void saveButton_Click(object sender, EventArgs e)
        {
            textBoxName.Text = textBoxName.Text.Trim();
            string[] strCodes = textBoxName.Text.Split(' ');
            if (string.IsNullOrEmpty(textBoxIP.Text) || string.IsNullOrEmpty(textBoxPassWord.Text) || string.IsNullOrEmpty(textBoxLoaclPort.Text) || string.IsNullOrEmpty(textBoxName.Text))
            {
                MessageBox.Show("请确保所有内容以键入", "mCopernicus", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(strCodes.Length > 1)
            {
                MessageBox.Show("配置名称不可包含空格", "mCopernicus", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                serverInfo.server = textBoxIP.Text;
                serverInfo.server_port = Convert.ToInt32(textBoxPort.Text);
                serverInfo.local_address = textBoxLocalIP.Text;
                serverInfo.local_port = Convert.ToInt32(textBoxLoaclPort.Text);
                serverInfo.password = textBoxPassWord.Text;
                serverInfo.timeout = Convert.ToInt32(numericUpDownTimeOut.Value);
                serverInfo.method = methodBox.Text;
                serverInfo.http_proxy = checkBoxHTTPProxy.Checked;
                serverInfo.auth = checkBoxAuth.Checked;
                string linkJson = JsonConvert.SerializeObject(serverInfo);
                File.WriteAllText(string.Format("{0}/config/{1}.json", Application.StartupPath, textBoxName.Text), linkJson);
                MessageBox.Show("保存成功！");
                this.Close();
            }
        }
    }
}
