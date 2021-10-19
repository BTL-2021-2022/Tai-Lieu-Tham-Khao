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

namespace StoreApp.QuanLySanPham
{
    public partial class frmListSp : Form
    {
        QuanLyBanGiayContext db = new QuanLyBanGiayContext();

        public string selected = "";
        public string CommunicationStuff { get; set; }
        public frmListSp()
        {
            InitializeComponent();
        }

        private void frmListSp_Load(object sender, EventArgs e)
        {
            var sanphams = db.Sanphams.Select(sp => new { 
                sp.MaSp,
                sp.TenSp,
                sp.GiaBan
            });
            dgvSanPham.DataSource = sanphams.ToList();
        }

        private void dgvSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            selected = dgvSanPham.Rows[index].Cells["MaSP"].Value.ToString();
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            CommunicationStuff = selected;
            Close();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            var search = db.Sanphams.Where(sp => sp.TenSp.Contains(txtTim.Text));
            dgvSanPham.DataSource = search.ToList();

        }
    }
}
