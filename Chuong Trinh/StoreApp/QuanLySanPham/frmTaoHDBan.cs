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

using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace StoreApp
{
    public partial class frmTaoHDBan : Form
    {
        QuanLyBanGiayContext db = new QuanLyBanGiayContext();        



        public frmTaoHDBan()
        {
            InitializeComponent();           
        }
        
        // đưa các thông tin trên GroupBox và thông tin hàng hoá bán
        private void frmTaoHDBan_Load(object sender, EventArgs e)
        {            
            // ma hoa don
            txtMahoadon.Text = ((from s in db.Hoadonbans select s.SoHd).Max()+1).ToString();

            // hien thi thong tin nhan vien            
            cbbNguoiLap.DataSource = db.Nguoiquanlies.ToList();
            cbbNguoiLap.DisplayMember = "TenNQL";
            cbbNguoiLap.ValueMember = "MaNQL";
            cbbNguoiLap.SelectedValue = Global.UserId;
            //cbbNguoiLap.SelectedValue = "NQL01";


            // hien thi danh sach san pham
            cbbTenHang.DataSource = db.Sanphams.ToList();
            cbbTenHang.DisplayMember = "TenSP";
            cbbTenHang.ValueMember = "MaSP";

            dgvBanHang.AllowUserToAddRows = false;

            xoaHD_Nhap();
            thongTin();                                    
        }

        // thông tin về size, mau, Giaban
        private void thongTin()
        {

            // danh sach san phẩm
            var soLuong = from s in db.SoLuongCons
                          where s.MaSp == cbbTenHang.SelectedValue.ToString()
                          select s;

            // hiện size            
            cbbSize.DataSource = (from m in soLuong select m.Size).Distinct().ToList();


            // hiện Mau
            cbbMau.DataSource = (from m in soLuong select m.Mau).Distinct().ToList();                     

            //giá bán
            var giaBan = (from s in db.Sanphams
                          where s.MaSp == cbbTenHang.SelectedValue.ToString()
                          select s.GiaBan).FirstOrDefault();
            txtDonGia.Text = giaBan.ToString("0.");

            txtsoluong.Text = "";

            capnhat_SL();
        }
        

        #region Kiểm tra dữ liệu người dùng

        private void txthoten_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txthoten, "");
        }

        private void txtsodienthoai_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtsodienthoai, "");
        }

        private void txtdiachi_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtdiachi, "");
        }
        private void cbbTenHang_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(cbbTenHang, "");
        }

        private void txtsoluong_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtsoluong, "");
        }

        private void cbbMau_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(cbbMau, "");
        }

        private void cbbSize_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(cbbSize, "");
        }

        private void txtsodienthoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtChietKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
            tinh_TienHD();
        }
       
        private void txtsoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        // nho hon slCon
        private void txtsoluong_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(txtsoluong.Text) > Convert.ToInt32(txtSLcon.Text))
                {
                    errorProvider1.SetError(txtsoluong, "Nhập số lượng nhỏ hơn số lượng còn");
                    txtsoluong.Focus();
                    txtsoluong.Text = "";
                }
                txtthanhtien.Text = (int.Parse(txtsoluong.Text) * decimal.Parse(txtDonGia.Text)).ToString("0.");
            }
            catch
            {
                // bắt lỗi khi nhập sl = ""
            }
        }

        #endregion

        #region kiểm tra dữ liệu nhập đã đầy đủ chưa
        private bool validata()
        {
            if (cbbTenHang.Text == "")
            {
                errorProvider1.SetError(cbbTenHang, "Bạn phải lựa chọn sản phẩm");
                cbbTenHang.Focus();
                return false;
            }

            if (cbbSize.Text == "")
            {
                errorProvider1.SetError(cbbSize, "Bạn phải chọn size");
                cbbSize.Focus();
                return false;
            }

            if (cbbMau.Text == "")
            {
                errorProvider1.SetError(cbbMau, "Bạn phải chọn màu");
                cbbMau.Focus();
                return false;
            }

            if (txtsoluong.Text == "" || int.Parse(txtsoluong.Text) <= 0)
            {
                errorProvider1.SetError(txtsoluong, "Bạn phải nhập số lượng lớn hơn 0");
                txtsoluong.Focus();
                return false;
            }


            return true;
        }

        private bool kt_KhachHang()
        {
            if (txtsodienthoai.Text == "")
            {
                errorProvider1.SetError(txtsodienthoai, "Bạn phải nhập số điện thoại");
                txtsodienthoai.Focus();
                return false;
            }

            if (txthoten.Text == "")
            {
                errorProvider1.SetError(txthoten, "Bạn phải nhập họ tên khách hàng");
                txthoten.Focus();
                return false;
            }

            if (txtdiachi.Text == "")
            {
                errorProvider1.SetError(txtdiachi, "Bạn cần nhập địa chỉ khách hàng!");
                txtdiachi.Focus();
                return false;
            }
            return true;
        }


        #endregion


        #region cập nhật khi thay đổi
        // lua chon HANG khac cap nhat size, mau, gia ban
        private void cbbTenHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            thongTin();
        }

        // ham cap nhat so Luong
        private void capnhat_SL()
        {
            try
            {
                var soLuong = (from s in db.SoLuongCons
                               where s.MaSp == cbbTenHang.SelectedValue.ToString()
                               where s.Size == int.Parse(cbbSize.SelectedValue.ToString())
                               where s.Mau == cbbMau.SelectedValue.ToString()
                               select s.Slcon).FirstOrDefault();
                txtSLcon.Text = soLuong.ToString();
            }
            catch
            {

            }
        }

        //lua chọn SIZE khac cap nhat so luong
        private void cbbSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtsoluong.Text = "";
            capnhat_SL();
        }

        // lua chon Mau khac cap nhat so luong
        private void cbbMau_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtsoluong.Text = "";
            capnhat_SL();
        }

        #endregion


        #region Tính tiền

        private void tienSanPham(decimal tien)
        {
            decimal tt = decimal.Parse(txtTongTien.Text);
            tt += tien;
            txtTongTien.Text = tt.ToString("0.");
        }

        private void tinh_TienHD()
        {
            try
            {
                String ck;
                if (txtChietKhau.Text == "")
                {
                    ck = "0";
                }
                else
                    ck = txtChietKhau.Text;
                decimal tien = decimal.Parse(txtTTien.Text);
                tien = decimal.Parse(txtTongTien.Text) * (1 - (decimal.Parse(ck) / 100));
                txtTTien.Text = tien.ToString("0.");
            }
            catch
            {

            }
        }
        private void tinh_TienTra()
        {
            double tien = double.Parse(txtTTien.Text);
            tien = tien - double.Parse(txtTienCoc.Text);
            txtTienTra.Text = tien.ToString("0.");
        }
        private void txtTongTien_TextChanged(object sender, EventArgs e)
        {
            tinh_TienHD();
        }

        private void txtTTien_TextChanged(object sender, EventArgs e)
        {
            tinh_TienTra();
        }

        private void txtChietKhau_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(txtChietKhau.Text) > 100)
                {
                    MessageBox.Show("Vui lòng nhập chiết khấu không lớn hơn 100!");
                    txtChietKhau.Text = "0";
                }
            }
            catch
            {
                // dung bat loi khi chiet khau la ""
            }
            tinh_TienHD();
        }

        #endregion

        private void btnThemHang_Click(object sender, EventArgs e)
        {
            if (validata())
            {
                //masp,tensp, size, mau, sldat, dongiadat
                if(kiemTraTrungHang(cbbTenHang.SelectedValue.ToString(), cbbTenHang.Text, int.Parse(cbbSize.Text),cbbMau.Text, int.Parse(txtsoluong.Text), decimal.Parse(txtDonGia.Text)))
                {
                    hienThi_dgv();
                    //dgvBanHang.Rows.Add();

                    // cập nhật số lượng trong kho
                    //msp, size, mau, slban, slcon
                    capNhatSoLuong(cbbTenHang.SelectedValue.ToString(), int.Parse(cbbSize.Text), cbbMau.Text, int.Parse(txtsoluong.Text), int.Parse(txtSLcon.Text));

                    // cap nhat tongTien
                    tienSanPham(decimal.Parse(txtthanhtien.Text));
                    txtsoluong.Text = "";                    
                }
                
            }
        }

        private void capNhatSoLuong(String msp, int size, String mau, int slBan, int slCon)
        {
            try
            {
                SoLuongCon sl_capnhat = (from s in db.SoLuongCons
                                         where s.MaSp == msp
                                         where s.Size == size
                                         where s.Mau == mau
                                         select s).SingleOrDefault();
                sl_capnhat.Slcon = slCon - slBan;
                txtSLcon.Text = sl_capnhat.Slcon.ToString();
                db.SaveChanges();
                txtsoluong.Text = "";
            }
            catch
            {

            }
        }


        // kiểm tra hàng đã có trong dsach sản phẩm mua chưa.
        // dsach sản phẩm mua nằm trong table DonHangMua_Nhap
        private bool kiemTraTrungHang(String maSP, String tenSP, int size, String mau, int slDat, decimal dgDat)
        {

            DonhangmuaNhap chiTiet = new DonhangmuaNhap();
            chiTiet.MaSp = maSP;
            chiTiet.TenSp = tenSP;
            chiTiet.Size = size;
            chiTiet.Mau = mau;
            chiTiet.SoLuongMua = slDat;
            chiTiet.DonGiaMua = dgDat;
            if (!db.DonhangmuaNhaps.Contains(chiTiet))
            {
                db.DonhangmuaNhaps.Add(chiTiet);
                db.SaveChanges();
                return true;
            }
            else
            {
                MessageBox.Show("Mặt hàng này đã tồn tại !!!", "Lưu ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }            
        } 


        // xoá hoaDon_nháp để cập nhật lại số lượng sản phẩm trong kho
        // khi thực hiện thoát form, đóng form đột ngột / huỷ hoá đơn
        private void xoaHD_Nhap()
        {
            var sp = (from s in db.DonhangmuaNhaps
                     select s).ToList();
            foreach (var clean in sp)
            {
                var sl_capnhat = (from s in db.SoLuongCons
                          where s.MaSp == clean.MaSp
                          where s.Size == clean.Size
                          where s.Mau == clean.Mau
                          select s).SingleOrDefault();

               if(sl_capnhat!=null)
                    capNhatSoLuong(clean.MaSp, clean.Size, clean.Mau, -clean.SoLuongMua, sl_capnhat.Slcon);
                db.DonhangmuaNhaps.Remove(clean);
            }
                
            db.SaveChanges();           

        }
       
        private void frmTaoHDBan_FormClosed(object sender, FormClosedEventArgs e)
        {
            // đóng form đột ngột cập nhật lại số lượng sản phẩm đã thêm_nháp
            xoaHD_Nhap();
 
        }


        private void hienThi_dgv()
        {
            dgvBanHang.DataSource = (from s in db.DonhangmuaNhaps
                                     select new
                                     {
                                         s.MaSp,
                                         s.TenSp,
                                         s.Size,
                                         s.Mau,
                                         s.SoLuongMua,
                                         s.DonGiaMua
                                     }).ToList();
        }
        // Xoá hàng      
        private void btnXoaHang_Click(object sender, EventArgs e)
        {
            if (cbbTenHang.Enabled == false)
            {
                String msp = cbbTenHang.SelectedValue.ToString();
                int size = int.Parse(cbbSize.Text);
                String mau = cbbMau.Text;

                // xoa san pham trong donhang_Nhap
                var sp_xoa = (from s in db.DonhangmuaNhaps
                              where s.MaSp == msp
                              where s.Size == size
                              where s.Mau == mau
                              select s).FirstOrDefault();

                // lay san pham trong bang soLuongCons
                SoLuongCon sp_con = (from s in db.SoLuongCons
                                 where s.MaSp == msp
                                 where s.Size == size
                                 where s.Mau == mau
                                 select s).SingleOrDefault();
                capNhatSoLuong(msp, size, mau, -sp_xoa.SoLuongMua, sp_con.Slcon);
                
                // cap nhat tien San Pham
                tienSanPham(-(sp_xoa.DonGiaMua * sp_xoa.SoLuongMua));

                db.DonhangmuaNhaps.Remove(sp_xoa);
                db.SaveChanges();                
                hienThi_dgv();
            }
            else
                MessageBox.Show("Bạn cần chọn hàng từ danh sách mua");
           
        }                

        private void dgvBanHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int row = e.RowIndex;
                cbbTenHang.Text = dgvBanHang.Rows[row].Cells[1].Value.ToString();
                cbbSize.Text = dgvBanHang.Rows[row].Cells[2].Value.ToString();
                cbbMau.Text = dgvBanHang.Rows[row].Cells[3].Value.ToString();
                txtDonGia.Text = dgvBanHang.Rows[row].Cells[5].Value.ToString().Replace(".0000", String.Empty);
                txtsoluong.Text = dgvBanHang.Rows[row].Cells[4].Value.ToString();
                cbbTenHang.Enabled = false;
                cbbSize.Enabled = false;
                cbbMau.Enabled = false;
                txtsoluong.Enabled = false;
            }
            catch
            {
                // trường hợp D=-1
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult=MessageBox.Show("Bạn có chắc muốn huỷ hoá đơn này??", "Lưu ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                xoaHD_Nhap();
                this.Close();
            }

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (dgvBanHang.Rows.Count <1 )
            {
                MessageBox.Show("Chưa có sản phẩm nào!!!");
            }
            else
            {
                if (kt_KhachHang())
                {
                    DialogResult dialogResult = MessageBox.Show("Vui lòng xem lại chi tiết hoá đơn\n Bạn chấp nhận thanh toán?", "Lưu ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.Yes)
                    {
                        // tao hoa don ban
                        Hoadonban hdb = new Hoadonban();
                        // hdb.SoHd = int.Parse(txtMahoadon.Text);
                        hdb.Sdt = txtsodienthoai.Text;
                        hdb.MaNql = cbbNguoiLap.SelectedValue.ToString();
                        hdb.NgayBan = dtpngay.Value;

                        if (txtChietKhau.Text == "")
                            txtChietKhau.Text = "0";
                        hdb.ChietKhau = double.Parse(txtChietKhau.Text);
                        hdb.TinhTrangDoiTra = "chưa đổi trả";

                        // them khach hang theo so dien thoai
                        // neu da ton tai thi cong vao tong tien
                        // neu chua ton tai thi tao moi
                        themKH();

                        db.Hoadonbans.Add(hdb);
                        db.SaveChanges();

                        // chi tiet hoa don
                        var sphams = (from s in db.DonhangmuaNhaps select s).ToList();
                        foreach (DonhangmuaNhap item in sphams)
                        {
                            Chitiethoadon ct = new Chitiethoadon();
                            ct.SoHd = int.Parse(txtMahoadon.Text);
                            ct.MaSp = item.MaSp;
                            ct.Size = item.Size;
                            ct.Mau = item.Mau;                            
                            ct.SoLuongBan = item.SoLuongMua;
                            ct.GiaBan = item.DonGiaMua;
                            ct.ThanhTien = item.DonGiaMua * item.SoLuongMua;
                            db.Chitiethoadons.Add(ct);
                            db.SaveChanges();

                            
                        }

                        // xoa bang muahang_Nhap
                        var sp_ttoan = from s in db.DonhangmuaNhaps
                                       select s;
                        foreach (DonhangmuaNhap xoa in sp_ttoan)
                            db.DonhangmuaNhaps.Remove(xoa);

                        db.SaveChanges();
                        if (check_dondat == 1)
                        {
                            Donkhdat don = (from s in db.Donkhdats
                                            where s.SoHd == shd_dat
                                            select s).FirstOrDefault();
                            don.TinhTrang = "Đã xử lý";
                            db.SaveChanges();
                        }

                        // muon in pdf khong
                        DialogResult diaRes = MessageBox.Show("Bạn có muốn in hoá đơn không?", "Lưu ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if(diaRes == DialogResult.Yes)
                        {
                            frmChiTietHoaDon newForm = new frmChiTietHoaDon(int.Parse(txtMahoadon.Text));
                            newForm.xuat_PDF();
                        }                        
                        this.Close();
                    }
                }
            }
        }
        private void themKH()
        {
            var kh = (from s in db.Khachhangs
                     where s.Sdt == txtsodienthoai.Text
                     select s).FirstOrDefault();
            if (kh == null)
            {
                Khachhang kh_moi = new Khachhang();
                kh_moi.Sdt = txtsodienthoai.Text;
                kh_moi.TenKh = txthoten.Text;
                kh_moi.DiaChiKh = txtdiachi.Text;
                kh_moi.TongTien = decimal.Parse(txtTTien.Text);
                db.Khachhangs.Add(kh_moi);
            }
            else // neu khach hang ton tai theo SDT, nhung lai khac dia chi va hoTen
            {
                kh.DiaChiKh = txtdiachi.Text;
                kh.TenKh = txthoten.Text;
                kh.TongTien += decimal.Parse(txtTTien.Text);
            }
            db.SaveChanges();

        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            lamMoi();
        }

        private void lamMoi()
        {
            foreach (Control c in groupBox2.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
            }
            cbbTenHang.Text = "";
            cbbTenHang.Enabled = true;
            cbbSize.Enabled = true;
            cbbMau.Enabled = true;
            txtsoluong.Enabled = true;            
            cbbSize.SelectedIndex = -1;
            cbbMau.SelectedIndex = -1;

            var giaBan = (from s in db.Sanphams
                          where s.MaSp == cbbTenHang.SelectedValue.ToString()
                          select s.GiaBan).FirstOrDefault();
            txtDonGia.Text = giaBan.ToString("0.");

        }

        private void btnTimKhach_Click(object sender, EventArgs e)
        {            
            frmKhachHangCu frm = new frmKhachHangCu();
            frm.ShowDialog();
            txtsodienthoai.Text = frm.getSDT;
            txthoten.Text = (from s in db.Khachhangs
                             where s.Sdt == (txtsodienthoai.Text)
                             select s.TenKh).FirstOrDefault();
            txtdiachi.Text = (from s in db.Khachhangs
                              where s.Sdt == (txtsodienthoai.Text)
                              select s.DiaChiKh).FirstOrDefault();
        }

        bool flag = true;
        int shd_dat;
        int check_dondat = 0; // kiểm tra có đặt đơn hàng không?
        private void btnDonDat_Click(object sender, EventArgs e)
        {
            if (dgvBanHang.Rows.Count > 0)
                flag = false;
            if (flag)
            {
                xoaHD_Nhap();                           
                txtTongTien.Text = "0";
                frmChonHDDat frm = new frmChonHDDat();
                frm.ShowDialog();
                shd_dat = frm.getSHD;
                if (shd_dat > 0)
                {                                        
                    var chitiet_hang = (from s in db.Chitietkhdats
                                        where s.SoHd == shd_dat
                                        select s).ToList();
                    int kt_hang = 1;
                    foreach(var item in chitiet_hang)
                    {
                        var size_kho = (from s in db.SoLuongCons
                                        where s.MaSp == item.MaSp
                                        where s.Mau == item.Mau
                                        select s.Size).ToList();
                        var mau_kho = (from s in db.SoLuongCons
                                        where s.MaSp == item.MaSp
                                        where s.Size == item.Size
                                        select s.Mau).ToList();
                        if((!(size_kho.Contains(item.Size)))&& (!(mau_kho.Contains(item.Mau))))
                        {
                            MessageBox.Show("Hàng chưa sẵn để bán!", "Lưu ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            kt_hang = 0;
                            return;
                        }
                    }
                    if (kt_hang==1)
                    {
                        flag = false;
                        var don_dat = (from s in db.Donkhdats
                                       where s.SoHd == shd_dat
                                       select s).FirstOrDefault();
                        txtsodienthoai.Text = don_dat.Sdt;
                        txthoten.Text = don_dat.TenKh;
                        txtdiachi.Text = don_dat.DiaChiKh;
                        txtTienCoc.Text = don_dat.TienCoc.ToString("0.");

                        int i = 0;

                        foreach (var item in chitiet_hang)
                        {
                            //masp,tensp, size, mau, sldat, dongiadat
                            // luu vao donmua_nhap
                            if (kiemTraTrungHang(item.MaSp, item.TenSp, item.Size, item.Mau, item.SoLuongDat, item.DonGiaNhap))
                            {
                                // them vao dgv
                                dgvBanHang.Rows.Add();
                                dgvBanHang.Rows[i].Cells[0].Value = item.MaSp.ToString();
                                dgvBanHang.Rows[i].Cells[1].Value = item.TenSp.ToString();
                                dgvBanHang.Rows[i].Cells[2].Value = item.Size.ToString();
                                dgvBanHang.Rows[i].Cells[3].Value = item.Mau.ToString();
                                dgvBanHang.Rows[i].Cells[4].Value = item.SoLuongDat.ToString();
                                dgvBanHang.Rows[i].Cells[5].Value = item.DonGiaNhap.ToString();
                                tienSanPham(item.DonGiaNhap * item.SoLuongDat); //cap nhat tongTienSP
                                txtsoluong.Text = "";
                                i++;

                                // cập nhật số lượng trong kho
                                //msp, size, mau, slban, slcon
                                // lay so luong con cua sanpham
                                int sl_con = (from s in db.SoLuongCons
                                              where s.MaSp == item.MaSp
                                              where s.Size == item.Size
                                              where s.Mau == item.Mau
                                              select s.Slcon).FirstOrDefault();

                                capNhatSoLuong(item.MaSp, item.Size, item.Mau, item.SoLuongDat, sl_con);
                            }
                        }
                        hienThi_dgv();
                        check_dondat = 1; // đánh dấu là đơn hàng đặt 
                    }

                    else
                    {
                        this.Close();
                    }

                }

 
            }

            else
            {
                DialogResult diaRes = MessageBox.Show("Bạn muốn huỷ hoá đơn này?", "Lưu ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (diaRes == DialogResult.Yes)
                {
                    //xoaHD_Nhap();
                    //check_dondat = 0;
                   // Application.Restart();
                   // Environment.Exit(0);
                    //dgvBanHang.Rows.Clear();
                    //dgvBanHang.Refresh();

                    xoaHD_Nhap();
                    this.Close();
                }

            }
            
        }        
    }
}
