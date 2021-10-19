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

namespace StoreApp.Login
{
    public partial class frmForgetPassword : Form
    {
        QuanLyBanGiayContext db = new QuanLyBanGiayContext();
        frmLogin formLogin = new frmLogin();
        public frmForgetPassword()
        {
            InitializeComponent();
        }

        private void linkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            formLogin.Show();
        }
        private void frmForgetPassword_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Application.Exit();
        }
        private void frmForgetPassword_FormClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Application.Exit();
        }

        private void btnGetPassword_Click(object sender, EventArgs e)
        {
            var user = db.Nguoiquanlies.FirstOrDefault(u => u.TenNql.Equals(txtTen.Text) && u.Sdtnql.Equals(txtSDT.Text));
            if (user == null)
            {
                MessageBox.Show("Không tìm thấy thông tin, vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult ask = MessageBox.Show("Mật khẩu của bạn sẽ được gửi lại sau ít phút, vui lòng đăng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (ask == DialogResult.OK)
                {
                    Close();
                    formLogin.Show();
                }
            }
        }
    }
}
