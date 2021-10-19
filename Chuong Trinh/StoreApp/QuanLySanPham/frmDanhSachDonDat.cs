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
    public partial class frmDanhSachDonDat : Form
    {
        QuanLyBanGiayContext db = new QuanLyBanGiayContext();
        Donkhdat getDon = new Donkhdat();
        List<Chitietkhdat> sanphams = new List<Chitietkhdat>();
        public frmDanhSachDonDat()
        {
            InitializeComponent();
        }
        private void frmDanhSachDonDat_Load(object sender, EventArgs e)
        {
            DisplayOrderTable();
        }
        private void DisplayOrderTable()
        {
            var orders = db.Donkhdats.Select(hd => new { hd.TenKh, hd.SoHd, hd.TinhTrang }).ToList();
            dgvHoaDons.DataSource = orders;
            lblTongDon.Text = orders.Count().ToString();

        }
        private void ClearTextboxes()
        {
            txtTenKh.Clear();
            txtDiaChi.Clear();
            txtSdt.Clear();
            txtSdt.Clear();
            cbTinhTrang.SelectedValue = "Chờ xử lý";
            txtNgayDat.Clear();
        }
        private void DisplayDataToTextBox(Donkhdat khachhang)
        {
            txtTenKh.Text = khachhang.TenKh;
            txtDiaChi.Text = khachhang.DiaChiKh;
            txtSdt.Text = khachhang.Sdt;
            txtSoHd.Text = khachhang.SoHd.ToString();
            cbTinhTrang.Text = khachhang.TinhTrang;
            txtNgayDat.Text = khachhang.NgayDat.ToString();
        }
        static string ConvertToMoney(decimal money)
        {
            return String.Format("{0:C01}", money).Replace("$", "").Replace(".0", "") + " VND";
        }
        private void DisplayDetailsProduct(List<Chitietkhdat> list)
        {
            decimal tienCoc = 0;
            foreach (var item in list)
            {
                tienCoc += item.DonGiaNhap * item.SoLuongDat * Convert.ToDecimal(0.1);
            }
            dgvSanPhams.DataSource = list.Select(sp => new { sp.MaSp, sp.TenSp, sp.Size, sp.SoLuongDat, sp.Mau }).ToList();

        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
                Donkhdat update = db.Donkhdats.Find(getDon.SoHd);
                update.TinhTrang = cbTinhTrang.SelectedItem.ToString();
                db.SaveChanges();
                DisplayOrderTable();
        }
        private void btnTimKh_Click(object sender, EventArgs e)
        {
            List<Donkhdat> khachhangs = db.Donkhdats.Where(kh => kh.TenKh.Contains(txtTim.Text)).ToList();
            ClearTextboxes();
            dgvHoaDons.DataSource = khachhangs;
            lblTongDon.Text = khachhangs.Count().ToString();
            DisplayDataToTextBox(khachhangs[0]);
            sanphams = db.Chitietkhdats.Where(sp => sp.SoHd == khachhangs[0].SoHd).ToList();
            DisplayDetailsProduct(sanphams);
        }
        private void dgvHoaDons_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            ClearTextboxes();
            string getId = dgvHoaDons.Rows[index].Cells["SoHD"].Value.ToString();
            getDon = db.Donkhdats.Find(int.Parse(getId));
            sanphams = db.Chitietkhdats.Where(sp => sp.SoHd == int.Parse(getId)).ToList();
            DisplayDataToTextBox(getDon);
            DisplayDetailsProduct(sanphams);
        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Global.Status!= "ADMIN" && getDon.TinhTrang == "Đã xử lý")
            {
                btnCapNhat.Enabled = false;
            }
            else
            {
                btnCapNhat.Enabled = true;
            }
        }
    }
}
