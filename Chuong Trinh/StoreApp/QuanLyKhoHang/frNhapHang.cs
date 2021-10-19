using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StoreApp.DAO;
using StoreApp.Models;
namespace StoreApp.QuanLyKhoHang
{
    public partial class frNhapHang : Form
    {
        SanPhamDAO sanPhamDAO;
        ChiTietHoaDonNhapDAO chiTietHoaDonNhapDAO;
        NhaCungCapDAO nhaCungCapDAO;
        HoaDonNhapDao hoaDonNhapDao;
        DatHangNCCDAO datHangNCCDAO;
        List<Dathangncc> list;
        List<Chitiethoadonnhap> listHoaDonNhap;
        string id="";
        public frNhapHang()
        {
            InitializeComponent();
            sanPhamDAO = new SanPhamDAO();
            chiTietHoaDonNhapDAO = new ChiTietHoaDonNhapDAO();
            nhaCungCapDAO = new NhaCungCapDAO();
            hoaDonNhapDao = new HoaDonNhapDao();
            datHangNCCDAO = new DatHangNCCDAO();
            list = new List<Dathangncc>();
            listHoaDonNhap = new List<Chitiethoadonnhap>();
        }

        private void QuanLyKhoHang_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            data_sanpham.Rows.Clear();
            list = datHangNCCDAO.getAll();
            foreach(Dathangncc s in list)
            {
                data_sanpham.Rows.Add(s.MaHddatHang, s.MaNcc, s.NgayThang, s.TinhTrang);
            }
            data_hoadonnhap.Rows.Clear();
            listHoaDonNhap = chiTietHoaDonNhapDAO.getAll();
            foreach(Chitiethoadonnhap s in listHoaDonNhap)
            {
                data_hoadonnhap.Rows.Add( s.SoHdn, s.MaSp, s.TenSp, s.Size, s.SoLuongNhap, s.DonGiaNhap, s.ThanhTien);
            }
        }

        private void show(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index != -1)
            {
                DataGridViewRow selectedRows = data_sanpham.Rows[index];
                id = selectedRows.Cells[0].Value.ToString();
                if (id != "")
                {
                    try
                    {
                        txt_mahddat.Text = selectedRows.Cells[0].Value.ToString();
                        txt_mancc.Text = selectedRows.Cells[1].Value.ToString();
                        txt_date.Text = selectedRows.Cells[2].Value.ToString();
                        txt_tinhtrang.Text = selectedRows.Cells[3].Value.ToString();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
       

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frNhapHangDat a = new frNhapHangDat(txt_mahddat.Text,txt_mancc.Text);
            a.ShowDialog();
        }

        private void data_hoadonnhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void active(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_reload_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
