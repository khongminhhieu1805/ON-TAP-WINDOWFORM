namespace bt_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (cboLoaiSuCo.Items.Count > 0)
            {
                cboLoaiSuCo.SelectedIndex = 0;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaPhieu.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã phiếu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaPhieu.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNguoiYeuCau.Text))
            {
                MessageBox.Show("Vui lòng nhập Tên người yêu cầu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNguoiYeuCau.Focus();
                return;
            }

            string uuTien = "Thấp";
            if (rdoTrungBinh.Checked)
            {
                uuTien = "Trung bình";
            }
            else if (rdoKhanCap.Checked)
            {
                uuTien = "Khẩn cấp";
            }

            string thietBi = "";
            if (chkPC.Checked) thietBi += "Máy tính bàn, ";
            if (chkLaptop.Checked) thietBi += "Laptop, ";
            if (chkMayIn.Checked) thietBi += "Máy in, ";
            if (chkDienThoai.Checked) thietBi += "Điện thoại, ";

            if (!string.IsNullOrEmpty(thietBi))
            {
                thietBi = thietBi.TrimEnd(',', ' ');
            }
            else
            {
                thietBi = "Không chọn";
            }

            string coAnh = (picAnhLoi.Image != null) ? "Đã đính kèm ảnh lỗi" : "Chưa có ảnh";

            string thongTinPhieu = "=== TÓM TẮT PHIẾU YÊU CẦU SỰ CỐ IT ===\n\n" +
                                   $"• Mã phiếu: {txtMaPhieu.Text}\n" +
                                   $"• Người yêu cầu: {txtNguoiYeuCau.Text}\n" +
                                   $"• Ngày ghi nhận: {dtpNgayGhiNhan.Value:dd/MM/yyyy}\n" +
                                   $"• Mức độ ưu tiên: {uuTien}\n" +
                                   $"• Loại sự cố: {cboLoaiSuCo.Text}\n" +
                                   $"• Thiết bị ảnh hưởng: {thietBi}\n" +
                                   $"• Hình ảnh: {coAnh}";

            MessageBox.Show(thongTinPhieu, "Xác nhận gửi phiếu thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Tệp hình ảnh (*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png";
                openFileDialog.Title = "Chọn ảnh chụp lỗi sự cố";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    picAnhLoi.Image = Image.FromFile(openFileDialog.FileName);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtMaPhieu.Clear();
            txtNguoiYeuCau.Clear();

            dtpNgayGhiNhan.Value = DateTime.Now;

            rdoThap.Checked = true;

            if (cboLoaiSuCo.Items.Count > 0)
            {
                cboLoaiSuCo.SelectedIndex = 0;
            }

            chkPC.Checked = false;
            chkLaptop.Checked = false;
            chkMayIn.Checked = false;
            chkDienThoai.Checked = false;

            if (picAnhLoi.Image != null)
            {
                picAnhLoi.Image.Dispose();
                picAnhLoi.Image = null;
            }

            txtMaPhieu.Focus();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
