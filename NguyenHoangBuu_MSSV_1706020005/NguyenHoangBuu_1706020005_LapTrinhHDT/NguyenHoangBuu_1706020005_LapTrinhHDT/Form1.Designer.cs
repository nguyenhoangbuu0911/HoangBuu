namespace NguyenHoangBuu_1706020005_LapTrinhHDT
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbDuongThang = new System.Windows.Forms.ToolStripButton();
            this.tsbTamGiac = new System.Windows.Forms.ToolStripButton();
            this.tsbHinhThoi = new System.Windows.Forms.ToolStripButton();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbLoad = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbDuongThang,
            this.tsbTamGiac,
            this.tsbHinhThoi,
            this.tsbSave,
            this.tsbLoad});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(572, 38);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbDuongThang
            // 
            this.tsbDuongThang.CheckOnClick = true;
            this.tsbDuongThang.Image = ((System.Drawing.Image)(resources.GetObject("tsbDuongThang.Image")));
            this.tsbDuongThang.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDuongThang.Name = "tsbDuongThang";
            this.tsbDuongThang.Size = new System.Drawing.Size(84, 35);
            this.tsbDuongThang.Text = "Đường Thẳng";
            this.tsbDuongThang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbDuongThang.Click += new System.EventHandler(this.tsbDuongThang_Click_1);
            // 
            // tsbTamGiac
            // 
            this.tsbTamGiac.CheckOnClick = true;
            this.tsbTamGiac.Image = global::NguyenHoangBuu_1706020005_LapTrinhHDT.Properties.Resources.TamgiacHCN;
            this.tsbTamGiac.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbTamGiac.Name = "tsbTamGiac";
            this.tsbTamGiac.Size = new System.Drawing.Size(60, 35);
            this.tsbTamGiac.Text = "Tam Giác";
            this.tsbTamGiac.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbTamGiac.ToolTipText = "Tam Giác";
            this.tsbTamGiac.Click += new System.EventHandler(this.tsbTamGiac_Click_1);
            // 
            // tsbHinhThoi
            // 
            this.tsbHinhThoi.CheckOnClick = true;
            this.tsbHinhThoi.Image = global::NguyenHoangBuu_1706020005_LapTrinhHDT.Properties.Resources.HinhthoiHCN;
            this.tsbHinhThoi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbHinhThoi.Name = "tsbHinhThoi";
            this.tsbHinhThoi.Size = new System.Drawing.Size(64, 35);
            this.tsbHinhThoi.Text = "Hình Thoi";
            this.tsbHinhThoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsbSave
            // 
            this.tsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbSave.Image")));
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(35, 35);
            this.tsbSave.Text = "Save";
            this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click);
            // 
            // tsbLoad
            // 
            this.tsbLoad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbLoad.Image = ((System.Drawing.Image)(resources.GetObject("tsbLoad.Image")));
            this.tsbLoad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLoad.Name = "tsbLoad";
            this.tsbLoad.Size = new System.Drawing.Size(37, 35);
            this.tsbLoad.Text = "Load";
            this.tsbLoad.Click += new System.EventHandler(this.tsbLoad_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(572, 300);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 338);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbDuongThang;
        private System.Windows.Forms.ToolStripButton tsbTamGiac;
        private System.Windows.Forms.ToolStripButton tsbHinhThoi;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton tsbLoad;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

