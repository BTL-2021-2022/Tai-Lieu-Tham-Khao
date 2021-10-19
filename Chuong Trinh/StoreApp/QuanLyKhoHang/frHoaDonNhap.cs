using System;
using System.Collections.Generic;
using System.Drawing;

using System.Windows.Forms;
using StoreApp.Models;
using StoreApp.DAO;
using System.Globalization;


namespace StoreApp.QuanLyKhoHang
{
    public partial class frHoaDonNhap : Form
    {
        private List<Hoadonnhap> list;
        private HoaDonNhapDao hoaDonNhapDAO;
        private NguoiQuanLyDAO nguoiQuanLyDAO;
        private ChiTietHoaDonNhapDAO chiTietHoaDonNhapDAO;
        //string idmanql;
        public frHoaDonNhap( )
        {
            list = new List<Hoadonnhap>();
            hoaDonNhapDAO = new HoaDonNhapDao();
            nguoiQuanLyDAO = new NguoiQuanLyDAO();
            chiTietHoaDonNhapDAO = new ChiTietHoaDonNhapDAO();
            //idmanql = manql;
            InitializeComponent();
        }
        private void LoadData()
        {
            data_hoadon.Rows.Clear();
            list = hoaDonNhapDAO.getAll();
            foreach (Hoadonnhap n in list)
            {
                data_hoadon.Rows.Add(n.SoHdn, n.MaNcc, n.MaNql, n.NgayNhap.ToString("dd/MM/yyyy"));
            }
        }
        private void frHoaDonNhap_Load(object sender, EventArgs e)
        {
            LoadData();        }

        private void show(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index != -1)
            {
                DataGridViewRow selectedRows = data_hoadon.Rows[index];
                txt_so.Text = selectedRows.Cells[0].Value.ToString();
                txt_ma.Text = selectedRows.Cells[1].Value.ToString();
                txt_nql.Text = selectedRows.Cells[2].Value.ToString();
                txt_date.Text = selectedRows.Cells[3].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frChiTietDonNhap a = new frChiTietDonNhap(txt_so.Text, txt_ma.Text, txt_nql.Text);
            a.ShowDialog();
        }
    }
}

       

