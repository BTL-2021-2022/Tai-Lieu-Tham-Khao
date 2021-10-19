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
    public partial class frmHDBanTheoKH : Form
    {
        String sdt;
        QuanLyBanGiayContext db = new QuanLyBanGiayContext();
        public frmHDBanTheoKH(String sdt)
        {
            InitializeComponent();
            this.sdt = sdt;
        }

        private void frmHDBanTheoKH_Load(object sender, EventArgs e)
        {
            var HDBan = (from s in db.Hoadonbans
                         where s.Sdt == sdt
                         select new { 
                            s.SoHd, 
                            s.NgayBan,
                            s.TinhTrangDoiTra
                         }).ToList();
            dgvHoadondaban.DataSource = HDBan;
            lblTongHD.Text = HDBan.Count().ToString();
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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvHoadondaban_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int d = e.RowIndex;
                txtsohd.Text = dgvHoadondaban.Rows[d].Cells[0].Value.ToString();
                txtngayban.Text = dgvHoadondaban.Rows[d].Cells[1].Value.ToString();
            }
            catch { }
        }
    }
}
