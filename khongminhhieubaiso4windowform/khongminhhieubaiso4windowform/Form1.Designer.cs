namespace khongminhhieubaiso4windowform
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
            this.flpSoDo = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboKhungGio = new System.Windows.Forms.ComboBox();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.lblTamTinh = new System.Windows.Forms.Label();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.btnHuyChon = new System.Windows.Forms.Button();
            this.txtViTriChon = new System.Windows.Forms.TextBox();
            this.txtTamTinh = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpSoDo
            // 
            this.flpSoDo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpSoDo.Location = new System.Drawing.Point(12, 12);
            this.flpSoDo.Name = "flpSoDo";
            this.flpSoDo.Size = new System.Drawing.Size(428, 426);
            this.flpSoDo.TabIndex = 0;
            this.flpSoDo.Paint += new System.Windows.Forms.PaintEventHandler(this.flpSoDo_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTamTinh);
            this.groupBox1.Controls.Add(this.txtViTriChon);
            this.groupBox1.Controls.Add(this.btnHuyChon);
            this.groupBox1.Controls.Add(this.btnXacNhan);
            this.groupBox1.Controls.Add(this.lblTamTinh);
            this.groupBox1.Controls.Add(this.lblSoLuong);
            this.groupBox1.Controls.Add(this.cboKhungGio);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(488, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 311);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đặt bàn & thống kê";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Khung giờ :";
            // 
            // cboKhungGio
            // 
            this.cboKhungGio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhungGio.FormattingEnabled = true;
            this.cboKhungGio.Items.AddRange(new object[] {
            "Sáng (100.000đ)",
            "Tối (150.000đ)"});
            this.cboKhungGio.Location = new System.Drawing.Point(21, 77);
            this.cboKhungGio.Name = "cboKhungGio";
            this.cboKhungGio.Size = new System.Drawing.Size(121, 24);
            this.cboKhungGio.TabIndex = 1;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuong.Location = new System.Drawing.Point(26, 124);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(139, 20);
            this.lblSoLuong.TabIndex = 2;
            this.lblSoLuong.Text = "Số vị trí chọn : ";
            // 
            // lblTamTinh
            // 
            this.lblTamTinh.AutoSize = true;
            this.lblTamTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTamTinh.Location = new System.Drawing.Point(26, 165);
            this.lblTamTinh.Name = "lblTamTinh";
            this.lblTamTinh.Size = new System.Drawing.Size(106, 22);
            this.lblTamTinh.TabIndex = 3;
            this.lblTamTinh.Text = "Tạm tính : ";
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Location = new System.Drawing.Point(21, 231);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(100, 35);
            this.btnXacNhan.TabIndex = 4;
            this.btnXacNhan.Text = "Xác nhận đặt ";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // btnHuyChon
            // 
            this.btnHuyChon.Location = new System.Drawing.Point(167, 231);
            this.btnHuyChon.Name = "btnHuyChon";
            this.btnHuyChon.Size = new System.Drawing.Size(100, 35);
            this.btnHuyChon.TabIndex = 5;
            this.btnHuyChon.Text = "Hủy chọn tất cả";
            this.btnHuyChon.UseVisualStyleBackColor = true;
            this.btnHuyChon.Click += new System.EventHandler(this.btnHuyChon_Click);
            // 
            // txtViTriChon
            // 
            this.txtViTriChon.Location = new System.Drawing.Point(190, 121);
            this.txtViTriChon.Name = "txtViTriChon";
            this.txtViTriChon.Size = new System.Drawing.Size(100, 22);
            this.txtViTriChon.TabIndex = 6;
            // 
            // txtTamTinh
            // 
            this.txtTamTinh.Location = new System.Drawing.Point(190, 165);
            this.txtTamTinh.Name = "txtTamTinh";
            this.txtTamTinh.Size = new System.Drawing.Size(100, 22);
            this.txtTamTinh.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.flpSoDo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpSoDo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboKhungGio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHuyChon;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Label lblTamTinh;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.TextBox txtTamTinh;
        private System.Windows.Forms.TextBox txtViTriChon;
    }
}

