namespace bt_05
{
    partial class FormBanHang
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
            components = new System.ComponentModel.Container();
            splitContainer1 = new SplitContainer();
            stsTrangThai = new StatusStrip();
            lblDongHo = new ToolStripStatusLabel();
            lblTongSL = new ToolStripStatusLabel();
            lblTongTL = new ToolStripStatusLabel();
            lblTongTien = new ToolStripStatusLabel();
            btnThem = new Button();
            txtTrongLuong = new TextBox();
            txtDonGia = new TextBox();
            txtSoLuong = new TextBox();
            txtTenHang = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvDanhSach = new DataGridView();
            Tên = new DataGridViewTextBoxColumn();
            SL = new DataGridViewTextBoxColumn();
            d = new DataGridViewTextBoxColumn();
            t = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            tmrDongHo = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            stsTrangThai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSach).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(stsTrangThai);
            splitContainer1.Panel1.Controls.Add(btnThem);
            splitContainer1.Panel1.Controls.Add(txtTrongLuong);
            splitContainer1.Panel1.Controls.Add(txtDonGia);
            splitContainer1.Panel1.Controls.Add(txtSoLuong);
            splitContainer1.Panel1.Controls.Add(txtTenHang);
            splitContainer1.Panel1.Controls.Add(label4);
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dgvDanhSach);
            splitContainer1.Size = new Size(950, 450);
            splitContainer1.SplitterDistance = 426;
            splitContainer1.TabIndex = 0;
            // 
            // stsTrangThai
            // 
            stsTrangThai.Items.AddRange(new ToolStripItem[] { lblDongHo, lblTongSL, lblTongTL, lblTongTien });
            stsTrangThai.Location = new Point(0, 428);
            stsTrangThai.Name = "stsTrangThai";
            stsTrangThai.Size = new Size(426, 22);
            stsTrangThai.TabIndex = 10;
            stsTrangThai.Text = "statusStrip1";
            // 
            // lblDongHo
            // 
            lblDongHo.Name = "lblDongHo";
            lblDongHo.Size = new Size(60, 17);
            lblDongHo.Text = "Đang tải...";
            // 
            // lblTongSL
            // 
            lblTongSL.Name = "lblTongSL";
            lblTongSL.Size = new Size(67, 17);
            lblTongSL.Text = "| Tổng SL: 0";
            // 
            // lblTongTL
            // 
            lblTongTL.Name = "lblTongTL";
            lblTongTL.Size = new Size(83, 17);
            lblTongTL.Text = "| Tổng TL: 0 kg";
            // 
            // lblTongTien
            // 
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(79, 17);
            lblTongTien.Text = "| Tổng: 0 VNĐ";
            // 
            // btnThem
            // 
            btnThem.Location = new Point(90, 310);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(154, 23);
            btnThem.TabIndex = 9;
            btnThem.Text = "Thêm vào giỏ hàng";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txtTrongLuong
            // 
            txtTrongLuong.Location = new Point(155, 252);
            txtTrongLuong.Name = "txtTrongLuong";
            txtTrongLuong.Size = new Size(100, 23);
            txtTrongLuong.TabIndex = 8;
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(155, 180);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(100, 23);
            txtDonGia.TabIndex = 7;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(155, 114);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(100, 23);
            txtSoLuong.TabIndex = 6;
            // 
            // txtTenHang
            // 
            txtTenHang.Location = new Point(155, 46);
            txtTenHang.Name = "txtTenHang";
            txtTenHang.Size = new Size(100, 23);
            txtTenHang.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 260);
            label4.Name = "label4";
            label4.Size = new Size(74, 15);
            label4.TabIndex = 3;
            label4.Text = "Trọng lượng:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 188);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 2;
            label3.Text = "Đơn giá:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 122);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Số lượng:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 54);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 0;
            label1.Text = "Tên hàng:";
            // 
            // dgvDanhSach
            // 
            dgvDanhSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSach.Columns.AddRange(new DataGridViewColumn[] { Tên, SL, d, t, Column1 });
            dgvDanhSach.Dock = DockStyle.Fill;
            dgvDanhSach.Location = new Point(0, 0);
            dgvDanhSach.Name = "dgvDanhSach";
            dgvDanhSach.Size = new Size(520, 450);
            dgvDanhSach.TabIndex = 0;
            // 
            // Tên
            // 
            Tên.HeaderText = "Tên";
            Tên.Name = "Tên";
            // 
            // SL
            // 
            SL.HeaderText = "SL";
            SL.Name = "SL";
            // 
            // d
            // 
            d.HeaderText = "Đơn giá";
            d.Name = "d";
            // 
            // t
            // 
            t.HeaderText = "Trọng lượng";
            t.Name = "t";
            // 
            // Column1
            // 
            Column1.HeaderText = "Thành tiền";
            Column1.Name = "Column1";
            // 
            // tmrDongHo
            // 
            tmrDongHo.Enabled = true;
            tmrDongHo.Interval = 1000;
            tmrDongHo.Tick += tmrDongHo_Tick;
            // 
            // FormBanHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 450);
            Controls.Add(splitContainer1);
            Name = "FormBanHang";
            Text = "Phần Mềm Bán Hàng Chuyên Nghiệp";
            WindowState = FormWindowState.Maximized;
            Load += FormBanHang_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            stsTrangThai.ResumeLayout(false);
            stsTrangThai.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSach).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private StatusStrip stsTrangThai;
        private Button btnThem;
        private TextBox txtTrongLuong;
        private TextBox txtDonGia;
        private TextBox txtSoLuong;
        private TextBox txtTenHang;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ToolStripStatusLabel lblDongHo;
        private ToolStripStatusLabel lblTongSL;
        private ToolStripStatusLabel lblTongTL;
        private DataGridView dgvDanhSach;
        private DataGridViewTextBoxColumn Tên;
        private DataGridViewTextBoxColumn SL;
        private DataGridViewTextBoxColumn d;
        private DataGridViewTextBoxColumn t;
        private DataGridViewTextBoxColumn Column1;
        private ToolStripStatusLabel lblTongTien;
        private System.Windows.Forms.Timer tmrDongHo;
    }
}
