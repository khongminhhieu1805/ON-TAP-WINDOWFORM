
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace khongminhhieubaiso4windowform
{
    public partial class Form1 : Form
    {
       
        private List<Button> danhSachBan = new List<Button>();

     
        private readonly Color MAU_TRONG = Color.LightGray;     
        private readonly Color MAU_DANG_CHON = Color.LimeGreen;   
        private readonly Color MAU_DA_DAT = Color.Crimson;        

        public Form1()
        {
            InitializeComponent();
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {
            if (cboKhungGio.Items.Count > 0)
            {
                cboKhungGio.SelectedIndex = 0;
            }

            SinhSoDoBan(20);
        }

      
        private void SinhSoDoBan(int tongSoBan)
        {
            flpSoDo.Controls.Clear();
            danhSachBan.Clear();

            for (int i = 1; i <= tongSoBan; i++)
            {
                Button btn = new Button
                {
                    Text = $"Bàn {i:D2}",
                    Size = new Size(80, 65),
                    BackColor = MAU_TRONG,
                    Tag = "TRONG", 
                    Font = new Font("Segoe UI", 9.5F, FontStyle.Bold),
                    Margin = new Padding(6)
                };

               
                if (i == 3 || i == 7 || i == 14)
                {
                    btn.BackColor = MAU_DA_DAT;
                    btn.ForeColor = Color.White;
                    btn.Tag = "DA_DAT";
                }

                
                btn.Click += Ban_Click;

                flpSoDo.Controls.Add(btn);
                danhSachBan.Add(btn);
            }

            CapNhatThongKe();
        }

        
        private void Ban_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null) return;

            string trangThai = btn.Tag.ToString();

           
            if (trangThai == "DA_DAT")
            {
                MessageBox.Show("Vị trí này đã có người đặt trước, vui lòng chọn vị trí khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            if (trangThai == "TRONG")
            {
                btn.BackColor = MAU_DANG_CHON;
                btn.ForeColor = Color.Black;
                btn.Tag = "DANG_CHON";
            }
            else if (trangThai == "DANG_CHON")
            {
                btn.BackColor = MAU_TRONG;
                btn.ForeColor = Color.Black;
                btn.Tag = "TRONG";
            }

            CapNhatThongKe();
        }

        
        private void CapNhatThongKe()
        {
            List<string> dsBanDangChon = new List<string>();

            foreach (Button btn in danhSachBan)
            {
                if (btn.Tag.ToString() == "DANG_CHON")
                {
                    dsBanDangChon.Add(btn.Text);
                }
            }

            int soLuongChon = dsBanDangChon.Count;

           
            decimal donGia = (cboKhungGio.SelectedIndex == 0) ? 100000m : 150000m;
            decimal tongTien = soLuongChon * donGia;

           
            txtViTriChon.Text = soLuongChon > 0 ? string.Join(", ", dsBanDangChon) : "";
            lblSoLuong.Text = $"Số vị trí chọn: {soLuongChon}";
            txtTamTinh.Text = string.Format("{0:N0} VNĐ", tongTien);
        }

        
        private void cboKhungGio_SelectedIndexChanged(object sender, EventArgs e)
        {
            CapNhatThongKe();
        }

        
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            int dem = 0;
            foreach (Button btn in danhSachBan)
            {
                if (btn.Tag.ToString() == "DANG_CHON")
                {
                    btn.BackColor = MAU_DA_DAT;
                    btn.ForeColor = Color.White;
                    btn.Tag = "DA_DAT";
                    dem++;
                }
            }

            if (dem == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất 1 vị trí trước khi xác nhận!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            MessageBox.Show($"Đặt thành công các vị trí: {txtViTriChon.Text}\nTổng tiền: {txtTamTinh.Text}", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CapNhatThongKe();
        }

      
        private void btnHuyChon_Click(object sender, EventArgs e)
        {
            foreach (Button btn in danhSachBan)
            {
                if (btn.Tag.ToString() == "DANG_CHON")
                {
                    btn.BackColor = MAU_TRONG;
                    btn.ForeColor = Color.Black;
                    btn.Tag = "TRONG";
                }
            }

            CapNhatThongKe();
        }

      
        private void flpSoDo_Paint(object sender, PaintEventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }
    }
}