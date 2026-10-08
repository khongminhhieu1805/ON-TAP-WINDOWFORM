using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitapwindowformkhongminhhieubaiso1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            
            if (!decimal.TryParse(txtDonGia.Text.Trim(), out decimal donGia) || donGia < 0)
            {
                MessageBox.Show("Vui lòng nhập đơn giá hợp lệ (số không âm)!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDonGia.Focus();
                return;
            }

            
            if (!int.TryParse(txtSoLuong.Text.Trim(), out int soLuong) || soLuong <= 0)
            {
                MessageBox.Show("Số lượng khách phải là số nguyên lớn hơn 0!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoLuong.Focus();
                return;
            }

            
            decimal giamGia = 0;
            if (!string.IsNullOrWhiteSpace(txtGiamGia.Text))
            {
                if (!decimal.TryParse(txtGiamGia.Text.Trim(), out giamGia) || giamGia < 0 || giamGia > 100)
                {
                    MessageBox.Show("% Giảm giá phải nằm trong khoảng từ 0 đến 100!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtGiamGia.Focus();
                    return;
                }
            }

            
            decimal tongTien = (donGia * soLuong) * ((100 - giamGia) / 100m);

            
            lblTongTien.Text = string.Format("Tổng tiền: {0:N0} VNĐ", tongTien);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtDonGia.Clear();
            txtSoLuong.Clear();
            txtGiamGia.Clear();
            lblTongTien.Text = "Tổng tiền: 0 VNĐ";
            txtDonGia.Focus(); 
        }
    }
}
