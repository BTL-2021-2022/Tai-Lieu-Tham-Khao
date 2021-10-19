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
using StoreApp.DAO;
namespace StoreApp.QuanLyKhoHang
{
    public partial class frNhaCungCap : Form
    {
        private List<Nhacungcap> list;
        private NhaCungCapDAO nhaCungCapDAO;
        public frNhaCungCap()
        {
            list = new List<Nhacungcap>();
            nhaCungCapDAO = new NhaCungCapDAO();
            InitializeComponent();
        }
        private void frNhaCungCap_Load(object sender, EventArgs e)
        {
            LoadData();
            cb_tinhtrang.Text = "K";
        }
        private void LoadData()
        {
            data_ncc.Rows.Clear();
            list = nhaCungCapDAO.getAll();
            foreach(Nhacungcap n in list)
            {
                data_ncc.Rows.Add(n.MaNcc, n.TenNcc, n.Sdtncc, n.DiaChiNcc, n.TinhTrang);
            }
        }
        private void show(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index != -1)
            {
                DataGridViewRow selectedRows = data_ncc.Rows[index];
                txt_ma.Text = selectedRows.Cells[0].Value.ToString();
                txt_ten.Text = selectedRows.Cells[1].Value.ToString();
                txt_diachi.Text = selectedRows.Cells[3].Value.ToString();
                txt_sdt.Text = selectedRows.Cells[2].Value.ToString();
                cb_tinhtrang.Text = selectedRows.Cells[4].Value.ToString();
            }
        }

        private void but_Them_Click_1(object sender, EventArgs e)
        {
            if (txt_sdt.Text == "" || txt_ma.Text == "" || txt_ten.Text == "" || txt_sdt.Text == "" || cb_tinhtrang.Text == "")
            {
                MessageBox.Show("Dien day du thong tin");
                return;
            }
            Nhacungcap ncc = new Nhacungcap();
            ncc.DiaChiNcc = txt_diachi.Text;
            ncc.MaNcc = txt_ma.Text;
            ncc.TenNcc = txt_ten.Text;
            ncc.Sdtncc = txt_sdt.Text;
            ncc.TinhTrang = cb_tinhtrang.Text;
            try
            {
                nhaCungCapDAO.Add(ncc);
                LoadData();
                MessageBox.Show("Them thanh cong");

            }
            catch
            {
                MessageBox.Show("Err");
            }
        }

        private void but_Sua_Click_1(object sender, EventArgs e)
        {
            if (txt_sdt.Text == "" || txt_ma.Text == "" || txt_ten.Text == "" || txt_sdt.Text == "" || cb_tinhtrang.Text == "")
            {
                MessageBox.Show("Dien day du thong tin");
                return;
            }
            foreach (Nhacungcap n in list)
            {
                if (n.MaNcc == txt_ma.Text)
                {
                    Nhacungcap ncc = new Nhacungcap();
                    ncc.Sdtncc = txt_sdt.Text;
                    ncc.MaNcc = txt_ma.Text;
                    ncc.TenNcc = txt_ten.Text;
                    ncc.DiaChiNcc = txt_diachi.Text;
                    ncc.TinhTrang = cb_tinhtrang.Text;
                    try
                    {
                        nhaCungCapDAO.Update(txt_ma.Text, ncc);
                        LoadData();
                        MessageBox.Show("Cap nhat thanh cong");
                        return;
                    }
                    catch
                    {
                        MessageBox.Show("Cap nhat that bai");
                        return;
                    }
                    finally
                    {
                        LoadData();
                    }
                }
            }
            MessageBox.Show("Khong co nha cung cap can sua");
        }

        private void but_Tim_Click_1(object sender, EventArgs e)
        {
            list = nhaCungCapDAO.FindByName(txt_timkiem.Text);
            LoadData();
        }

        private void data_ncc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
