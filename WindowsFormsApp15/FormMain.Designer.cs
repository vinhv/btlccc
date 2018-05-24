namespace WindowsFormsApp15
{
    partial class FormMain
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.doDucVinhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taiKhoanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thongTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.troGiupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnThongKe = new System.Windows.Forms.Panel();
            this.btnThongKeHs = new System.Windows.Forms.Button();
            this.btnThongKEGiaoVien = new System.Windows.Forms.Button();
            this.pnXuong = new System.Windows.Forms.Panel();
            this.btnThonglkeXuong = new System.Windows.Forms.Button();
            this.btnPhanCongGiangDay = new System.Windows.Forms.Button();
            this.btnThongkeLen = new System.Windows.Forms.Button();
            this.btnQuanLyDiem = new System.Windows.Forms.Button();
            this.btnThongKeBaoCao = new System.Windows.Forms.Button();
            this.pnDanhMuc = new System.Windows.Forms.Panel();
            this.btnQuanLyGiaoVien = new System.Windows.Forms.Button();
            this.btnQuanLyMonHoc = new System.Windows.Forms.Button();
            this.btnQuanLyLopHoc = new System.Windows.Forms.Button();
            this.btnQuanLyHocSinh = new System.Windows.Forms.Button();
            this.btnXuong = new System.Windows.Forms.Button();
            this.btnLen = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnQuanLyDanhMuc = new System.Windows.Forms.Button();
            this.BaoForm = new System.Windows.Forms.Panel();
            this.TabGG = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnThongKe.SuspendLayout();
            this.pnXuong.SuspendLayout();
            this.pnDanhMuc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.BaoForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(939, 57);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(828, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(111, 57);
            this.panel2.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doDucVinhToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(111, 57);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // doDucVinhToolStripMenuItem
            // 
            this.doDucVinhToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.taiKhoanToolStripMenuItem,
            this.thongTinToolStripMenuItem,
            this.troGiupToolStripMenuItem});
            this.doDucVinhToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doDucVinhToolStripMenuItem.Image = global::WindowsFormsApp15.Properties.Resources.user_54;
            this.doDucVinhToolStripMenuItem.Name = "doDucVinhToolStripMenuItem";
            this.doDucVinhToolStripMenuItem.Size = new System.Drawing.Size(104, 53);
            this.doDucVinhToolStripMenuItem.Text = "Do Duc Vinh";
            this.doDucVinhToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // taiKhoanToolStripMenuItem
            // 
            this.taiKhoanToolStripMenuItem.Name = "taiKhoanToolStripMenuItem";
            this.taiKhoanToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.taiKhoanToolStripMenuItem.Text = "Tai Khoan";
            // 
            // thongTinToolStripMenuItem
            // 
            this.thongTinToolStripMenuItem.Name = "thongTinToolStripMenuItem";
            this.thongTinToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.thongTinToolStripMenuItem.Text = "Thong tin";
            // 
            // troGiupToolStripMenuItem
            // 
            this.troGiupToolStripMenuItem.Name = "troGiupToolStripMenuItem";
            this.troGiupToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.troGiupToolStripMenuItem.Text = "Tro Giup";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Image = global::WindowsFormsApp15.Properties.Resources.Apps_preferences_contact_list_icon;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 57);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hệ Thống Quản lý Hoc Sinh";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.groupBox1.Controls.Add(this.pnThongKe);
            this.groupBox1.Controls.Add(this.pnXuong);
            this.groupBox1.Controls.Add(this.pnDanhMuc);
            this.groupBox1.Controls.Add(this.btnXuong);
            this.groupBox1.Controls.Add(this.btnLen);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btnQuanLyDanhMuc);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Gray;
            this.groupBox1.Location = new System.Drawing.Point(0, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 379);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // pnThongKe
            // 
            this.pnThongKe.Controls.Add(this.btnThongKeHs);
            this.pnThongKe.Controls.Add(this.btnThongKEGiaoVien);
            this.pnThongKe.Location = new System.Drawing.Point(3, 252);
            this.pnThongKe.Name = "pnThongKe";
            this.pnThongKe.Size = new System.Drawing.Size(256, 90);
            this.pnThongKe.TabIndex = 1;
            this.pnThongKe.Visible = false;
            // 
            // btnThongKeHs
            // 
            this.btnThongKeHs.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThongKeHs.Location = new System.Drawing.Point(0, 45);
            this.btnThongKeHs.Name = "btnThongKeHs";
            this.btnThongKeHs.Size = new System.Drawing.Size(256, 45);
            this.btnThongKeHs.TabIndex = 2;
            this.btnThongKeHs.Text = "Danh Sách Học Sinh";
            this.btnThongKeHs.UseVisualStyleBackColor = true;
            this.btnThongKeHs.Click += new System.EventHandler(this.btnThongKeHs_Click);
            // 
            // btnThongKEGiaoVien
            // 
            this.btnThongKEGiaoVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThongKEGiaoVien.Location = new System.Drawing.Point(0, 0);
            this.btnThongKEGiaoVien.Name = "btnThongKEGiaoVien";
            this.btnThongKEGiaoVien.Size = new System.Drawing.Size(256, 45);
            this.btnThongKEGiaoVien.TabIndex = 2;
            this.btnThongKEGiaoVien.Text = "Danh Sách Giáo Viên";
            this.btnThongKEGiaoVien.UseVisualStyleBackColor = true;
            this.btnThongKEGiaoVien.Click += new System.EventHandler(this.btnThongKEGiaoVien_Click);
            // 
            // pnXuong
            // 
            this.pnXuong.Controls.Add(this.btnThonglkeXuong);
            this.pnXuong.Controls.Add(this.btnPhanCongGiangDay);
            this.pnXuong.Controls.Add(this.btnThongkeLen);
            this.pnXuong.Controls.Add(this.btnQuanLyDiem);
            this.pnXuong.Controls.Add(this.btnThongKeBaoCao);
            this.pnXuong.Location = new System.Drawing.Point(3, 66);
            this.pnXuong.Name = "pnXuong";
            this.pnXuong.Size = new System.Drawing.Size(256, 135);
            this.pnXuong.TabIndex = 2;
            // 
            // btnThonglkeXuong
            // 
            this.btnThonglkeXuong.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThonglkeXuong.Location = new System.Drawing.Point(213, 102);
            this.btnThonglkeXuong.Name = "btnThonglkeXuong";
            this.btnThonglkeXuong.Size = new System.Drawing.Size(36, 20);
            this.btnThonglkeXuong.TabIndex = 2;
            this.btnThonglkeXuong.Text = "<";
            this.btnThonglkeXuong.UseVisualStyleBackColor = true;
            this.btnThonglkeXuong.Visible = false;
            this.btnThonglkeXuong.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnPhanCongGiangDay
            // 
            this.btnPhanCongGiangDay.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnPhanCongGiangDay.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPhanCongGiangDay.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhanCongGiangDay.ForeColor = System.Drawing.Color.Navy;
            this.btnPhanCongGiangDay.Image = global::WindowsFormsApp15.Properties.Resources.Book_icon;
            this.btnPhanCongGiangDay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPhanCongGiangDay.Location = new System.Drawing.Point(0, 0);
            this.btnPhanCongGiangDay.Name = "btnPhanCongGiangDay";
            this.btnPhanCongGiangDay.Size = new System.Drawing.Size(256, 45);
            this.btnPhanCongGiangDay.TabIndex = 0;
            this.btnPhanCongGiangDay.Text = "Phân công giảng dạy";
            this.btnPhanCongGiangDay.UseVisualStyleBackColor = false;
            this.btnPhanCongGiangDay.Click += new System.EventHandler(this.btnPhanCongGiangDay_Click);
            // 
            // btnThongkeLen
            // 
            this.btnThongkeLen.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongkeLen.Location = new System.Drawing.Point(213, 102);
            this.btnThongkeLen.Name = "btnThongkeLen";
            this.btnThongkeLen.Size = new System.Drawing.Size(36, 20);
            this.btnThongkeLen.TabIndex = 2;
            this.btnThongkeLen.Text = ">";
            this.btnThongkeLen.UseVisualStyleBackColor = true;
            this.btnThongkeLen.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnQuanLyDiem
            // 
            this.btnQuanLyDiem.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnQuanLyDiem.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnQuanLyDiem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyDiem.ForeColor = System.Drawing.Color.Navy;
            this.btnQuanLyDiem.Image = global::WindowsFormsApp15.Properties.Resources.Apps_preferences_contact_list_icon;
            this.btnQuanLyDiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyDiem.Location = new System.Drawing.Point(0, 45);
            this.btnQuanLyDiem.Name = "btnQuanLyDiem";
            this.btnQuanLyDiem.Size = new System.Drawing.Size(256, 45);
            this.btnQuanLyDiem.TabIndex = 0;
            this.btnQuanLyDiem.Text = "Quản lý điểm";
            this.btnQuanLyDiem.UseVisualStyleBackColor = false;
            this.btnQuanLyDiem.Click += new System.EventHandler(this.btnQuanLyDiem_Click);
            // 
            // btnThongKeBaoCao
            // 
            this.btnThongKeBaoCao.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnThongKeBaoCao.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnThongKeBaoCao.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKeBaoCao.ForeColor = System.Drawing.Color.Navy;
            this.btnThongKeBaoCao.Image = global::WindowsFormsApp15.Properties.Resources.Food_List_Ingredients_icon;
            this.btnThongKeBaoCao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKeBaoCao.Location = new System.Drawing.Point(0, 90);
            this.btnThongKeBaoCao.Name = "btnThongKeBaoCao";
            this.btnThongKeBaoCao.Size = new System.Drawing.Size(256, 45);
            this.btnThongKeBaoCao.TabIndex = 0;
            this.btnThongKeBaoCao.Text = "Thống kê báo cáo";
            this.btnThongKeBaoCao.UseVisualStyleBackColor = false;
            // 
            // pnDanhMuc
            // 
            this.pnDanhMuc.Controls.Add(this.btnQuanLyGiaoVien);
            this.pnDanhMuc.Controls.Add(this.btnQuanLyMonHoc);
            this.pnDanhMuc.Controls.Add(this.btnQuanLyLopHoc);
            this.pnDanhMuc.Controls.Add(this.btnQuanLyHocSinh);
            this.pnDanhMuc.Location = new System.Drawing.Point(3, 66);
            this.pnDanhMuc.Name = "pnDanhMuc";
            this.pnDanhMuc.Size = new System.Drawing.Size(256, 180);
            this.pnDanhMuc.TabIndex = 0;
            this.pnDanhMuc.Visible = false;
            // 
            // btnQuanLyGiaoVien
            // 
            this.btnQuanLyGiaoVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQuanLyGiaoVien.Location = new System.Drawing.Point(0, 132);
            this.btnQuanLyGiaoVien.Name = "btnQuanLyGiaoVien";
            this.btnQuanLyGiaoVien.Size = new System.Drawing.Size(256, 44);
            this.btnQuanLyGiaoVien.TabIndex = 1;
            this.btnQuanLyGiaoVien.Text = "Quản lý giáo viên";
            this.btnQuanLyGiaoVien.UseVisualStyleBackColor = true;
            this.btnQuanLyGiaoVien.Click += new System.EventHandler(this.btnQuanLyGiaoVien_Click);
            // 
            // btnQuanLyMonHoc
            // 
            this.btnQuanLyMonHoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQuanLyMonHoc.Location = new System.Drawing.Point(0, 88);
            this.btnQuanLyMonHoc.Name = "btnQuanLyMonHoc";
            this.btnQuanLyMonHoc.Size = new System.Drawing.Size(256, 44);
            this.btnQuanLyMonHoc.TabIndex = 0;
            this.btnQuanLyMonHoc.Text = "Quản lý môn học";
            this.btnQuanLyMonHoc.UseVisualStyleBackColor = true;
            this.btnQuanLyMonHoc.Click += new System.EventHandler(this.btnQuanLyMonHoc_Click);
            // 
            // btnQuanLyLopHoc
            // 
            this.btnQuanLyLopHoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQuanLyLopHoc.Location = new System.Drawing.Point(0, 44);
            this.btnQuanLyLopHoc.Name = "btnQuanLyLopHoc";
            this.btnQuanLyLopHoc.Size = new System.Drawing.Size(256, 44);
            this.btnQuanLyLopHoc.TabIndex = 1;
            this.btnQuanLyLopHoc.Text = "Quản lý lớp học";
            this.btnQuanLyLopHoc.UseVisualStyleBackColor = true;
            this.btnQuanLyLopHoc.Click += new System.EventHandler(this.btnQuanLyLopHoc_Click);
            // 
            // btnQuanLyHocSinh
            // 
            this.btnQuanLyHocSinh.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQuanLyHocSinh.Location = new System.Drawing.Point(0, 0);
            this.btnQuanLyHocSinh.Name = "btnQuanLyHocSinh";
            this.btnQuanLyHocSinh.Size = new System.Drawing.Size(256, 44);
            this.btnQuanLyHocSinh.TabIndex = 1;
            this.btnQuanLyHocSinh.Text = "Quản lý học sinh";
            this.btnQuanLyHocSinh.UseVisualStyleBackColor = true;
            this.btnQuanLyHocSinh.Click += new System.EventHandler(this.btnQuanLyHocSinh_Click);
            // 
            // btnXuong
            // 
            this.btnXuong.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuong.Location = new System.Drawing.Point(213, 37);
            this.btnXuong.Name = "btnXuong";
            this.btnXuong.Size = new System.Drawing.Size(39, 17);
            this.btnXuong.TabIndex = 2;
            this.btnXuong.Text = "<";
            this.btnXuong.UseVisualStyleBackColor = true;
            this.btnXuong.Visible = false;
            this.btnXuong.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnLen
            // 
            this.btnLen.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLen.Location = new System.Drawing.Point(213, 37);
            this.btnLen.Name = "btnLen";
            this.btnLen.Size = new System.Drawing.Size(39, 17);
            this.btnLen.TabIndex = 1;
            this.btnLen.Text = ">";
            this.btnLen.UseVisualStyleBackColor = true;
            this.btnLen.Click += new System.EventHandler(this.button6_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Beige;
            this.pictureBox1.Image = global::WindowsFormsApp15.Properties.Resources.c2;
            this.pictureBox1.Location = new System.Drawing.Point(3, 201);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 175);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnQuanLyDanhMuc
            // 
            this.btnQuanLyDanhMuc.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnQuanLyDanhMuc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQuanLyDanhMuc.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyDanhMuc.ForeColor = System.Drawing.Color.Navy;
            this.btnQuanLyDanhMuc.Image = global::WindowsFormsApp15.Properties.Resources.Very_Basic_Menu_icon1;
            this.btnQuanLyDanhMuc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyDanhMuc.Location = new System.Drawing.Point(3, 21);
            this.btnQuanLyDanhMuc.Name = "btnQuanLyDanhMuc";
            this.btnQuanLyDanhMuc.Size = new System.Drawing.Size(256, 45);
            this.btnQuanLyDanhMuc.TabIndex = 0;
            this.btnQuanLyDanhMuc.Text = "Quản lý danh mục";
            this.btnQuanLyDanhMuc.UseVisualStyleBackColor = false;
            // 
            // BaoForm
            // 
            this.BaoForm.BackColor = System.Drawing.Color.White;
            this.BaoForm.Controls.Add(this.TabGG);
            this.BaoForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BaoForm.Location = new System.Drawing.Point(262, 57);
            this.BaoForm.Name = "BaoForm";
            this.BaoForm.Size = new System.Drawing.Size(677, 379);
            this.BaoForm.TabIndex = 3;
            // 
            // TabGG
            // 
            this.TabGG.BackColor = System.Drawing.Color.White;
            this.TabGG.Dock = System.Windows.Forms.DockStyle.Top;
            this.TabGG.Location = new System.Drawing.Point(0, 0);
            this.TabGG.Name = "TabGG";
            this.TabGG.Size = new System.Drawing.Size(677, 10);
            this.TabGG.TabIndex = 0;
            this.TabGG.Paint += new System.Windows.Forms.PaintEventHandler(this.TabGG_Paint);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 436);
            this.Controls.Add(this.BaoForm);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.pnThongKe.ResumeLayout(false);
            this.pnXuong.ResumeLayout(false);
            this.pnDanhMuc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.BaoForm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem doDucVinhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taiKhoanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thongTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem troGiupToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel BaoForm;
        private System.Windows.Forms.Button btnThongKeBaoCao;
        private System.Windows.Forms.Button btnQuanLyDiem;
        private System.Windows.Forms.Button btnPhanCongGiangDay;
        private System.Windows.Forms.Button btnQuanLyDanhMuc;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLen;
        private System.Windows.Forms.Button btnQuanLyMonHoc;
        private System.Windows.Forms.Button btnXuong;
        private System.Windows.Forms.Button btnQuanLyGiaoVien;
        private System.Windows.Forms.Button btnQuanLyHocSinh;
        private System.Windows.Forms.Button btnQuanLyLopHoc;
        private System.Windows.Forms.Panel pnDanhMuc;
        private System.Windows.Forms.Panel pnThongKe;
        private System.Windows.Forms.Button btnThongKeHs;
        private System.Windows.Forms.Button btnThongKEGiaoVien;
        private System.Windows.Forms.Panel pnXuong;
        private System.Windows.Forms.Button btnThonglkeXuong;
        private System.Windows.Forms.Button btnThongkeLen;
        private System.Windows.Forms.Panel TabGG;
    }
}

