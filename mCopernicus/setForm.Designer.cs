namespace mCopernicus
{
    partial class setForm
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
            this.debugLogCheckBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialCheckBox2 = new MaterialSkin.Controls.MaterialCheckBox();
            this.SuspendLayout();
            // 
            // debugLogCheckBox
            // 
            this.debugLogCheckBox.AutoSize = true;
            this.debugLogCheckBox.Depth = 0;
            this.debugLogCheckBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.debugLogCheckBox.Location = new System.Drawing.Point(9, 9);
            this.debugLogCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.debugLogCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.debugLogCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.debugLogCheckBox.Name = "debugLogCheckBox";
            this.debugLogCheckBox.Ripple = true;
            this.debugLogCheckBox.Size = new System.Drawing.Size(134, 30);
            this.debugLogCheckBox.TabIndex = 0;
            this.debugLogCheckBox.Text = "调试级别日志";
            this.debugLogCheckBox.UseVisualStyleBackColor = true;
            // 
            // materialCheckBox2
            // 
            this.materialCheckBox2.AutoSize = true;
            this.materialCheckBox2.Depth = 0;
            this.materialCheckBox2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.materialCheckBox2.Location = new System.Drawing.Point(9, 39);
            this.materialCheckBox2.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckBox2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckBox2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckBox2.Name = "materialCheckBox2";
            this.materialCheckBox2.Ripple = true;
            this.materialCheckBox2.Size = new System.Drawing.Size(446, 30);
            this.materialCheckBox2.TabIndex = 1;
            this.materialCheckBox2.Text = "全局系统代理（仅HTTP模式代理可用 默认端口1080）";
            this.materialCheckBox2.UseVisualStyleBackColor = true;
            // 
            // setForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 353);
            this.Controls.Add(this.materialCheckBox2);
            this.Controls.Add(this.debugLogCheckBox);
            this.Name = "setForm";
            this.Text = "配置";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialCheckBox debugLogCheckBox;
        private MaterialSkin.Controls.MaterialCheckBox materialCheckBox2;
    }
}