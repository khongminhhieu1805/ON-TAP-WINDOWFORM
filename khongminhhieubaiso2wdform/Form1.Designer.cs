namespace bt_02
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtMaPhieu = new TextBox();
            txtNguoiYeuCau = new TextBox();
            gbUuTien = new GroupBox();
            rdoKhanCap = new RadioButton();
            rdoTrungBinh = new RadioButton();
            rdoThap = new RadioButton();
            label4 = new Label();
            cboLoaiSuCo = new ComboBox();
            gbThietBi = new GroupBox();
            chkDienThoai = new CheckBox();
            chkMayIn = new CheckBox();
            chkLaptop = new CheckBox();
            chkPC = new CheckBox();
            picAnhLoi = new PictureBox();
            btnTaiAnh = new Button();
            btnGui = new Button();
            btnNhaplai = new Button();
            dtpNgayGhiNhan = new DateTimePicker();
            gbUuTien.SuspendLayout();
            gbThietBi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAnhLoi).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 11);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "Mã Phiếu:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 64);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 1;
            label2.Text = "Người yêu cầu:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 117);
            label3.Name = "label3";
            label3.Size = new Size(85, 15);
            label3.TabIndex = 2;
            label3.Text = "Ngày ghi nhận";
            label3.Click += label3_Click;
            // 
            // txtMaPhieu
            // 
            txtMaPhieu.Location = new Point(126, 7);
            txtMaPhieu.Name = "txtMaPhieu";
            txtMaPhieu.Size = new Size(100, 23);
            txtMaPhieu.TabIndex = 3;
            // 
            // txtNguoiYeuCau
            // 
            txtNguoiYeuCau.Location = new Point(126, 60);
            txtNguoiYeuCau.Name = "txtNguoiYeuCau";
            txtNguoiYeuCau.Size = new Size(100, 23);
            txtNguoiYeuCau.TabIndex = 4;
            // 
            // gbUuTien
            // 
            gbUuTien.Controls.Add(rdoKhanCap);
            gbUuTien.Controls.Add(rdoTrungBinh);
            gbUuTien.Controls.Add(rdoThap);
            gbUuTien.Location = new Point(32, 180);
            gbUuTien.Name = "gbUuTien";
            gbUuTien.Size = new Size(325, 47);
            gbUuTien.TabIndex = 6;
            gbUuTien.TabStop = false;
            gbUuTien.Text = "Mức độ ưu tiên:";
            // 
            // rdoKhanCap
            // 
            rdoKhanCap.AutoSize = true;
            rdoKhanCap.Location = new Point(231, 25);
            rdoKhanCap.Name = "rdoKhanCap";
            rdoKhanCap.Size = new Size(74, 19);
            rdoKhanCap.TabIndex = 2;
            rdoKhanCap.TabStop = true;
            rdoKhanCap.Text = "Khẩn cấp";
            rdoKhanCap.UseVisualStyleBackColor = true;
            // 
            // rdoTrungBinh
            // 
            rdoTrungBinh.AutoSize = true;
            rdoTrungBinh.Location = new Point(129, 25);
            rdoTrungBinh.Name = "rdoTrungBinh";
            rdoTrungBinh.Size = new Size(82, 19);
            rdoTrungBinh.TabIndex = 1;
            rdoTrungBinh.Text = "Trung Bình";
            rdoTrungBinh.UseVisualStyleBackColor = true;
            rdoTrungBinh.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // rdoThap
            // 
            rdoThap.AutoSize = true;
            rdoThap.Checked = true;
            rdoThap.Location = new Point(30, 25);
            rdoThap.Name = "rdoThap";
            rdoThap.Size = new Size(51, 19);
            rdoThap.TabIndex = 0;
            rdoThap.TabStop = true;
            rdoThap.Text = "Thấp";
            rdoThap.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 264);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 7;
            label4.Text = "Loại sự cố:";
            label4.Click += label4_Click;
            // 
            // cboLoaiSuCo
            // 
            cboLoaiSuCo.FormattingEnabled = true;
            cboLoaiSuCo.Items.AddRange(new object[] { "Phần cứng", "Phần mềm", "Mạng", "Tài khoản" });
            cboLoaiSuCo.Location = new Point(173, 256);
            cboLoaiSuCo.Name = "cboLoaiSuCo";
            cboLoaiSuCo.Size = new Size(121, 23);
            cboLoaiSuCo.TabIndex = 8;
            // 
            // gbThietBi
            // 
            gbThietBi.Controls.Add(chkDienThoai);
            gbThietBi.Controls.Add(chkMayIn);
            gbThietBi.Controls.Add(chkLaptop);
            gbThietBi.Controls.Add(chkPC);
            gbThietBi.Location = new Point(48, 312);
            gbThietBi.Name = "gbThietBi";
            gbThietBi.Size = new Size(593, 58);
            gbThietBi.TabIndex = 9;
            gbThietBi.TabStop = false;
            gbThietBi.Text = "Thiết bị ảnh hưởng:";
            // 
            // chkDienThoai
            // 
            chkDienThoai.AutoSize = true;
            chkDienThoai.Location = new Point(446, 27);
            chkDienThoai.Name = "chkDienThoai";
            chkDienThoai.Size = new Size(80, 19);
            chkDienThoai.TabIndex = 3;
            chkDienThoai.Text = "Điện thoại";
            chkDienThoai.UseVisualStyleBackColor = true;
            // 
            // chkMayIn
            // 
            chkMayIn.AutoSize = true;
            chkMayIn.Location = new Point(314, 27);
            chkMayIn.Name = "chkMayIn";
            chkMayIn.Size = new Size(62, 19);
            chkMayIn.TabIndex = 2;
            chkMayIn.Text = "Máy in";
            chkMayIn.UseVisualStyleBackColor = true;
            chkMayIn.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // chkLaptop
            // 
            chkLaptop.AutoSize = true;
            chkLaptop.Location = new Point(176, 27);
            chkLaptop.Name = "chkLaptop";
            chkLaptop.Size = new Size(63, 19);
            chkLaptop.TabIndex = 1;
            chkLaptop.Text = "Laptop";
            chkLaptop.UseVisualStyleBackColor = true;
            // 
            // chkPC
            // 
            chkPC.AutoSize = true;
            chkPC.Location = new Point(32, 23);
            chkPC.Name = "chkPC";
            chkPC.Size = new Size(73, 19);
            chkPC.TabIndex = 0;
            chkPC.Text = "Máy tính";
            chkPC.UseVisualStyleBackColor = true;
            // 
            // picAnhLoi
            // 
            picAnhLoi.BorderStyle = BorderStyle.FixedSingle;
            picAnhLoi.Location = new Point(80, 376);
            picAnhLoi.Name = "picAnhLoi";
            picAnhLoi.Size = new Size(100, 50);
            picAnhLoi.SizeMode = PictureBoxSizeMode.StretchImage;
            picAnhLoi.TabIndex = 10;
            picAnhLoi.TabStop = false;
            picAnhLoi.Click += pictureBox1_Click;
            // 
            // btnTaiAnh
            // 
            btnTaiAnh.Location = new Point(224, 403);
            btnTaiAnh.Name = "btnTaiAnh";
            btnTaiAnh.Size = new Size(75, 23);
            btnTaiAnh.TabIndex = 11;
            btnTaiAnh.Text = "Tải ảnh lỗi";
            btnTaiAnh.UseVisualStyleBackColor = true;
            btnTaiAnh.Click += button1_Click;
            // 
            // btnGui
            // 
            btnGui.Location = new Point(120, 467);
            btnGui.Name = "btnGui";
            btnGui.Size = new Size(106, 23);
            btnGui.TabIndex = 12;
            btnGui.Text = "Gửi yêu cầu";
            btnGui.UseVisualStyleBackColor = true;
            btnGui.Click += button2_Click;
            // 
            // btnNhaplai
            // 
            btnNhaplai.Location = new Point(332, 467);
            btnNhaplai.Name = "btnNhaplai";
            btnNhaplai.Size = new Size(75, 23);
            btnNhaplai.TabIndex = 13;
            btnNhaplai.Text = "Nhập lại";
            btnNhaplai.UseVisualStyleBackColor = true;
            btnNhaplai.Click += button3_Click;
            // 
            // dtpNgayGhiNhan
            // 
            dtpNgayGhiNhan.CustomFormat = "dd/MM/yyyy";
            dtpNgayGhiNhan.Format = DateTimePickerFormat.Custom;
            dtpNgayGhiNhan.Location = new Point(123, 109);
            dtpNgayGhiNhan.Name = "dtpNgayGhiNhan";
            dtpNgayGhiNhan.Size = new Size(200, 23);
            dtpNgayGhiNhan.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 521);
            Controls.Add(dtpNgayGhiNhan);
            Controls.Add(btnNhaplai);
            Controls.Add(btnGui);
            Controls.Add(btnTaiAnh);
            Controls.Add(picAnhLoi);
            Controls.Add(gbThietBi);
            Controls.Add(cboLoaiSuCo);
            Controls.Add(label4);
            Controls.Add(gbUuTien);
            Controls.Add(txtNguoiYeuCau);
            Controls.Add(txtMaPhieu);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tiếp nhận & phân loại sự cố IT";
            Load += Form1_Load;
            gbUuTien.ResumeLayout(false);
            gbUuTien.PerformLayout();
            gbThietBi.ResumeLayout(false);
            gbThietBi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picAnhLoi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtMaPhieu;
        private TextBox txtNguoiYeuCau;
        private GroupBox gbUuTien;
        private RadioButton rdoTrungBinh;
        private RadioButton rdoThap;
        private Label label4;
        private ComboBox cboLoaiSuCo;
        private GroupBox gbThietBi;
        private CheckBox chkMayIn;
        private CheckBox chkLaptop;
        private CheckBox chkPC;
        private CheckBox chkDienThoai;
        private PictureBox picAnhLoi;
        private Button btnTaiAnh;
        private Button btnGui;
        private Button btnNhaplai;
        private RadioButton rdoKhanCap;
        private DateTimePicker dtpNgayGhiNhan;
    }
}
