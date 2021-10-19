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
namespace StoreApp.ThongKe
{
    public partial class frmSanPhamCanNhap : Form
    {
        QuanLyBanGiayContext db = new QuanLyBanGiayContext();
        public frmSanPhamCanNhap()
        {
            InitializeComponent();
        }

        private void frmSanPhamCanNhap_Load(object sender, EventArgs e)
        {
            
            var kq = from p in db.SoLuongCons
                     where p.Slcon < p.OrderLevel || p.OrderLevel == 0
                     select new { 
                        masp=p.MaSp,
                        size=p.Size,
                        mau=p.Mau,
                        slcon=p.Slcon,
                        orderlv=p.OrderLevel
                     };
            dataGridView1.DataSource = kq.ToList();
            dataGridView1.Columns[0].HeaderText = "Mã sản phẩm";
            dataGridView1.Columns[1].HeaderText = "Size";
            dataGridView1.Columns[2].HeaderText = "Màu";
            dataGridView1.Columns[3].HeaderText = "Số lượng còn";
            dataGridView1.Columns[4].HeaderText = "Số lượng cần";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int d = e.RowIndex;
                txtmasp.Text = dataGridView1.Rows[d].Cells[0].Value.ToString();
                txtsize.Text = dataGridView1.Rows[d].Cells[1].Value.ToString();
                txtmau.Text = dataGridView1.Rows[d].Cells[2].Value.ToString();
                txtslcon.Text = dataGridView1.Rows[d].Cells[3].Value.ToString();
                if (Convert.ToInt32(dataGridView1.Rows[d].Cells[4].Value) ==0 )
                {
                    txtsoluongcan.Text = "0";
                    lblSLCanNhap.Text = "Chưa có Order Level";
                }
                else
                {
                    txtsoluongcan.Text= dataGridView1.Rows[d].Cells[4].Value.ToString();
                    lblSLCanNhap.Text = (Convert.ToInt32(txtsoluongcan.Text) - Convert.ToInt32(txtslcon.Text)).ToString();
                }
            }
            catch (Exception)
            {

            }
          
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string masp = txtmasp.Text;
            int size = Convert.ToInt32(txtsize.Text);
            string mau = txtmau.Text;
            var check = db.SoLuongCons.FirstOrDefault(p => p.MaSp == masp && p.Size == size && p.Mau == mau);
            if (check != null)
            {
                check.OrderLevel = Convert.ToInt32(txtsoluongcan.Text);
                db.SaveChanges();
                var kq = from p in db.SoLuongCons
                         where p.Slcon < p.OrderLevel || p.OrderLevel == 0
                         select new
                         {
                             masp = p.MaSp,
                             size = p.Size,
                             mau = p.Mau,
                             slcon = p.Slcon,
                             orderlv = p.OrderLevel
                         };
                dataGridView1.DataSource = kq.ToList();
                lblSLCanNhap.Text = "";
            }
        }
    }
}
