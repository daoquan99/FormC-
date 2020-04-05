namespace S4_N11_QuanLyKhoSua_4
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
            this.Label1 = new System.Windows.Forms.Label();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnPhieuXuat = new System.Windows.Forms.Button();
            this.BtnPhieuNhap = new System.Windows.Forms.Button();
            this.BtnSP = new System.Windows.Forms.Button();
            this.BtnPhongBan = new System.Windows.Forms.Button();
            this.BtnNhanVien = new System.Windows.Forms.Button();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).BeginInit();
            this.SplitContainer1.Panel1.SuspendLayout();
            this.SplitContainer1.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Red;
            this.Label1.Location = new System.Drawing.Point(0, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(832, 86);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Quản Lý Kho Sửa";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Panel2
            // 
            this.Panel2.Controls.Add(this.SplitContainer1);
            this.Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel2.Location = new System.Drawing.Point(0, 86);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(832, 452);
            this.Panel2.TabIndex = 3;
            // 
            // SplitContainer1
            // 
            this.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainer1.Location = new System.Drawing.Point(0, 0);
            this.SplitContainer1.Name = "SplitContainer1";
            // 
            // SplitContainer1.Panel1
            // 
            this.SplitContainer1.Panel1.Controls.Add(this.GroupBox1);
            this.SplitContainer1.Size = new System.Drawing.Size(832, 452);
            this.SplitContainer1.SplitterDistance = 328;
            this.SplitContainer1.TabIndex = 0;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.BtnPhieuXuat);
            this.GroupBox1.Controls.Add(this.BtnPhieuNhap);
            this.GroupBox1.Controls.Add(this.BtnSP);
            this.GroupBox1.Controls.Add(this.BtnPhongBan);
            this.GroupBox1.Controls.Add(this.BtnNhanVien);
            this.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupBox1.Location = new System.Drawing.Point(0, 0);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(324, 448);
            this.GroupBox1.TabIndex = 0;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Danh Mục";
            // 
            // BtnPhieuXuat
            // 
            this.BtnPhieuXuat.Location = new System.Drawing.Point(62, 377);
            this.BtnPhieuXuat.Name = "BtnPhieuXuat";
            this.BtnPhieuXuat.Size = new System.Drawing.Size(195, 43);
            this.BtnPhieuXuat.TabIndex = 9;
            this.BtnPhieuXuat.Text = "Phiếu Xuất";
            this.BtnPhieuXuat.UseVisualStyleBackColor = true;
            // 
            // BtnPhieuNhap
            // 
            this.BtnPhieuNhap.Location = new System.Drawing.Point(62, 295);
            this.BtnPhieuNhap.Name = "BtnPhieuNhap";
            this.BtnPhieuNhap.Size = new System.Drawing.Size(195, 43);
            this.BtnPhieuNhap.TabIndex = 8;
            this.BtnPhieuNhap.Text = "Phiếu Nhập";
            this.BtnPhieuNhap.UseVisualStyleBackColor = true;
            // 
            // BtnSP
            // 
            this.BtnSP.Location = new System.Drawing.Point(62, 220);
            this.BtnSP.Name = "BtnSP";
            this.BtnSP.Size = new System.Drawing.Size(195, 43);
            this.BtnSP.TabIndex = 7;
            this.BtnSP.Text = "Sản Phẩm";
            this.BtnSP.UseVisualStyleBackColor = true;
            // 
            // BtnPhongBan
            // 
            this.BtnPhongBan.Location = new System.Drawing.Point(62, 137);
            this.BtnPhongBan.Name = "BtnPhongBan";
            this.BtnPhongBan.Size = new System.Drawing.Size(195, 43);
            this.BtnPhongBan.TabIndex = 6;
            this.BtnPhongBan.Text = "Phong Ban";
            this.BtnPhongBan.UseVisualStyleBackColor = true;
            // 
            // BtnNhanVien
            // 
            this.BtnNhanVien.Location = new System.Drawing.Point(62, 57);
            this.BtnNhanVien.Name = "BtnNhanVien";
            this.BtnNhanVien.Size = new System.Drawing.Size(195, 43);
            this.BtnNhanVien.TabIndex = 5;
            this.BtnNhanVien.Text = "Nhân Viên";
            this.BtnNhanVien.UseVisualStyleBackColor = true;
            this.BtnNhanVien.Click += new System.EventHandler(this.BtnNhanVien_Click);
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(832, 86);
            this.Panel1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 538);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form giới thiệu";
            this.Panel2.ResumeLayout(false);
            this.SplitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).EndInit();
            this.SplitContainer1.ResumeLayout(false);
            this.GroupBox1.ResumeLayout(false);
            this.Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Panel Panel2;
        internal System.Windows.Forms.SplitContainer SplitContainer1;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Button BtnPhieuXuat;
        internal System.Windows.Forms.Button BtnPhieuNhap;
        internal System.Windows.Forms.Button BtnSP;
        internal System.Windows.Forms.Button BtnPhongBan;
        internal System.Windows.Forms.Button BtnNhanVien;
        internal System.Windows.Forms.Panel Panel1;
    }
}

