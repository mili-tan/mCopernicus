using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Copernicus.SSURL;
using System.Threading;

namespace mCopernicus
{
    public partial class urlForm : Form
    {
        Color originColor;

        public urlForm(string linkString)
        {
            InitializeComponent();
            if (!string.IsNullOrEmpty(linkString))
            {
                urlTextBox.Text = linkString;
            }
        }

        public urlForm()
        {
            InitializeComponent();
        }

        private void urlForm_Load(object sender, EventArgs e)
        {
            TopMost = true;
            MaximizeBox = false;
            MinimizeBox = false;
            originColor = BackColor;
        }

        private void urlButton_Click(object sender, EventArgs e)
        {
            string[] linkInfo = null;
            addForm addForm = null;
            try
            {
                if (urlTextBox.Text.Contains("#"))
                {
                    string[] nameInfo = urlTextBox.Text.Split('#');
                    linkInfo = SSURL.Parse(nameInfo[0].Replace("ss://", "").Replace("/", ""));
                    addForm = new addForm(linkInfo[0], linkInfo[1], linkInfo[2], linkInfo[3], nameInfo[1]);
                }
                else
                {
                    linkInfo = SSURL.Parse(urlTextBox.Text.Replace("ss://", "").Replace("/", ""));
                    addForm = new addForm(linkInfo[0], linkInfo[1], linkInfo[2], linkInfo[3], null);
                }
                Hide();
                addForm.ShowDialog();
                Close();
            }
            catch (Exception)
            {
                Text = "从SS URL导入 : 无效";
                BackColor = Color.LightPink;
            }
        }

        private void urlTextBox_MouseDown(object sender, MouseEventArgs e)
        {
            Text = "从SS URL导入";
        }
    }
}
