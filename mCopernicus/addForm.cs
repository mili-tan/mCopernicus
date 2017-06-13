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

namespace mCopernicus
{
    public partial class addForm : Form
    {
        class SeverInfo 
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

        public addForm()
        {
            InitializeComponent();
            highDivider.Hide();
            highPanel.Hide();
            Height = Height - 220;
        }

        private void addForm_Load(object sender, EventArgs e)
        {
            methodBox.SelectedIndex = 2;
            MaximizeBox = false;
            MinimizeBox = false;

            //var materialSkinManager = MaterialSkinManager.Instance;
            //materialSkinManager.AddFormToManage(this);
            //materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            //materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey500, Primary.BlueGrey700, Primary.BlueGrey700, Accent.Blue400, TextShade.WHITE);
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

        }
    }
}
