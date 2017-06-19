namespace mCopernicus
{
    partial class mainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.mlListView = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timerRefresh = new System.Windows.Forms.Timer(this.components);
            this.setButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.editButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.addButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.startButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.timerCheckSelect = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // materialDivider1
            // 
            this.materialDivider1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(1, 540);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(400, 1);
            this.materialDivider1.TabIndex = 0;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // mlListView
            // 
            this.mlListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mlListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mlListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader});
            this.mlListView.Depth = 0;
            this.mlListView.Font = new System.Drawing.Font("Microsoft YaHei UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(134)));
            this.mlListView.FullRowSelect = true;
            this.mlListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.mlListView.Location = new System.Drawing.Point(1, 65);
            this.mlListView.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mlListView.MouseState = MaterialSkin.MouseState.OUT;
            this.mlListView.Name = "mlListView";
            this.mlListView.OwnerDraw = true;
            this.mlListView.Size = new System.Drawing.Size(398, 470);
            this.mlListView.TabIndex = 3;
            this.mlListView.UseCompatibleStateImageBehavior = false;
            this.mlListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader
            // 
            this.columnHeader.Text = "连接列表";
            this.columnHeader.Width = 396;
            // 
            // timerRefresh
            // 
            this.timerRefresh.Enabled = true;
            this.timerRefresh.Interval = 30000;
            this.timerRefresh.Tick += new System.EventHandler(this.timerRefresh_Tick);
            // 
            // setButton
            // 
            this.setButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.setButton.AutoSize = true;
            this.setButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.setButton.Depth = 0;
            this.setButton.Icon = global::mCopernicus.Properties.Resources.settings;
            this.setButton.Location = new System.Drawing.Point(117, 550);
            this.setButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.setButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.setButton.Name = "setButton";
            this.setButton.Primary = false;
            this.setButton.Size = new System.Drawing.Size(44, 36);
            this.setButton.TabIndex = 5;
            this.setButton.UseVisualStyleBackColor = true;
            // 
            // editButton
            // 
            this.editButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.editButton.AutoSize = true;
            this.editButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.editButton.Depth = 0;
            this.editButton.Enabled = false;
            this.editButton.Icon = global::mCopernicus.Properties.Resources.pencil;
            this.editButton.Location = new System.Drawing.Point(65, 550);
            this.editButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.editButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.editButton.Name = "editButton";
            this.editButton.Primary = false;
            this.editButton.Size = new System.Drawing.Size(44, 36);
            this.editButton.TabIndex = 4;
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addButton.AutoSize = true;
            this.addButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addButton.Depth = 0;
            this.addButton.Icon = global::mCopernicus.Properties.Resources.file_plus;
            this.addButton.Location = new System.Drawing.Point(13, 550);
            this.addButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.addButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.addButton.Name = "addButton";
            this.addButton.Primary = false;
            this.addButton.Size = new System.Drawing.Size(44, 36);
            this.addButton.TabIndex = 2;
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // startButton
            // 
            this.startButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.startButton.AutoSize = true;
            this.startButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.startButton.Depth = 0;
            this.startButton.Icon = global::mCopernicus.Properties.Resources.send;
            this.startButton.Location = new System.Drawing.Point(303, 550);
            this.startButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.startButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.startButton.Name = "startButton";
            this.startButton.Primary = false;
            this.startButton.Size = new System.Drawing.Size(84, 36);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "启动";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // timerCheckSelect
            // 
            this.timerCheckSelect.Enabled = true;
            this.timerCheckSelect.Interval = 1000;
            this.timerCheckSelect.Tick += new System.EventHandler(this.timerCheckSelect_Tick);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 600);
            this.Controls.Add(this.setButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.mlListView);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.materialDivider1);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mCopernicus";
            this.Activated += new System.EventHandler(this.mainForm_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.mianForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialFlatButton startButton;
        private MaterialSkin.Controls.MaterialFlatButton addButton;
        private MaterialSkin.Controls.MaterialListView mlListView;
        private System.Windows.Forms.ColumnHeader columnHeader;
        private System.Windows.Forms.Timer timerRefresh;
        private MaterialSkin.Controls.MaterialFlatButton editButton;
        private MaterialSkin.Controls.MaterialFlatButton setButton;
        private System.Windows.Forms.Timer timerCheckSelect;
    }
}

