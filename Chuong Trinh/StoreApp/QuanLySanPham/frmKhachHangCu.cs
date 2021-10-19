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
    public partial class frmKhachHangCu : Form
    {

        QuanLyBanGiayContext db = new QuanLyBanGiayContext();
        public frmKhachHangCu()
        {
            InitializeComponent();
        }
        public string selected = "";
        public string getSDT { get; set; }
        private void hienThiDuLieu()
        {
            var khachHangs = (from s in db.Khachhangs
                              select new
                              {
                                  s.TenKh,
                                  s.DiaChiKh,
                                  s.Sdt
                              }).ToList();
            dgvKhachHang.DataSource = khachHangs;

        }

        private void frmKhachHangCu_Load(object sender, EventArgs e)
        {
            hienThiDuLieu();
        }

        private void dgvKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int d = e.RowIndex;
                selected = dgvKhachHang.Rows[d].Cells["SDT"].Value.ToString();
            }
            catch { }
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            getSDT = selected;
            Close();
        }

        private void btnTimTheoTen_Click(object sender, EventArgs e)
        {
            var query = from s in db.Khachhangs
                        where s.TenKh.Contains(txtTimtheoten.Text)
                        select new
                        {
                            s.Sdt,
                            s.TenKh,
                            s.DiaChiKh,
                        };
            //Hiển thị lên datagrid view
            dgvKhachHang.DataSource = query.ToList();
        }

        private void btnTimTheoSDT_Click(object sender, EventArgs e)
        {
            var query = from s in db.Khachhangs
                        where s.Sdt == txtTimtheosdt.Text
                        select new
                        {
                            s.Sdt,
                            s.TenKh,
                            s.DiaChiKh,
                        };
            //Hiển thị lên datagrid view
            dgvKhachHang.DataSource = query.ToList();
        }

        private void txtTimtheosdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtTimtheoten_TextChanged(object sender, EventArgs e)
        {
            hienThiDuLieu();
        }

        private void txtTimtheosdt_TextChanged(object sender, EventArgs e)
        {
            hienThiDuLieu();
        }
    }
}
