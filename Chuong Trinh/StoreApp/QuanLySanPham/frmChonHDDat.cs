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

namespace StoreApp
{
    public partial class frmChonHDDat : Form
    {
        public frmChonHDDat()
        {
            InitializeComponent();
        }

        QuanLyBanGiayContext db = new QuanLyBanGiayContext();

        public string selected = "";
        public int getSHD { get; set; }

        private void hienThiDuLieu()           
        {
            var khachHangs = (from s in db.Donkhdats
                              //where s.TinhTrang.Contains("xử lý")
                              where s.TinhTrang == "Chờ xử lý"
                              select new
                              {
                                  s.SoHd,
                                  s.Sdt,
                                  s.TenKh,
                                  s.NgayDat,
                                  s.TienCoc
                              }).ToList();
            dgvDSachDonDat.DataSource = khachHangs;

        }

        private void frmChonHDDat_Load(object sender, EventArgs e)
        {
            hienThiDuLieu();
        }

        private void dgvDSachDonDat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int d = e.RowIndex;
                selected = dgvDSachDonDat.Rows[d].Cells["SoHD"].Value.ToString();
            }
            catch { }
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            try
            {
                getSHD = int.Parse(selected);
            }
            catch
            {
                MessageBox.Show("Bạn chưa chọn");
            }
            Close();
        }

        private void btnTimTheoSDT_Click(object sender, EventArgs e)
        {
            var query = from s in db.Donkhdats
                        where s.Sdt == txtTimtheosdt.Text
                        select new
                        {
                            s.SoHd,
                            s.Sdt,
                            s.TenKh,
                            s.NgayDat,
                            s.TienCoc
                        };
            //Hiển thị lên datagrid view
            dgvDSachDonDat.DataSource = query.ToList();
        }

        private void txtTimtheosdt_TextChanged(object sender, EventArgs e)
        {
            hienThiDuLieu();
        }

        private void txtTimtheoten_TextChanged(object sender, EventArgs e)
        {
            hienThiDuLieu();
        }

        private void btnTimTheoSoHD_Click(object sender, EventArgs e)
        {
            var query = from s in db.Donkhdats
                        where s.SoHd == int.Parse(txtTimtheoSHD.Text)
                        select new
                        {
                            s.SoHd,
                            s.Sdt,
                            s.TenKh,
                            s.NgayDat,
                            s.TienCoc
                        };
            //Hiển thị lên datagrid view
            dgvDSachDonDat.DataSource = query.ToList();
        }

        private void txtTimtheoSHD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtTimtheosdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
    }
}
