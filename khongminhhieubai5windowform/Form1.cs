namespace bt_05
{
    public partial class FormBanHang : Form
    {
        public FormBanHang()
        {
            InitializeComponent();
        }

        private void FormBanHang_Load(object sender, EventArgs e)
        {

        }

        private void tmrDongHo_Tick(object sender, EventArgs e)
        {
            lblDongHo.Text = "🕒 " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenHang.Text))
            {
                MessageBox.Show("Vui lòng nhập tên hàng hóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtSoLuong.Text, out int soLuong) || soLuong <= 0)
            {
                MessageBox.Show("Số lượng phải là số nguyên lớn hơn 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(txtDonGia.Text, out double donGia) || donGia <= 0)
            {
                MessageBox.Show("Đơn giá phải là số hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(txtTrongLuong.Text, out double trongLuong) || trongLuong < 0)
            {
                MessageBox.Show("Trọng lượng phải là số hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            double thanhTien = soLuong * donGia;

            
            
            dgvDanhSach.Rows.Add(
                txtTenHang.Text.Trim(),
                soLuong,
                donGia.ToString("N0"),
                trongLuong,
                thanhTien.ToString("N0")
            );

         
            CapNhatThongKe();

            
            txtTenHang.Clear();
            txtSoLuong.Clear();
            txtDonGia.Clear();
            txtTrongLuong.Clear();
            txtTenHang.Focus();
        }
    

        private void CapNhatThongKe()
        {
            int tongSL = 0;
            double tongTL = 0;
            double tongTien = 0;

            
            foreach (DataGridViewRow row in dgvDanhSach.Rows)
            {
              
                if (row.IsNewRow) continue;

                
                tongSL += Convert.ToInt32(row.Cells[1].Value);
                tongTL += Convert.ToDouble(row.Cells[3].Value);

                
                string tienStr = row.Cells[4].Value.ToString().Replace(",", "").Replace(".", "");
                tongTien += Convert.ToDouble(tienStr);
            }

            
            lblTongSL.Text = $"| Tổng SL: {tongSL:N0}";
            lblTongTL.Text = $"| Tổng TL: {tongTL} kg";
            lblTongTien.Text = $"| Tổng: {tongTien:N0} VNĐ";
        }
    }
}
