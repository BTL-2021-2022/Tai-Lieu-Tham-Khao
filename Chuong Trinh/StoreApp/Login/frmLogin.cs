using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StoreApp.Models;
using StoreApp.QuanLySanPham;
using StoreApp.TaiKhoan;

namespace StoreApp.Login
{
    public partial class frmLogin : Form
    {
        QuanLyBanGiayContext db = new QuanLyBanGiayContext();
        //StroredUserData DataStored = new StroredUserData(); 
        static bool isShow = false;
        // lan
        //public string MaNQL { get; set; }
        //
        public frmLogin()
        {
            InitializeComponent();
            
        }
        
        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = true;
            
        }

        private void linkForgetPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmForgetPassword newFrom = new frmForgetPassword();
            newFrom.Show();
            this.Hide();  
        }
        private static void ExitForm(EventArgs e)
        {
           
        }
        private void frmLogin_Closing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // lan 
            //string tk = txtTaiKhoan.Text;
            //string mk = txtMatKhau.Text;
            //MaNQL = tk;
            //
            var acount = db.Nguoiquanlies.SingleOrDefault(ql => ql.MaNql.Equals(txtTaiKhoan.Text) && ql.MatKhau.Equals(txtMatKhau.Text));
            if (acount != null)
            {
                if(acount.TinhTrang.ToLower() != "vhh")
                {
                    //DataStored.Store(acount);
                    Global.UserId = acount.MaNql;
                    Global.UserName = acount.TenNql;
                    Global.Status = acount.TinhTrang;
                    frmMain newMain = new frmMain();
                    newMain.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Tài khoản của bạn đã bị vô hiệu hóa, vui lòng liên hệ quản lý!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu của bạn không đúng, vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }


        private void lblMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (isShow)
            {
                isShow = false;
                lblMatKhau.Text = "Ẩn";
                txtMatKhau.UseSystemPasswordChar = false;
            }
            else
            {
                isShow = true;
                lblMatKhau.Text = "Hiện";
                txtMatKhau.UseSystemPasswordChar = true;
            }
        }

       
}
    
}
   
