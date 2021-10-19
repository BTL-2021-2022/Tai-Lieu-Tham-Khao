using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StoreApp.Models;
namespace StoreApp.DatHangNCC
{
    public partial class FrmTatCaDonDatHang : Form
    {
        QuanLyBanGiayContext db = new QuanLyBanGiayContext();
        public FrmTatCaDonDatHang()
        {
            InitializeComponent();
        }

        private void FrmTatCaDonDatHang_Load(object sender, EventArgs e)
        {
            var s = from u in db.Dathangnccs
                    orderby u.MaHddatHang descending
                    select new
                    {
                        mahd=u.MaHddatHang,
                        ncc = u.MaNcc,
                        ngaydat = u.NgayThang,
                        nguoilap=u.NguoiLap,
                        tinhtrang=u.TinhTrang
                    };
            dataGridView1.DataSource = s.ToList();
            dataGridView1.Columns[0].HeaderText = "Mã hóa đơn đặt";
            dataGridView1.Columns[1].HeaderText = "Mã nhà cung cấp";
            dataGridView1.Columns[2].HeaderText = "Ngày đặt";
            dataGridView1.Columns[3].HeaderText = "Người lập";
            dataGridView1.Columns[4].HeaderText = "Tình trạng";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int d = e.RowIndex;
            try
            {
                txtsohd.Text = dataGridView1.Rows[d].Cells[0].Value.ToString();
                txtmancc.Text = dataGridView1.Rows[d].Cells[1].Value.ToString();
                txtNgayDat.Text = dataGridView1.Rows[d].Cells[2].Value.ToString();
                txtNguoiLap.Text = dataGridView1.Rows[d].Cells[3].Value.ToString();
                if (dataGridView1.Rows[d].Cells[4].Value.ToString() == "0")
                {
                    txtTinhTrang.Text = "Chờ xử lí";
                }
                else if(dataGridView1.Rows[d].Cells[4].Value.ToString() == "1")
                {
                    txtTinhTrang.Text = "Đã nhập hàng thành công";
                }
                else if (dataGridView1.Rows[d].Cells[4].Value.ToString() == "2")
                {
                    txtTinhTrang.Text = "Đã hủy";
                }

            }
            catch (Exception)
            {

                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtsohd.Text))
            {
                MessageBox.Show("Vui lòng chọn một bản ghi");
            }    
            else
            {
                frmChiTietDatHang f = new frmChiTietDatHang(txtsohd.Text); // XEM CHI TIẾT HÓA ĐƠN 
                f.Show();
            }    
        }

        private void btnXN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtsohd.Text))
            {
                MessageBox.Show("Vui lòng chọn đơn hàng muốn xác nhận");
            }
            else
            {
                int madh = Convert.ToInt32(txtsohd.Text);
                var check = db.Dathangnccs.FirstOrDefault(p => p.MaHddatHang == madh);
                if (check != null)
                {
                    DialogResult kq1 = MessageBox.Show("Xác nhận nhập đơn hàng này?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (kq1.Equals(DialogResult.Yes)&&check.TinhTrang==0)
                    {
                        check.TinhTrang = 1;
                        db.SaveChanges();
                        var s = from u in db.Dathangnccs
                                orderby u.MaHddatHang descending
                                select new
                                {
                                    mahd = u.MaHddatHang,
                                    ncc = u.MaNcc,
                                    ngaydat = u.NgayThang,
                                    nguoilap=u.NguoiLap,
                                    tinhtrang = u.TinhTrang
                                };
                        dataGridView1.DataSource = s.ToList();
                    }
                    else if (check.TinhTrang == 1)
                    {
                        MessageBox.Show("Đơn hàng này đã được nhập");
                    }
                    else if (check.TinhTrang == 2)
                    {
                        MessageBox.Show("Không thể nhập đơn hàng đã hủy");
                    }
                }
            }
       
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtsohd.Text))
            {
                MessageBox.Show("Vui lòng chọn đơn hàng muốn hủy nhập");
            }
            else
            {
                int madh = Convert.ToInt32(txtsohd.Text);
                var check = db.Dathangnccs.FirstOrDefault(p => p.MaHddatHang == madh);
                if (check != null)
                {
                    DialogResult kq1 = MessageBox.Show("Hủy nhập đơn hàng này?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (kq1.Equals(DialogResult.Yes)&&check.TinhTrang==0)
                    {
                        check.TinhTrang = 2;
                        db.SaveChanges();
                        var s = from u in db.Dathangnccs
                                orderby u.MaHddatHang descending
                                select new
                                {
                                    mahd = u.MaHddatHang,
                                    ncc = u.MaNcc,
                                    ngaydat = u.NgayThang,
                                    nguoilap=u.NguoiLap,
                                    tinhtrang = u.TinhTrang
                                };
                        dataGridView1.DataSource = s.ToList();
                    }
                    else if (check.TinhTrang == 1)
                    {
                        MessageBox.Show("Không thể hủy đơn hàng đã được nhập");
                    }
                    else if (check.TinhTrang == 2)
                    {
                        MessageBox.Show("Đơn hàng này đã bị hủy từ trước");
                    }
                }
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void txtTinhTrang_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNgayDat_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtmancc_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtsohd_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNguoiLap_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
