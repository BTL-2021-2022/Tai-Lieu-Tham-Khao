using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StoreApp.Login;
using StoreApp.QuanLyKhoHang;
using StoreApp.QuanLySanPham;
using StoreApp.DatHangNCC;
using StoreApp.ThongKe;
namespace StoreApp
{
    public partial class frmMain : Form
    {
        frmLogin newLogin = new frmLogin();
        public string tk { get; set; }
        public string mk { get; set; }
        public frmMain(/*string tk*/)
        {
            InitializeComponent();
           // this.tk = tk;
            hideSubMenu();
           
        }

        private void hideSubMenu()
        {
            panelQLTaiKhoanMenu.Visible = false;
            panelQLSanPhamMenu.Visible = false;
            panelQLKhoHangMenu.Visible = false;
            panelThongKeSubMenu.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            showSubMenu(panelQLTaiKhoanMenu);
        }

        #region MediaSubMenu
        private void button2_Click(object sender, EventArgs e)
        {
           
            openChildForm(new TaiKhoan.TaiKhoan_CaNhan(/*tk*/));
            //..
            //your codes
            //..
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new TaiKhoan.frmTaiKhoan_QL());
            //..
            //your codes
            //..
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }
        #endregion

        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            showSubMenu(panelQLSanPhamMenu);
        }

        #region PlayListManagemetSubMenu
        private void button8_Click(object sender, EventArgs e)
        {
            openChildForm(new frmSPham());            
            //your codes
            //..
        }

        private void button7_Click(object sender, EventArgs e)
        {
            openChildForm(new frmHoaDonBan());
            //your codes
            //..
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }
        #endregion

        private void btnTools_Click(object sender, EventArgs e)
        {
            showSubMenu(panelQLKhoHangMenu);
        }
        #region ToolsSubMenu
        private void button13_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            openChildForm(new frNhapHang());
            //..
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            openChildForm(new frNhaCungCap());
            //..
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            openChildForm(new frHoaDonNhap());
            //..
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }
        #endregion

        private void btnEqualizer_Click(object sender, EventArgs e)
        {
            openChildForm(new Form3());
            //..
            //your codes
            //..
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            newLogin.Show();
        }

        private Form activeForm;
        private void openChildForm(Form childForm)
        {
            //if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            activeForm.StartPosition = FormStartPosition.CenterScreen;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            showSubMenu(panelThongKeSubMenu);
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
           
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (Global.Status == "ADMIN")
            {
                openChildForm(new StoreApp.ThongKe.frmSanPhamCanNhap());


            }
            else
            {
                DialogResult kq2 = MessageBox.Show("Bạn không phải ADMIN?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                openChildForm(new frmKHDat());
            }
            //..
            //your codes
            //..
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {
            openChildForm(new frmTaoHDBan());
            //..
            //your codes
            //..
        }
        private void btnKhachHangDat_Click(object sender, EventArgs e)
        {
            if(Global.Status == "ADMIN")
            {
                openChildForm(new QuanLySanPham.frmDanhSachDonDat());
            }
            else
            {
                openChildForm(new frmKHDat());
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openChildForm(new frmTaoHDBan());
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            if (Global.Status == "ADMIN")
            {
                openChildForm(new frmDatHang());

            }
            else
            {
                DialogResult kq2 = MessageBox.Show("Bạn không phải ADMIN?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                openChildForm(new frmKHDat());
            }
        }

        private void panelToolsSubMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            if (Global.Status == "ADMIN")
            {
                openChildForm(new FrmTatCaDonDatHang());

            }
            else
            {
                DialogResult kq2 = MessageBox.Show("Bạn không phải ADMIN?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                openChildForm(new frmKHDat());
            }
            
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            showSubMenu(panelQLTaiKhoanMenu);
        }

        private void btnQLSanPham_Click(object sender, EventArgs e)
        {
            showSubMenu(panelQLSanPhamMenu);

        }

        private void btnKhoHang_Click(object sender, EventArgs e)
        {
            showSubMenu(panelQLKhoHangMenu);
        }

        private void but_DoiTra_Click(object sender, EventArgs e)
        {
            openChildForm(new HoaDon7Ngay());
        }
    }
}
