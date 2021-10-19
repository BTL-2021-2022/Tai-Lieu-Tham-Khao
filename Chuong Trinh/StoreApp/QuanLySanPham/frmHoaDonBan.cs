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
    public partial class frmHoaDonBan : Form
    {
        public frmHoaDonBan()
        {
            InitializeComponent();
        }

        QuanLyBanGiayContext db = new QuanLyBanGiayContext();
       
            private void xemChiTietHD(int shd)
        {
            frmChiTietHoaDon newFrom = new frmChiTietHoaDon(shd);
            newFrom.Show();
            this.Hide();
        }
        private void frmHoaDonBan_Load(object sender, EventArgs e)
        {            
            hienTHiDuLieu();

            var sdt_kh = (from s in db.Hoadonbans
                          select s.Sdt).Distinct().ToList();
            cbbHDTheoKH.DataSource = sdt_kh;

            var maNQL = (from s in db.Hoadonbans
                        select s.MaNql).Distinct().ToList();
            cbbHDTheoNQL.DataSource = maNQL;

        }  
        private void hienTHiDuLieu()
        {
            var hdBans = (from s in db.Hoadonbans
                          select new
                          {
                              s.SoHd,
                              s.NgayBan,
                              s.TinhTrangDoiTra
                          }).ToList();
            dgvHoaDon.DataSource = hdBans;
            tongHd();
        }

        private void dgvHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int d = e.RowIndex;
                txtsohd.Text = dgvHoaDon.Rows[d].Cells[0].Value.ToString();
                txtngayban.Text = dgvHoaDon.Rows[d].Cells[1].Value.ToString();
            }
            catch { }
        }

        private void tongHd()
        {
            int tong = (from s in db.Hoadonbans
                        select s).Count();
            lbltongsohoadondanhap.Text = tong.ToString();
        }      

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            if (txtsohd.Text != "")
            {
                frmChiTietHoaDon newForm = new frmChiTietHoaDon(int.Parse(txtsohd.Text));
                newForm.Show();

            }
                
            else
                MessageBox.Show("Bạn chưa chọn bản ghi nào!");
        }

        private void btnXemHDTheoKH_Click(object sender, EventArgs e)
        {
            frmHDBanTheoKH newForm = new frmHDBanTheoKH(cbbHDTheoKH.Text);
            newForm.Show();
        }

        private void btnXemHDTheoNQL_Click(object sender, EventArgs e)
        {
            frmHDBanTheoNV newForm = new frmHDBanTheoNV(cbbHDTheoNQL.Text);
            newForm.Show();
        }

        private void cbbHDTheoKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }           
        }               
    }
}
