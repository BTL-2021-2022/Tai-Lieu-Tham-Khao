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
    public partial class frmTaiKhoan_QL : Form
    {
        QuanLyBanGiayContext db = new QuanLyBanGiayContext();
        

        public frmTaiKhoan_QL()
        {
            InitializeComponent();
        }
        // validate 
        private bool ValidData()
        {
            if (txt_Ma.Text == "")
            {
                error.SetError(txt_Ma, "Bạn phải nhập mã");
                txt_Ma.Focus();
                return false;
            }
            if (txt_Ten.Text == "")
            {
                error.SetError(txt_Ten, "Bạn phải nhập tên");
                txt_Ten.Focus();
                return false;
            }
            if (txt_sdt.Text == "")
            {
                error.SetError(txt_sdt, "Bạn phải nhập số điện thoại");
                txt_sdt.Focus();
                return false;
            }
            if (txt_sdt.Text.Length != 10)
                {
                    error.SetError(txt_sdt, "Điện thoại phải có 10 số ");
                    txt_sdt.Focus();
                    return false;
                }            
            if (txt_dc.Text == "")
            {
                error.SetError(txt_dc, "Bạn phải nhập địa chỉ");
                txt_dc.Focus();
                return false;
            }         
            if (txt_mk.Text == "")
            {
                error.SetError(txt_mk, "Bạn phải nhập mật khẩu");
                txt_mk.Focus();
                return false;
            }
            if (combo_Loai.Text == "")
            {
                error.SetError(combo_Loai, "Bạn phải chọn loại tài khoản");
                combo_Loai.Focus();
                return false;
            }
            return true;
        }

        // hiển thị 
        private void HienThi()
        {
            var query = from lsp in db.Nguoiquanlies
                        select new
                        {
                            lsp.MaNql,
                            lsp.TenNql,
                            lsp.Sdtnql,
                            lsp.DiaChiNql,
                            lsp.MatKhau,
                            lsp.TinhTrang,
                        };
            data_QLTK.DataSource = query.ToList();           
        }

        private void frmTaiKhoan_QL_Load(object sender, EventArgs e)
        {
            var kq1 = from n in db.Nguoiquanlies
                      where n.MaNql == Global.UserId
                      select n.TinhTrang;
            string tt = kq1.ToList().FirstOrDefault();
            if (tt == "NV")
            {
                MessageBox.Show("Quyền chỉ dành cho ADMIN");
                return;
            }
            HienThi();

            this.txt_mk.PasswordChar = '*';
            
            txt_Ma.Clear();
            txt_Ten.Clear();
            txt_sdt.Clear();
            txt_dc.Clear();
            txt_mk.Clear();
            combo_Loai.Text = null;
            txt_MaTim.Clear();
        }

        private void but_Thoát_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void but_Them_Click(object sender, EventArgs e)
        {
            if (ValidData())
            {
                Nguoiquanly nqlMoi = new Nguoiquanly();
                nqlMoi.MaNql = txt_Ma.Text;
                nqlMoi.TenNql = txt_Ten.Text;
                nqlMoi.Sdtnql = txt_sdt.Text;
                nqlMoi.DiaChiNql = txt_dc.Text;
                nqlMoi.MatKhau = txt_mk.Text;
                nqlMoi.TinhTrang = combo_Loai.Text;
                if (!db.Nguoiquanlies.Contains(nqlMoi))
                {
                    db.Nguoiquanlies.Add(nqlMoi);
                    db.SaveChanges();
                    HienThi();
                    MessageBox.Show("Thêm thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Đã có người mã " + txt_Ma.Text + " trong danh sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void but_Sua_Click(object sender, EventArgs e)
        {
            if (ValidData())
            {
                var nqlSua = (from nql in db.Nguoiquanlies
                              where nql.MaNql == txt_Ma.Text
                              select nql).SingleOrDefault();
                if (nqlSua != null)
                {
                    nqlSua.TenNql = txt_Ten.Text;
                    nqlSua.Sdtnql = txt_sdt.Text;
                    nqlSua.DiaChiNql = txt_dc.Text;
                    nqlSua.MatKhau = txt_mk.Text;
                    nqlSua.TinhTrang = combo_Loai.Text;
                    db.SaveChanges();
                    HienThi();
                    MessageBox.Show("Sửa thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không có sản phẩm mã " + txt_Ma.Text + " trong danh sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void data_QLTK_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {       
            int index = e.RowIndex;
            txt_Ten.Text = data_QLTK.Rows[index].Cells[1].Value.ToString();
            txt_Ma.Text = data_QLTK.Rows[index].Cells[0].Value.ToString();
            txt_sdt.Text = data_QLTK.Rows[index].Cells[2].Value.ToString();
            txt_dc.Text = data_QLTK.Rows[index].Cells[3].Value.ToString();
            txt_mk.Text = data_QLTK.Rows[index].Cells[4].Value.ToString();
            combo_Loai.Text = data_QLTK.Rows[index].Cells[5].Value.ToString();
        }

        private void txt_Ma_Validated(object sender, EventArgs e)
        {
            error.SetError(txt_Ma, "");
        }

        private void txt_Ten_Validated(object sender, EventArgs e)
        {
            error.SetError(txt_Ten, "");
        }

        private void txt_sdt_Validated(object sender, EventArgs e)
        {
            error.SetError(txt_sdt, "");
        }

        private void txt_dc_Validated(object sender, EventArgs e)
        {
            error.SetError(txt_dc, "");
        }

        private void txt_mk_Validated(object sender, EventArgs e)
        {
            error.SetError(txt_mk, "");
        }

        private void combo_Loai_Validated(object sender, EventArgs e)
        {
            error.SetError(combo_Loai, "");
        }

        private void but_Tim_Click(object sender, EventArgs e)
        {
            var query = from s in db.Nguoiquanlies
                        where s.MaNql == txt_MaTim.Text
                        select new
                        {
                            s.MaNql,
                            s.TenNql,
                            s.Sdtnql,
                            s.DiaChiNql,
                            s.MatKhau,
                            s.TinhTrang,
                        };
            data_QLTK.DataSource = query.ToList();
        }

        private void txt_sdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void data_QLTK_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(e.ColumnIndex==4 && e.Value!=null)
            {
                e.Value = new string('*', e.Value.ToString().Length);
            }    
        }
    }
    }
