namespace mCopernicus
{
    partial class addForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addForm));
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxIP = new System.Windows.Forms.TextBox();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPassWord = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.methodBox = new System.Windows.Forms.ComboBox();
            this.basicPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.highDivider = new MaterialSkin.Controls.MaterialDivider();
            this.highPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxLocalIP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxLoaclPort = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDownTimeOut = new System.Windows.Forms.NumericUpDown();
            this.delButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.saveButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.inputURLButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.moreButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialCheckBox1 = new MaterialSkin.Controls.MaterialCheckBox();
            this.checkBoxAuth = new MaterialSkin.Controls.MaterialCheckBox();
            this.checkBoxHTTPProxy = new MaterialSkin.Controls.MaterialCheckBox();
            this.basicPanel.SuspendLayout();
            this.highPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimeOut)).BeginInit();
            this.SuspendLayout();
            // 
            // materialDivider1
            // 
            this.materialDivider1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(-5, 408);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(380, 1);
            this.materialDivider1.TabIndex = 0;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "服务器地址";
            // 
            // textBoxIP
            // 
            this.textBoxIP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxIP.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxIP.Location = new System.Drawing.Point(115, 3);
            this.textBoxIP.Name = "textBoxIP";
            this.textBoxIP.Size = new System.Drawing.Size(225, 27);
            this.textBoxIP.TabIndex = 3;
            // 
            // textBoxPort
            // 
            this.textBoxPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPort.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxPort.Location = new System.Drawing.Point(115, 36);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(225, 27);
            this.textBoxPort.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(3, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "服务器端口";
            // 
            // textBoxPassWord
            // 
            this.textBoxPassWord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPassWord.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxPassWord.Location = new System.Drawing.Point(115, 69);
            this.textBoxPassWord.Name = "textBoxPassWord";
            this.textBoxPassWord.PasswordChar = '●';
            this.textBoxPassWord.Size = new System.Drawing.Size(225, 27);
            this.textBoxPassWord.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(3, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "连接密码";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(3, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "加密方式";
            // 
            // methodBox
            // 
            this.methodBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.methodBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.methodBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.methodBox.FormattingEnabled = true;
            this.methodBox.ItemHeight = 20;
            this.methodBox.Items.AddRange(new object[] {
            "AES-128-CFB",
            "AES-192-CFB",
            "AES-256-CFB",
            "BF-CFB",
            "CAST5-CFB",
            "CHACHA20",
            "CHACHA20-IETF",
            "RC4",
            "RC4-MD5",
            "SALSA20"});
            this.methodBox.Location = new System.Drawing.Point(115, 102);
            this.methodBox.Name = "methodBox";
            this.methodBox.Size = new System.Drawing.Size(225, 28);
            this.methodBox.TabIndex = 9;
            // 
            // basicPanel
            // 
            this.basicPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.basicPanel.ColumnCount = 2;
            this.basicPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.74648F));
            this.basicPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.25352F));
            this.basicPanel.Controls.Add(this.label8, 0, 4);
            this.basicPanel.Controls.Add(this.label1, 0, 0);
            this.basicPanel.Controls.Add(this.methodBox, 1, 3);
            this.basicPanel.Controls.Add(this.textBoxIP, 1, 0);
            this.basicPanel.Controls.Add(this.label4, 0, 3);
            this.basicPanel.Controls.Add(this.label2, 0, 1);
            this.basicPanel.Controls.Add(this.textBoxPassWord, 1, 2);
            this.basicPanel.Controls.Add(this.textBoxPort, 1, 1);
            this.basicPanel.Controls.Add(this.label3, 0, 2);
            this.basicPanel.Controls.Add(this.textBoxName, 1, 4);
            this.basicPanel.Location = new System.Drawing.Point(12, 11);
            this.basicPanel.Name = "basicPanel";
            this.basicPanel.RowCount = 5;
            this.basicPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.basicPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.basicPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.basicPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.basicPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.basicPanel.Size = new System.Drawing.Size(343, 167);
            this.basicPanel.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(3, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "配置名称";
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxName.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxName.Location = new System.Drawing.Point(115, 136);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(225, 27);
            this.textBoxName.TabIndex = 11;
            // 
            // highDivider
            // 
            this.highDivider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.highDivider.Depth = 0;
            this.highDivider.Location = new System.Drawing.Point(-5, 188);
            this.highDivider.MouseState = MaterialSkin.MouseState.HOVER;
            this.highDivider.Name = "highDivider";
            this.highDivider.Size = new System.Drawing.Size(390, 1);
            this.highDivider.TabIndex = 11;
            this.highDivider.Text = "materialDivider2";
            // 
            // highPanel
            // 
            this.highPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.highPanel.ColumnCount = 2;
            this.highPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.86219F));
            this.highPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.13781F));
            this.highPanel.Controls.Add(this.label5, 0, 0);
            this.highPanel.Controls.Add(this.textBoxLocalIP, 1, 0);
            this.highPanel.Controls.Add(this.label6, 0, 1);
            this.highPanel.Controls.Add(this.textBoxLoaclPort, 1, 1);
            this.highPanel.Controls.Add(this.label7, 0, 2);
            this.highPanel.Controls.Add(this.numericUpDownTimeOut, 1, 2);
            this.highPanel.Controls.Add(this.materialCheckBox1, 1, 5);
            this.highPanel.Controls.Add(this.checkBoxAuth, 1, 4);
            this.highPanel.Controls.Add(this.checkBoxHTTPProxy, 1, 3);
            this.highPanel.Location = new System.Drawing.Point(12, 198);
            this.highPanel.Name = "highPanel";
            this.highPanel.RowCount = 6;
            this.highPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.highPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.highPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.highPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.highPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.highPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.highPanel.Size = new System.Drawing.Size(343, 201);
            this.highPanel.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(3, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "本地地址";
            // 
            // textBoxLocalIP
            // 
            this.textBoxLocalIP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLocalIP.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxLocalIP.Location = new System.Drawing.Point(115, 3);
            this.textBoxLocalIP.Name = "textBoxLocalIP";
            this.textBoxLocalIP.Size = new System.Drawing.Size(225, 27);
            this.textBoxLocalIP.TabIndex = 5;
            this.textBoxLocalIP.Text = "127.0.0.1";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(3, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "本地端口";
            // 
            // textBoxLoaclPort
            // 
            this.textBoxLoaclPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLoaclPort.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxLoaclPort.Location = new System.Drawing.Point(115, 36);
            this.textBoxLoaclPort.Name = "textBoxLoaclPort";
            this.textBoxLoaclPort.Size = new System.Drawing.Size(225, 27);
            this.textBoxLoaclPort.TabIndex = 7;
            this.textBoxLoaclPort.Text = "1080";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(3, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "超时";
            // 
            // numericUpDownTimeOut
            // 
            this.numericUpDownTimeOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownTimeOut.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.numericUpDownTimeOut.Location = new System.Drawing.Point(115, 69);
            this.numericUpDownTimeOut.Maximum = new decimal(new int[] {
            9000,
            0,
            0,
            0});
            this.numericUpDownTimeOut.Name = "numericUpDownTimeOut";
            this.numericUpDownTimeOut.Size = new System.Drawing.Size(225, 27);
            this.numericUpDownTimeOut.TabIndex = 9;
            this.numericUpDownTimeOut.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // delButton
            // 
            this.delButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.delButton.AutoSize = true;
            this.delButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.delButton.Depth = 0;
            this.delButton.Icon = global::mCopernicus.Properties.Resources.delete;
            this.delButton.Location = new System.Drawing.Point(64, 418);
            this.delButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.delButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.delButton.Name = "delButton";
            this.delButton.Primary = false;
            this.delButton.Size = new System.Drawing.Size(44, 36);
            this.delButton.TabIndex = 16;
            this.delButton.UseVisualStyleBackColor = true;
            this.delButton.Visible = false;
            this.delButton.Click += new System.EventHandler(this.delButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.AutoSize = true;
            this.saveButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveButton.Depth = 0;
            this.saveButton.Icon = null;
            this.saveButton.Location = new System.Drawing.Point(299, 418);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.saveButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.saveButton.Name = "saveButton";
            this.saveButton.Primary = false;
            this.saveButton.Size = new System.Drawing.Size(56, 36);
            this.saveButton.TabIndex = 13;
            this.saveButton.Text = "保存";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // inputURLButton
            // 
            this.inputURLButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.inputURLButton.AutoSize = true;
            this.inputURLButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.inputURLButton.Depth = 0;
            this.inputURLButton.Icon = global::mCopernicus.Properties.Resources.link;
            this.inputURLButton.Location = new System.Drawing.Point(64, 418);
            this.inputURLButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.inputURLButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.inputURLButton.Name = "inputURLButton";
            this.inputURLButton.Primary = false;
            this.inputURLButton.Size = new System.Drawing.Size(44, 36);
            this.inputURLButton.TabIndex = 15;
            this.inputURLButton.UseVisualStyleBackColor = true;
            this.inputURLButton.Click += new System.EventHandler(this.inputURLButton_Click);
            // 
            // moreButton
            // 
            this.moreButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.moreButton.AutoSize = true;
            this.moreButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.moreButton.Depth = 0;
            this.moreButton.Icon = ((System.Drawing.Image)(resources.GetObject("moreButton.Icon")));
            this.moreButton.Location = new System.Drawing.Point(12, 418);
            this.moreButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.moreButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.moreButton.Name = "moreButton";
            this.moreButton.Primary = false;
            this.moreButton.Size = new System.Drawing.Size(44, 36);
            this.moreButton.TabIndex = 14;
            this.moreButton.UseVisualStyleBackColor = true;
            this.moreButton.Click += new System.EventHandler(this.moreButton_Click);
            // 
            // materialCheckBox1
            // 
            this.materialCheckBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCheckBox1.AutoSize = true;
            this.materialCheckBox1.Depth = 0;
            this.materialCheckBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.materialCheckBox1.Location = new System.Drawing.Point(112, 168);
            this.materialCheckBox1.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckBox1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckBox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckBox1.Name = "materialCheckBox1";
            this.materialCheckBox1.Ripple = true;
            this.materialCheckBox1.Size = new System.Drawing.Size(231, 30);
            this.materialCheckBox1.TabIndex = 17;
            this.materialCheckBox1.Text = "设为默认下一次自动连接";
            this.materialCheckBox1.UseVisualStyleBackColor = true;
            // 
            // checkBoxAuth
            // 
            this.checkBoxAuth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxAuth.AutoSize = true;
            this.checkBoxAuth.Depth = 0;
            this.checkBoxAuth.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.checkBoxAuth.Location = new System.Drawing.Point(112, 133);
            this.checkBoxAuth.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxAuth.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkBoxAuth.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkBoxAuth.Name = "checkBoxAuth";
            this.checkBoxAuth.Ripple = true;
            this.checkBoxAuth.Size = new System.Drawing.Size(231, 30);
            this.checkBoxAuth.TabIndex = 18;
            this.checkBoxAuth.Text = "一次验证（已不建议）";
            this.checkBoxAuth.UseVisualStyleBackColor = true;
            // 
            // checkBoxHTTPProxy
            // 
            this.checkBoxHTTPProxy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxHTTPProxy.AutoSize = true;
            this.checkBoxHTTPProxy.Checked = true;
            this.checkBoxHTTPProxy.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxHTTPProxy.Depth = 0;
            this.checkBoxHTTPProxy.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.checkBoxHTTPProxy.Location = new System.Drawing.Point(112, 100);
            this.checkBoxHTTPProxy.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxHTTPProxy.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkBoxHTTPProxy.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkBoxHTTPProxy.Name = "checkBoxHTTPProxy";
            this.checkBoxHTTPProxy.Ripple = true;
            this.checkBoxHTTPProxy.Size = new System.Drawing.Size(231, 30);
            this.checkBoxHTTPProxy.TabIndex = 19;
            this.checkBoxHTTPProxy.Text = "HTTP(S)代理模式";
            this.checkBoxHTTPProxy.UseVisualStyleBackColor = true;
            // 
            // addForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 463);
            this.Controls.Add(this.inputURLButton);
            this.Controls.Add(this.moreButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.highPanel);
            this.Controls.Add(this.highDivider);
            this.Controls.Add(this.basicPanel);
            this.Controls.Add(this.delButton);
            this.Controls.Add(this.materialDivider1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "addForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "编辑连接";
            this.Load += new System.EventHandler(this.addForm_Load);
            this.basicPanel.ResumeLayout(false);
            this.basicPanel.PerformLayout();
            this.highPanel.ResumeLayout(false);
            this.highPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimeOut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel basicPanel;
        private MaterialSkin.Controls.MaterialDivider highDivider;
        private System.Windows.Forms.TableLayoutPanel highPanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxLocalIP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxLoaclPort;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDownTimeOut;
        private MaterialSkin.Controls.MaterialFlatButton saveButton;
        private MaterialSkin.Controls.MaterialFlatButton moreButton;
        private MaterialSkin.Controls.MaterialFlatButton inputURLButton;
        public System.Windows.Forms.TextBox textBoxIP;
        public System.Windows.Forms.TextBox textBoxPort;
        public System.Windows.Forms.TextBox textBoxPassWord;
        public System.Windows.Forms.ComboBox methodBox;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox textBoxName;
        private MaterialSkin.Controls.MaterialFlatButton delButton;
        private MaterialSkin.Controls.MaterialCheckBox materialCheckBox1;
        private MaterialSkin.Controls.MaterialCheckBox checkBoxAuth;
        private MaterialSkin.Controls.MaterialCheckBox checkBoxHTTPProxy;
    }
}