using StoreApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreApp.QuanLySanPham
{
    public partial class HoaDon7Ngay : Form
    {
        QuanLyBanGiayContext db = new QuanLyBanGiayContext();
        string shd = "";
        public HoaDon7Ngay()
        {
            InitializeComponent();
        }
        // Hiển thị 
        private void HienThi()
        {
                var query = from s in db.Chitiethoadons                          
                            select new
                            {
                                s.SoHd,
                                s.MaSp,
                                s.SoLuongBan,
                                s.GiaBan,
                                s.ThanhTien,
                                s.SoHdNavigation.NgayBan,
                                s.Mau,
                            };
                data_dshoadon.DataSource = query.ToList();
            }
        private void HoaDon7Ngay_Load(object sender, EventArgs e)
        {
            HienThi();
        }

        private void data_dshoadon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            txt_shd.Text = data_dshoadon.Rows[index].Cells[0].Value.ToString();
            txt_Ngaylap.Text=data_dshoadon.Rows[index].Cells[5].Value.ToString();
        }

        private void but_doitra_Click(object sender, EventArgs e)
        {
            if(txt_shd.Text==null)
            {
                MessageBox.Show("Bạn cần chọn mã hóa đơn!");
            }    
            DoiTra f = new DoiTra(txt_shd.Text);
            //f.manql = DataStored.getMaql();
            f.Show();
        }

        private void but_Tim_Click(object sender, EventArgs e)
        {
            var query = from s in db.Chitiethoadons
                       where s.SoHd == Convert.ToInt32( txt_Sohoadon.Text)
                        select new
                        {
                            s.SoHd,
                            s.MaSp,
                            s.SoLuongBan,
                            s.GiaBan,
                            s.ThanhTien,
                            s.SoHdNavigation.NgayBan,
                        };
            data_dshoadon.DataSource = query.ToList();
        }

        private void but_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}