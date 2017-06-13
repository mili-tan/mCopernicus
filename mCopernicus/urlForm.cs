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
        Color origin;
        public urlForm()
        {
            InitializeComponent();
        }

        private void urlForm_Load(object sender, EventArgs e)
        {
            TopMost = true;
            MaximizeBox = false;
            MinimizeBox = false;
            origin = BackColor;
        }

        private void urlButton_Click(object sender, EventArgs e)
        {
            try
            {
                string[] linkInfo = SSURL.Parse(urlTextBox.Text);
                addForm addForm = new addForm(linkInfo[0], linkInfo[1], linkInfo[2], linkInfo[3]);
                Hide();
                addForm.ShowDialog();
                Close();
            }
            catch (Exception)
            {
                Text = "无效的SS URL";
                BackColor = Color.LightPink;
            }
        }

        private void urlTextBox_MouseDown(object sender, MouseEventArgs e)
        {
            Text = "从SS URL导入";
            BackColor = origin;
        }
    }
}
