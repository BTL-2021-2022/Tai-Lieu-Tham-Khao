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

namespace StoreApp
{
    public partial class frmSPham : Form
    {
        public frmSPham()
        {
            InitializeComponent();
        }

        QuanLyBanGiayContext db = new QuanLyBanGiayContext();

        #region kiem tra du lieu nguoi dung nhap


        #region kiểm tra validated
        private void txtMaSP_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtMaSP, "");
        }

        private void txtTenSP_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtTenSP, "");
        }

        private void txtGiaBan_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtGiaBan, "");
        }

        private void cbbTinhTrang_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(cbbTinhTrang, "");
        }

        private void cbbsize_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(cbbsize, "");
        }

        private void txtSlcon_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtSlcon, "");
        }

        private void txtMauSPham_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtMauSPham, "");
        }


        #endregion

        #region kiểm tra Tính hợp lệ dữ liệu
        private bool validata()
        {
            if (string.IsNullOrWhiteSpace(txtMaSP.Text))
            {
                errorProvider1.SetError(txtMaSP, "Mã sản phẩm không hợp lệ!");
                txtMaSP.Focus();
                return false;
            }

            if (txtTenSP.Text == "")
            {
                errorProvider1.SetError(txtTenSP, "Bạn phải nhập tên sản phẩm!");
                txtTenSP.Focus();
                return false;
            }

            if (txtGiaBan.Text == "")
            {
                errorProvider1.SetError(txtGiaBan, "Bạn phải nhập giá sản phẩm!");
                txtGiaBan.Focus();
                return false;
            }

            if (cbbTinhTrang.Text == "")
            {
                errorProvider1.SetError(cbbTinhTrang, "Bạn phải chọn tình trạng");
                cbbTinhTrang.Focus();
                return false;
            }

            if (cbbsize.Text == "")
            {
                errorProvider1.SetError(cbbsize, "Bạn phải nhập size sản phẩm");
                cbbsize.Focus();
                return false;
            }

            if (txtMauSPham.Text == "")
            {
                errorProvider1.SetError(txtMauSPham, "Bạn phải nhập màu sản phẩm");
                txtMauSPham.Focus();
                return false;
            }

            if (txtSlcon.Text == "")
            {
                errorProvider1.SetError(txtSlcon, "Bạn phải nhập số lượng còn");
                txtSlcon.Focus();
                return false;
            }                                              
            return true;
        }

        private bool kt_masp()
        {
            var msp = (from s in db.Sanphams
                       select s.MaSp).ToList();
            if (msp.Contains(txtMaSP.Text))
                return false; // da ton tai ma san pham thi tra ve false - sai
            else
                return true; // khong ton tai  la dung
        }

        private bool kt_size()
        {
            var size = (from s in db.SoLuongCons
                        where s.MaSp == txtMaSP.Text
                        where s.Mau == txtMauSPham.Text
                        select s.Size).ToList();
            if (size.Contains(int.Parse(cbbsize.Text)))
                return false;
            else
                return true;
        }

        private bool kt_Mau()
        {
            var mau = (from s in db.SoLuongCons
                       where s.MaSp == txtMaSP.Text
                       where s.Size == int.Parse(cbbsize.Text)
                       select s.Mau).ToList();
            if (mau.Contains(txtMauSPham.Text))
                return false;
            else
                return true;
        }


        #endregion            

        #region Kiểm tra các thao tác nhập
        private void txtSlcon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtGiaBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtOrderLevel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }


        #endregion

        #endregion

        private void hienThiDuLieu()
        {
            lamMoi();

            var sanPhams = from s in db.Sanphams
                           select new
                           {
                               s.MaSp,
                               s.TenSp,
                               s.GiaBan,
                               s.TinhTrang,
                               s.ThongTin
                           };
            
            dgvsanpham.DataSource = sanPhams.ToList();            

            // hien thi bangSoLuong
            var soLuong = from s in db.SoLuongCons
                          where s.MaSp == dgvsanpham.Rows[0].Cells[0].Value.ToString()
                          select new
                          {                              
                              s.MaSpNavigation.TenSp,
                              s.Size,
                              s.Mau,
                              s.Slcon,
                              s.OrderLevel
                          };
            dgvSoLuong.DataSource = soLuong.ToList();        
    }


        private void frmSPham_Load(object sender, EventArgs e)
        {
           hienThiDuLieu();
        }
                

        private void lamMoi()
        {
            foreach (Control c in groupBox1.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
            }
            cbbsize.SelectedIndex = -1;
            cbbTinhTrang.SelectedIndex = -1;
            txtMaSP.Enabled = true;
            cbbsize.Enabled = true;
            txtMauSPham.Enabled = true;
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            lamMoi();
        }                        
       
        private void btnTimTheoMa_Click(object sender, EventArgs e)
        {
            var sanPhams = (from s in db.Sanphams
                            where s.MaSp == txtTimmaSP.Text
                            select new { 
                            s.MaSp,
                            s.TenSp,
                            s.GiaBan,
                            s.TinhTrang, 
                            s.ThongTin
                            }).ToList();
            dgvsanpham.DataSource = sanPhams;
        }

        private void txtTimmaSP_TextChanged(object sender, EventArgs e)
        {         
                hienThiDuLieu();
        }

        private void txtTimTenSP_TextChanged(object sender, EventArgs e)
        {            
                hienThiDuLieu();
        }

        private void btnTimTheoTen_Click(object sender, EventArgs e)
        {
            var sanPhams = (from s in db.Sanphams
                            where s.TenSp.Contains(txtTimTenSP.Text)
                            select new
                            {
                                s.MaSp,
                                s.TenSp,
                                s.GiaBan,
                                s.TinhTrang,
                                s.ThongTin
                            }).ToList();
            dgvsanpham.DataSource = sanPhams;
        }

        // them sp MOI
        private void btnThemSPham_Click(object sender, EventArgs e)
        {
            if (validata())
            {

                if (kt_masp())
                {
                    Sanpham sp = new Sanpham();
                    sp.MaSp = txtMaSP.Text;
                    sp.TenSp = txtTenSP.Text;
                    sp.GiaBan = decimal.Parse(txtGiaBan.Text);
                    sp.TinhTrang = cbbTinhTrang.Text;
                    sp.ThongTin = txtThongTin.Text;
                    db.Sanphams.Add(sp);
                    db.SaveChanges();

                    SoLuongCon sl_moi = new SoLuongCon();
                    sl_moi.MaSp = txtMaSP.Text;
                    sl_moi.Size = int.Parse(cbbsize.Text);
                    sl_moi.Slcon = int.Parse(txtSlcon.Text);
                    sl_moi.Mau = txtMauSPham.Text;
                    if (txtOrderLevel.Text != "")
                    {
                        sl_moi.OrderLevel = int.Parse(txtOrderLevel.Text);
                    }
                    db.SoLuongCons.Add(sl_moi);
                    db.SaveChanges();
                    MessageBox.Show("Thêm sản phẩm thành công!");
                    hienThiDuLieu();
                }
                else
                {
                    if (kt_size() || kt_Mau())
                    {
                        SoLuongCon sl_moi = new SoLuongCon();
                        sl_moi.MaSp = txtMaSP.Text;
                        sl_moi.Size = int.Parse(cbbsize.Text);
                        sl_moi.Slcon = int.Parse(txtSlcon.Text);
                        sl_moi.Mau = txtMauSPham.Text;
                        if (txtOrderLevel.Text != "")
                        {
                            sl_moi.OrderLevel = int.Parse(txtOrderLevel.Text);
                        }

                        db.SoLuongCons.Add(sl_moi);
                        db.SaveChanges();
                        MessageBox.Show("Thêm sản phẩm thành công!");
                        hienThiDuLieu();
                    }
                    else
                    {
                        MessageBox.Show("Sản phẩm đã tồn tại size và màu này!");
                    }
                }
            }

        }


        // sua hang MOI
        private void btnSuaSPham_Click(object sender, EventArgs e)
        {
            
                if (txtMaSP.Enabled == false)
                {                                            
                    if (cbbsize.Enabled == false && txtMauSPham.Enabled == false)
                    {
                                         
                    if (validata())
                        {
                        // sửa từ bảng SanPham
                        Sanpham spSua = db.Sanphams.SingleOrDefault(sp => sp.MaSp == txtMaSP.Text);
                        spSua.TenSp = txtTenSP.Text;
                        spSua.GiaBan = decimal.Parse(txtGiaBan.Text);
                        spSua.TinhTrang = cbbTinhTrang.Text;
                        if(txtThongTin.Text!="")
                            spSua.ThongTin = txtThongTin.Text;

                        // sửa ở bảng SoLuongCons
                        SoLuongCon slSua = (SoLuongCon)(from s in db.SoLuongCons
                                                        where s.MaSp == txtMaSP.Text
                                                        where s.Size == int.Parse(cbbsize.Text)
                                                        where s.Mau == txtMauSPham.Text
                                                        select s).FirstOrDefault();
                        if (txtOrderLevel.Text != "")
                            slSua.OrderLevel = int.Parse(txtOrderLevel.Text);

                        slSua.Slcon = int.Parse(txtSlcon.Text);
                        db.SaveChanges();
                        MessageBox.Show("Sửa sản phẩm thành công!");
                        lamMoi();
                        hienThiDuLieu();
                    }
                }
                    else
                    {
                        MessageBox.Show("Bạn cần chọn trong danh sách số lượng còn");
                    }

                }
                else
                {
                    MessageBox.Show("Bạn cần chọn sản phẩm trong danh sách");
                }

        }
      

        // xoa sanPham MOI
        private void btnXoaSPham_Click(object sender, EventArgs e)
        {
            if (txtMaSP.Enabled == false)
            {
                if (cbbsize.Enabled == false && txtMauSPham.Enabled == false)
                {
                    DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xoá sản phẩm", "Lưu ý", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        SoLuongCon sp_xoa = (from s in db.SoLuongCons
                                             where s.MaSp == txtMaSP.Text
                                             where s.Size == int.Parse(cbbsize.Text)
                                             where s.Mau == txtMauSPham.Text
                                             select s).SingleOrDefault();
                        db.SoLuongCons.Remove(sp_xoa);
                        db.SaveChanges();
                        MessageBox.Show("Xoá sản phẩm thành công");                        
                    }
                }
                else
                {
                    MessageBox.Show("Bạn cần chọn size và màu trong danh sách số lượng còn");
                }
            }
            else
            {
                MessageBox.Show("Bạn phải chọn sản phẩm trong danh sách");
            }


            // kiem tra san pham neu khong con size va mau
            if(txtMaSP.Text!="")
            {
                SoLuongCon sp = (from s in db.SoLuongCons
                                 where s.MaSp == txtMaSP.Text
                                 select s).FirstOrDefault();
                if (sp == null)
                {
                    Sanpham sp_xoa = db.Sanphams.SingleOrDefault(s => s.MaSp == txtMaSP.Text);
                    db.Sanphams.Remove(sp_xoa);
                    db.SaveChanges();
                }
            }
            hienThiDuLieu();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvsanpham_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int d = e.RowIndex;
                string masp = dgvsanpham.Rows[d].Cells[0].Value.ToString();

                var soLuong = from s in db.SoLuongCons
                              where s.MaSp == masp
                              select new
                              {
                                  s.MaSpNavigation.TenSp,
                                  s.Size,
                                  s.Mau,
                                  s.Slcon,
                                  s.OrderLevel
                              };
                dgvSoLuong.DataSource = soLuong.ToList();

                txtMaSP.Text = dgvsanpham.Rows[d].Cells[0].Value.ToString();
                txtMaSP.Enabled = false;
                txtTenSP.Text = dgvsanpham.Rows[d].Cells[1].Value.ToString();
                txtGiaBan.Text = dgvsanpham.Rows[d].Cells[2].Value.ToString().Replace(".0000", String.Empty);
                cbbTinhTrang.Text = dgvsanpham.Rows[d].Cells[3].Value.ToString();
                if(dgvsanpham.Rows[d].Cells[4].Value != null)
                {
                    txtThongTin.Text = dgvsanpham.Rows[d].Cells[4].Value.ToString();
                }

                cbbsize.Text = null;
                txtSlcon.Text = null;
                txtMauSPham.Text = null;
                txtOrderLevel.Text = null;

            }
            catch (Exception)
            {
                // TRƯỜNG HỢP D=-1;

            }
        }

        private void dgvSoLuong_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {                
                int d = e.RowIndex;
                cbbsize.Text = dgvSoLuong.Rows[d].Cells[1].Value.ToString();
                txtMauSPham.Text = dgvSoLuong.Rows[d].Cells[2].Value.ToString();
                txtSlcon.Text = dgvSoLuong.Rows[d].Cells[3].Value.ToString();
                if (dgvSoLuong.Rows[d].Cells[4].Value!=null)
                {
                    txtOrderLevel.Text = dgvSoLuong.Rows[d].Cells[4].Value.ToString();
                }

                cbbsize.Enabled = false;
                txtMauSPham.Enabled = false;

            }
            catch (Exception)
            {
                // TRƯỜNG HỢP D=-1;

            }
        }

        
    }
}
