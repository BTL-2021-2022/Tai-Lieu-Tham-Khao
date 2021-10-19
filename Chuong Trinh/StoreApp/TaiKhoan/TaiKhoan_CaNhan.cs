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

namespace StoreApp.TaiKhoan
{
    public partial class TaiKhoan_CaNhan : Form
    {
        QuanLyBanGiayContext db = new QuanLyBanGiayContext();
        StroredUserData DataStored = new StroredUserData();

        //string tk;
        public TaiKhoan_CaNhan(/*string tk*/)
        {
            
            InitializeComponent();
            //this.tk = tk;
        }
        private bool ValidData()
        {
           
            if (txt_Tennguoidung.Text == "")
            {
                error.SetError(txt_Tennguoidung, "Bạn phải nhập tên");
                txt_Tennguoidung.Focus();
                return false;
            }
            if (txt_SDT.Text == "")
            {
                error.SetError(txt_SDT, "Bạn phải nhập số điện thoại");
                txt_SDT.Focus();
                return false;
            }
            if (txt_SDT.Text.Length != 10)
            {
                error.SetError(txt_SDT, "Điện thoại phải có 10 số ");
                txt_SDT.Focus();
                return false;
            }
            if (txt_DiaChi.Text == "")
            {
                error.SetError(txt_DiaChi, "Bạn phải nhập địa chỉ");
                txt_DiaChi.Focus();
                return false;
            }
            if (txt_MK.Text == "")
            {
                error.SetError(txt_MK, "Bạn phải nhập mật khẩu");
                txt_MK.Focus();
                return false;
            }
            
            return true;
        }
        private void TaiKhoan_CaNhan_Load(object sender, EventArgs e)
        {
            var kq1 = from n in db.Nguoiquanlies
                      where n.MaNql == Global.UserId
                      select n.TinhTrang;
            string tt = kq1.ToList().FirstOrDefault();
            if (tt == "ADMIN")
            {
                MessageBox.Show("Quyền chỉ dành cho nhân viên");
                return;
            }
            
              
                var kq = from n in db.Nguoiquanlies
                         where n.MaNql == Global.UserId
                         select n.MaNql;
                txt_Matk.Text = kq.ToList().FirstOrDefault();

                var kq2 = from n in db.Nguoiquanlies
                          where n.MaNql == Global.UserId
                          select n.TenNql;
                txt_Tennguoidung.Text = kq2.ToList().FirstOrDefault();
                label1.Text = "Nhân viên " + kq2.ToList().FirstOrDefault();
                var kq3 = from n in db.Nguoiquanlies
                          where n.MaNql == Global.UserId
                          select n.Sdtnql;
                txt_SDT.Text = kq3.ToList().FirstOrDefault();

                var kq4 = from n in db.Nguoiquanlies
                          where n.MaNql == Global.UserId
                          select n.DiaChiNql;
                txt_DiaChi.Text = kq4.ToList().FirstOrDefault();

                var kq5 = from n in db.Nguoiquanlies
                          where n.MaNql == Global.UserId
                          select n.MatKhau;
                txt_MK.Text = kq5.ToList().FirstOrDefault();
             
            
        }

        private void but_Sua_Click(object sender, EventArgs e)
        {
            if (ValidData())
            {
                var nqlSua = (from nql in db.Nguoiquanlies
                              where nql.MaNql == txt_Matk.Text
                              select nql).SingleOrDefault();
                if (nqlSua != null)
                {
                    nqlSua.TenNql = txt_Tennguoidung.Text;
                    nqlSua.Sdtnql = txt_SDT.Text;
                    nqlSua.DiaChiNql = txt_DiaChi.Text;
                    nqlSua.MatKhau = txt_MK.Text;
                    nqlSua.TinhTrang = txt_Loaitk.Text;
                    db.SaveChanges();
                    MessageBox.Show("Sửa thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
                
            
        }

        private void but_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_Tennguoidung_Validated(object sender, EventArgs e)
        {
            error.SetError(txt_Tennguoidung, "");
        }

        private void txt_SDT_Validated(object sender, EventArgs e)
        {
            error.SetError(txt_SDT, "");
        }

        private void txt_DiaChi_Validated(object sender, EventArgs e)
        {
            error.SetError(txt_DiaChi, "");
        }

        private void txt_MK_Validated(object sender, EventArgs e)
        {
            error.SetError(txt_MK, "");
        }

        private void txt_SDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
    }
}
