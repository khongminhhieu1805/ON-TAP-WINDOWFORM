using System;
using System.Drawing;
using System.Windows.Forms;

namespace khongminhhieubai3windowform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            
            if (cboDVT.Items.Count > 0)
            {
                cboDVT.SelectedIndex = 0;
            }

            
            lvVatTu.View = View.Details;
            lvVatTu.FullRowSelect = true;
            lvVatTu.GridLines = true;

            if (lvVatTu.Columns.Count >= 4)
            {
                lvVatTu.Columns[0].Width = 100;
                lvVatTu.Columns[1].Width = 180; 
                lvVatTu.Columns[2].Width = 110; 
                lvVatTu.Columns[3].Width = 130; 
            }
        }

       
        private void btnThem_Click(object sender, EventArgs e)
        {
            string maVT = txtMaVT.Text.Trim();
            string tenVT = txtTenVT.Text.Trim();

            
            if (string.IsNullOrEmpty(maVT) || string.IsNullOrEmpty(tenVT))
            {
                MessageBox.Show("Mã và Tên vật tư không được để trống!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaVT.Focus();
                return;
            }

          
            if (!decimal.TryParse(txtDonGia.Text.Trim(), out decimal donGia) || donGia < 0)
            {
                MessageBox.Show("Đơn giá nhập phải là số không âm!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDonGia.Focus();
                return;
            }

            
            foreach (ListViewItem item in lvVatTu.Items)
            {
                if (item.Text.Equals(maVT, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Mã vật tư này đã tồn tại! Vui lòng nhập mã khác.", "Trùng lặp mã", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMaVT.SelectAll();
                    txtMaVT.Focus();
                    return;
                }
            }

           
            ListViewItem dongMoi = new ListViewItem(maVT);
            dongMoi.SubItems.Add(tenVT);
            dongMoi.SubItems.Add(cboDVT.SelectedItem.ToString());
            dongMoi.SubItems.Add(string.Format("{0:N0}", donGia));

            lvVatTu.Items.Add(dongMoi);

           
            LamMoiForm();
        }

        
        private void lvVatTu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvVatTu.SelectedItems.Count > 0)
            {
                ListViewItem item = lvVatTu.SelectedItems[0];

                txtMaVT.Text = item.Text;
                txtTenVT.Text = item.SubItems[1].Text;
                cboDVT.SelectedItem = item.SubItems[2].Text;
                
                txtDonGia.Text = item.SubItems[3].Text.Replace(",", "").Replace(".", "");

                
                txtMaVT.Enabled = false;
            }
        }

        
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (lvVatTu.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng nhấp chọn 1 dòng trong bảng trước khi bấm Cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string tenVT = txtTenVT.Text.Trim();
            if (string.IsNullOrEmpty(tenVT))
            {
                MessageBox.Show("Tên vật tư không được để trống!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenVT.Focus();
                return;
            }

            if (!decimal.TryParse(txtDonGia.Text.Trim(), out decimal donGia) || donGia < 0)
            {
                MessageBox.Show("Đơn giá nhập không hợp lệ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDonGia.Focus();
                return;
            }

           
            ListViewItem item = lvVatTu.SelectedItems[0];
            item.SubItems[1].Text = tenVT;
            item.SubItems[2].Text = cboDVT.SelectedItem.ToString();
            item.SubItems[3].Text = string.Format("{0:N0}", donGia);

            MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LamMoiForm();
        }

      
        private void btnXoaDong_Click(object sender, EventArgs e)
        {
            if (lvVatTu.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng nhấp chọn 1 dòng cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa dòng vật tư này không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm == DialogResult.Yes)
            {
                lvVatTu.Items.Remove(lvVatTu.SelectedItems[0]);
                LamMoiForm();
            }
        }

      
        private void btnXoaTatCa_Click(object sender, EventArgs e)
        {
            if (lvVatTu.Items.Count == 0) return;

            DialogResult confirm = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa TOÀN BỘ danh sách vật tư không?",
                "Cảnh báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm == DialogResult.Yes)
            {
                lvVatTu.Items.Clear();
                LamMoiForm();
            }
        }

       
        private void LamMoiForm()
        {
            txtMaVT.Clear();
            txtTenVT.Clear();
            txtDonGia.Clear();
            txtMaVT.Enabled = true; // 
            if (cboDVT.Items.Count > 0) cboDVT.SelectedIndex = 0;
            lvVatTu.SelectedIndices.Clear();
            txtMaVT.Focus();
        }
    }
}