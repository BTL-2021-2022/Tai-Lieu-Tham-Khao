using StoreApp.DAO;
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

namespace StoreApp.QuanLyKhoHang
{
    public partial class frNhapHangDat : Form
    {
        private Chitietdathang item;
        private List<Chitietdathang> listItems;
        private ChiTietDatHangDAO chiTietDatHangDAO;
        private ChiTietHoaDonNhapDAO chiTietHoaDonNhapDAO;
        private List<Chitiethoadonnhap> listNhap;
        HoaDonNhapDao hoaDonNhapDao;
        NhaCungCapDAO nhaCungCapDAO;
        SoLuongConDAO soLuongConDAO;
        string id;
        string idmancc;
        public frNhapHangDat()
        {

        }

        public frNhapHangDat(string text, string mancc)
        {
            id = text;
            InitializeComponent();
            item = new Chitietdathang();
            listItems = new List<Chitietdathang>();
            chiTietDatHangDAO = new ChiTietDatHangDAO();
            chiTietHoaDonNhapDAO = new ChiTietHoaDonNhapDAO();
            listNhap = new List<Chitiethoadonnhap>();
            nhaCungCapDAO = new NhaCungCapDAO();
            hoaDonNhapDao = new HoaDonNhapDao();
            soLuongConDAO = new SoLuongConDAO();
            idmancc = mancc;
        }

        private void frNhapHangDat_Load(object sender, EventArgs e)
        {
             LoadData();
        }
        private void LoadData()
        {
            try
            {
                data_hangdat.Rows.Clear();
                listItems = chiTietDatHangDAO.getById(Int32.Parse(id));
                foreach(Chitietdathang i in listItems)
                {
                    data_hangdat.Rows.Add(i.MaSp, i.TenSp, i.Size, i.Mau, i.SoLuongDat, i.DonGiaDat, i.ThanhTien);
                }
                listNhap = chiTietHoaDonNhapDAO.getAll();
                if (listNhap.Count() == 0 )
                {
                    txt_sohd.Text = "1";
                }
                else
                {
                    txt_sohd.Text = (1 + listNhap[listNhap.Count() - 1].SoHdn) + "";
                }
                Nhacungcap ncc = nhaCungCapDAO.getByID(idmancc);
                txt_tenncc.Text = ncc.TenNcc;
            }
            catch(Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void show(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index != -1)
            {
                item = new Chitietdathang();
                DataGridViewRow selectedRows = data_hangdat.Rows[index];
                soluong1.Text = selectedRows.Cells[4].Value.ToString();
                //
                item.MaSp = selectedRows.Cells[0].Value.ToString();
                item.TenSp = selectedRows.Cells[1].Value.ToString();
                item.Size = Int32.Parse(selectedRows.Cells[2].Value.ToString());
                item.Mau = selectedRows.Cells[3].Value.ToString();
                item.SoLuongDat = Int32.Parse(selectedRows.Cells[4].Value.ToString());
                item.DonGiaDat = Decimal.Parse(selectedRows.Cells[5].Value.ToString());
                item.ThanhTien = Decimal.Parse(selectedRows.Cells[6].Value.ToString());
            }
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Hoadonnhap h = new Hoadonnhap();
                DateTime date = DateTime.Now;
                h.NgayNhap = date;
                h.MaNcc = idmancc;
                h.MaNql = "NQL01";
                hoaDonNhapDao.add(h);
                
                //soLuongConDAO.update(item.MaSp, item.Mau, item.Size, Int32.Parse(soluong1.Text));
                ///////////////////////////////////
                ///
                //Chitietdathang chitietdathang = new Chitietdathang();
                //chitietdathang.MaHddatHang = Int32.Parse(id);
                //chiTietDatHangDAO.update();
                foreach (DataGridViewRow row in data_hangnhap.Rows)
                {
                    Chitiethoadonnhap chitiethoadonnhap = new Chitiethoadonnhap();
                    chitiethoadonnhap.SoHdn = Int32.Parse(txt_sohd.Text);
                    chitiethoadonnhap.MaSp = row.Cells["ma"].Value.ToString();
                    chitiethoadonnhap.TenSp = row.Cells["ten"].Value.ToString();
                    chitiethoadonnhap.Size = Int32.Parse(row.Cells["size"].Value.ToString());
                    chitiethoadonnhap.Mau = row.Cells["mau"].Value.ToString();
                    chitiethoadonnhap.SoLuongNhap = Int32.Parse(row.Cells["sl"].Value.ToString());
                    chitiethoadonnhap.DonGiaNhap = Decimal.Parse(row.Cells["dongia"].Value.ToString());
                    chitiethoadonnhap.ThanhTien = Decimal.Parse(row.Cells["thanhtien"].Value.ToString()) * item.DonGiaDat;
                    chiTietHoaDonNhapDAO.add(chitiethoadonnhap);
                    //More code here
                    soLuongConDAO.update(chitiethoadonnhap.MaSp, chitiethoadonnhap.Mau, chitiethoadonnhap.Size, chitiethoadonnhap.SoLuongNhap);
                    //
                    Chitietdathang chitietdathang = new Chitietdathang();
                    chitietdathang.MaHddatHang = Int32.Parse(id);
                    chitietdathang.MaSp = chitiethoadonnhap.MaSp;
                    chitietdathang.Mau = chitiethoadonnhap.Mau;
                    chitietdathang.Size = chitiethoadonnhap.Size;
                    chitietdathang.SoLuongDat = chitiethoadonnhap.SoLuongNhap;
                    chiTietDatHangDAO.update(chitietdathang);
                    this.Close();
                }
                MessageBox.Show("Thanh cong");
            }
            catch(Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Int32.Parse(soluong1.Text) > item.SoLuongDat)
                {
                    MessageBox.Show("So luong nhap nho hon so luong dat");
                    return;
                }
                item.MaHddatHang = Int32.Parse(id);
                item.SoLuongDat = item.SoLuongDat - Int32.Parse(soluong1.Text);
                data_hangnhap.Rows.Add(item.MaSp, item.TenSp, item.Size,item.Mau, soluong1.Text, item.DonGiaDat, item.ThanhTien);
            }
            catch
            {
                MessageBox.Show("Khong thanh cong");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            data_hangnhap.Rows.Clear();      
        }
    }
}
