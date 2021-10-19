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
using System.Reflection;
using System.IO;
using Aspose.Words;
using Aspose.Words.Tables;
//using System.Threading.Tasks;
using System.Diagnostics;
using iTextSharp.text;
using Document = iTextSharp.text.Document;
using iTextSharp.text.pdf;
using Paragraph = iTextSharp.text.Paragraph;

namespace StoreApp.QuanLySanPham
{
    public partial class DoiTra : Form
    {
        String sdt, hoTen, diaChi, shd;
        Document doc;
        StroredUserData UserData = new StroredUserData();
        List<Phieudoitra> sanphams = new List<Phieudoitra>();
        decimal thanhtien;
        QuanLyBanGiayContext db = new QuanLyBanGiayContext();
        private void DoiTra_Load(object sender, EventArgs e)
        {
            //ma hoa don
                  txt_pdt.Text = ((from s in db.Phieudoitras select s.SoPhieu).Max() + 1).ToString();
            //người quản lí
            var kq = from s in db.Hoadonbans
                     where s.SoHd ==Convert.ToInt32(shd)
                     select s.MaNql;
            string manql = kq.ToList().FirstOrDefault();
            var kq2 = from s in db.Nguoiquanlies
                      where s.MaNql == manql
                      select s.TenNql;
            txtnl.Text = kq2.ToList().FirstOrDefault();
            // sản phẩm đã mua
            var kq4 = from s in db.Hoadonbans
                     where s.SoHd == Convert.ToInt32(shd)
                     select s.SoHd;
            string sohdon = kq4.ToList().FirstOrDefault().ToString();
            var kq3 = from s in db.Chitiethoadons
                      where s.SoHd == Convert.ToInt32(shd)
                      select new
                      {
                          s.MaSp,
                          s.MaSpNavigation.TenSp,
                          s.Size,
                          s.Mau,
                          s.SoLuongBan,
                          s.GiaBan,
                          s.ThanhTien
                      };
            data_Tra.DataSource = kq3.ToList();
            // tính tổng tiền khách đã trả
            for (int i = 0; i < data_Tra.Rows.Count; i++)
            {
                thanhtien += Convert.ToDecimal(data_Tra.Rows[i].Cells[6].Value);
            }
            txt_TienKhachTra.Text = thanhtien.ToString();
            // hien thi danh sach san pham
            cbbTenHang.DataSource = db.Sanphams.ToList();
            cbbTenHang.DisplayMember = "TenSP";
            cbbTenHang.ValueMember = "MaSP";

            xoaHD_Nhap();
            thongTin();
        }
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

                if (sl_capnhat != null)
                    capNhatSoLuong(clean.MaSp, clean.Size, clean.Mau, -clean.SoLuongMua, sl_capnhat.Slcon);
                db.DonhangmuaNhaps.Remove(clean);
            }

            db.SaveChanges();


        }
        // lấy từ bảng SoLuongCons đưa các thông tin về size, giá bán, màu slCon theo tên SPham
        private void thongTin()
        {
            // danh sach san phẩm
            var soLuong = from s in db.SoLuongCons
                          where s.MaSp == cbbTenHang.SelectedValue.ToString()
                          select s;

            // hiện size            
            combo_Size.DataSource = (from m in soLuong select m.Size).Distinct().ToList();


            // hiện Mau
            cb_mau.DataSource = (from m in soLuong select m.Mau).Distinct().ToList();

            //giá bán
            var giaBan = (from s in db.Sanphams
                          where s.MaSp == cbbTenHang.SelectedValue.ToString()
                          select s.GiaBan).FirstOrDefault();
            txtDonGia.Text = giaBan.ToString("0.");

            txtsoluong.Text = "";

            capnhat_SL();

        }
        private void capnhat_SL()
        {
            try
            {
                var soLuong = (from s in db.SoLuongCons
                               where s.MaSp == cbbTenHang.SelectedValue.ToString()
                               where s.Size == int.Parse(combo_Size.SelectedValue.ToString())
                               where s.Mau == cb_mau.SelectedValue.ToString()
                               select s.Slcon).FirstOrDefault();
                txtSLcon.Text = soLuong.ToString();
            }
            catch
            {

            }
        }
        private void capNhatSoLuongTra(string msp, int size, String mau, int sldoi)
        {
            SoLuongCon sl_capnhat = (from s in db.SoLuongCons
                                     where s.MaSp == msp
                                     where s.Size == size
                                     where s.Mau == mau
                                     select s).SingleOrDefault();
            sl_capnhat.Slcon += sldoi;
            db.SaveChanges();
        }
        //
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
        // Kiểm tra sp nhập vào
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
        //
        private void hienThi_dgv()
        {
            data_SPdoi.DataSource = (from s in db.DonhangmuaNhaps
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
        private void but_Mua_Click(object sender, EventArgs e)
        {
            if (ValidData())
            {
                //masp,tensp, size, mau, sldat, dongiadat
                if (kiemTraTrungHang(cbbTenHang.SelectedValue.ToString(), cbbTenHang.Text, int.Parse(combo_Size.Text), cb_mau.Text, int.Parse(txtsoluong.Text), decimal.Parse(txtDonGia.Text)))
                {
                    hienThi_dgv();
                    //dgvBanHang.Rows.Add();

                    // cập nhật số lượng trong kho
                    //msp, size, mau, slban, slcon
                    capNhatSoLuong(cbbTenHang.SelectedValue.ToString(), int.Parse(combo_Size.Text), cb_mau.Text, int.Parse(txtsoluong.Text), int.Parse(txtSLcon.Text));

                    // cap nhat thanh tien
                    decimal tien = decimal.Parse(txt_TongTien.Text);
                    tien += decimal.Parse(txtthanhtien.Text);
                    txt_TongTien.Text = tien.ToString();
                     txtsoluong.Text = "";
                    thanhTien();
                   
                }

            }
            
        }
        private void thanhTien()
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
                tien = decimal.Parse(txt_TongTien.Text) * (1 - (decimal.Parse(ck) / 100));
                txtTTien.Text = tien.ToString();
                decimal phaitra = decimal.Parse(txt_TienKhachPhaitrathem.Text);
                phaitra = decimal.Parse(txtTTien.Text) - decimal.Parse(txt_TienKhachTra.Text);
                txt_TienKhachPhaitrathem.Text = phaitra.ToString();
            }
            catch
            {
            }

        }

        private void cbbTenHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            thongTin();
        }

        private void combo_Size_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtsoluong.Text = "";
            capnhat_SL();
        }

        private void data_SPdoi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
            thanhTien();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void txt_TienKhachTra_TextChanged(object sender, EventArgs e)
        {

        }

        private void but_Inhoadon_Click(object sender, EventArgs e)
        {
            var hddoi = (from s in db.Hoadonbans where s.SoHd == Convert.ToInt32(shd) select s).ToList();
            foreach (Hoadonban item in hddoi)
            {
                item.TinhTrangDoiTra = "đã đổi trả";
            }

            //chi tiet hoa don
            var sphams = (from s in db.ChitietdathangNhaps select s).ToList();

            // Lan
            foreach (ChitietdathangNhap item in sphams)
            {
                Phieudoitra pdt = new Phieudoitra();

                pdt.SoHd = Convert.ToInt32(shd);
                pdt.MaSpmoi = item.MaSp;
                pdt.TenSpmoi = item.TenSp;
                pdt.Size = item.Size;
                pdt.Mau = item.Mau;
                pdt.DonGia = item.DonGiaDat;
                pdt.SoLuong = item.SoLuongDat;
                pdt.ThanhTien = item.ThanhTien;
                db.Phieudoitras.Add(pdt);
                db.SaveChanges();

            }

            db.SaveChanges();

            // cap nhat so luong doi tra
            string massp = "";
            int sizze = 0;
            int soluongdoi = 0;
            String mausp = "";

            for (int i = 0; i < data_Tra.Rows.Count; i++)
            {
                sizze = Convert.ToInt32(data_Tra.Rows[i].Cells[2].Value.ToString());
                soluongdoi = Convert.ToInt32(data_Tra.Rows[i].Cells[4].Value.ToString());
                massp = data_Tra.Rows[i].Cells[0].Value.ToString();
                mausp = data_Tra.Rows[i].Cells[3].Value.ToString();
                //txt_thu.Text = massp;
                capNhatSoLuongTra(massp, sizze,mausp, soluongdoi);
            }

          

            // xuất file pdf ---------------------------------------------------
            String filename = "HD" + txt_pdt.Text;
            var savefile = new SaveFileDialog();
            savefile.FileName = filename;
            savefile.DefaultExt = ".pdf";
            if (savefile.ShowDialog() == DialogResult.OK)
            { // set up để thêm dữ liệu
                Document document = new Document(PageSize.A4, 10f, 20f, 20f, 20f);
                Stream stream = new FileStream(savefile.FileName, FileMode.Create);
                PdfWriter.GetInstance(document, stream);
                document.Open();


                PdfPTable table = new PdfPTable(2);
                float[] columnsWidth = { 1, 1 };
                table.SetWidths(columnsWidth);
                table.DefaultCell.BorderWidth = 0;
                table.DefaultCell.Padding = 10;
                table.WidthPercentage = 100;
                table.HorizontalAlignment = Element.ALIGN_CENTER;
                // font chữ
                string path = Path.Combine(Path.GetFullPath(@"..\..\..\"), "Resources") + @"\font.ttf";
                BaseFont baseFont = BaseFont.CreateFont(path, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                //Font font = new Font("Times New Roman", 12.0f);
                //BaseFont baseFont = BaseFont.CreateFont(BaseFont.TIMES_BOLD, BaseFont.CP1252, BaseFont.EMBEDDED);

                iTextSharp.text.Font font = new iTextSharp.text.Font(baseFont, 10, iTextSharp.text.Font.NORMAL);
                iTextSharp.text.Font fontHearder = new iTextSharp.text.Font(baseFont, 15, iTextSharp.text.Font.BOLD);
                iTextSharp.text.Font fontBold = new iTextSharp.text.Font(baseFont, 10, iTextSharp.text.Font.BOLD);
                iTextSharp.text.Font font8 = new iTextSharp.text.Font(baseFont, 8, iTextSharp.text.Font.NORMAL);


                Phrase phrase2 = new Phrase("HÓA ĐƠN ĐỔI TRẢ", fontHearder);
                PdfPCell pdfPCell2 = new PdfPCell(phrase2);
                pdfPCell2.Border = iTextSharp.text.Rectangle.NO_BORDER;
                pdfPCell2.Colspan = 3;
                pdfPCell2.HorizontalAlignment = Element.ALIGN_CENTER;
                pdfPCell2.PaddingBottom = 25;
                pdfPCell2.PaddingLeft = 20;
                table.AddCell(pdfPCell2);


                // số hóa đơn
                Phrase phrase1 = new Phrase("Số phiếu: " + txt_pdt.Text, font);
                PdfPCell pdfPCell1 = new PdfPCell(phrase1);
                pdfPCell1.Border = iTextSharp.text.Rectangle.NO_BORDER;
                pdfPCell1.Colspan = 1;
                pdfPCell1.HorizontalAlignment = Element.ALIGN_LEFT;
                pdfPCell1.Padding = 10;
                table.AddCell(pdfPCell1);

                //chiết khấu

                Phrase phrase7 = new Phrase("Chiết khấu: " + txtChietKhau.Text, font);
                PdfPCell pdfPCell7 = new PdfPCell(phrase7);
                pdfPCell7.Border = iTextSharp.text.Rectangle.NO_BORDER;
                pdfPCell7.Colspan = 1;
                pdfPCell7.HorizontalAlignment = Element.ALIGN_RIGHT;
                pdfPCell7.Padding = 10;
                table.AddCell(pdfPCell7);

                // ngày lập
                Phrase phrase5 = new Phrase("\nNgày lập: " + dtpngay.Text, font);
                PdfPCell pdfPCell5 = new PdfPCell(phrase5);
                pdfPCell5.Border = iTextSharp.text.Rectangle.NO_BORDER;
                pdfPCell5.Colspan = 1;
                pdfPCell5.HorizontalAlignment = Element.ALIGN_LEFT;
                pdfPCell5.Padding = 10;
                table.AddCell(pdfPCell5);

                //thành tiền
                Phrase phrase10 = new Phrase("Thành tiền" +
                    ": " + txtTTien.Text, font);
                PdfPCell pdfPCell10 = new PdfPCell(phrase10);
                pdfPCell10.Border = iTextSharp.text.Rectangle.NO_BORDER;
                pdfPCell10.Colspan = 1;
                pdfPCell10.HorizontalAlignment = Element.ALIGN_RIGHT;
                pdfPCell10.Padding = 10;
                table.AddCell(pdfPCell10);

                //người lập
                Phrase phrase8 = new Phrase("Nhân viên bán hàng: " + txtnl.Text, font);
                PdfPCell pdfPCell8 = new PdfPCell(phrase8);
                pdfPCell8.Border = iTextSharp.text.Rectangle.NO_BORDER;
                pdfPCell8.Colspan = 1;
                pdfPCell8.HorizontalAlignment = Element.ALIGN_LEFT;
                pdfPCell8.Padding = 10;
                table.AddCell(pdfPCell8);                       

                //Tổng tiền khách phải trả
                Phrase phrase4 = new Phrase("Tổng tiền khách phải trả thêm: " + txt_TienKhachPhaitrathem.Text, font);
                PdfPCell pdfPCell4 = new PdfPCell(phrase4);
                pdfPCell4.Border = iTextSharp.text.Rectangle.NO_BORDER;
                pdfPCell4.Colspan = 1;
                pdfPCell4.HorizontalAlignment = Element.ALIGN_RIGHT;
                pdfPCell4.Padding = 10;
                table.AddCell(pdfPCell4);
                //table Sản phẩm
                PdfPTable ptable1 = new PdfPTable(data_SPdoi.Columns.Count);

                ptable1.DefaultCell.PaddingBottom = 10;
                ptable1.DefaultCell.PaddingTop = 10;
                ptable1.WidthPercentage = 90;
                ptable1.HorizontalAlignment = Element.ALIGN_CENTER;
                ptable1.DefaultCell.BorderWidth = 1;

                ////add
                ////
                foreach (DataGridViewColumn column in data_SPdoi.Columns)
                {
                    PdfPCell pdfPCell = new PdfPCell(new Phrase(column.HeaderText, fontBold));
                    pdfPCell.HorizontalAlignment = Element.ALIGN_CENTER;
                    pdfPCell.PaddingBottom = 2;
                    ptable1.AddCell(pdfPCell);
                }

                //// add cell
                foreach (DataGridViewRow viewRow in data_SPdoi.Rows)
                {
                    foreach (DataGridViewCell dcell in viewRow.Cells)
                    {
                        PdfPCell pCell = new PdfPCell(new Phrase(dcell.Value.ToString(), font));
                        pCell.HorizontalAlignment = Element.ALIGN_CENTER;
                        ptable1.AddCell(pCell);
                    }
                }

                Paragraph parablank = new Paragraph(" ", font);

                document.Add(table);
                document.Add(parablank);
                document.Add(ptable1);
                document.Add(parablank);

                document.Close();
                stream.Close();
                MessageBox.Show("In hóa đơn thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);


                try
                {
                    System.Diagnostics.Process.Start("explorer.exe", savefile.FileName); // XML NHẬP
                }
                catch (Exception)
                {
                    System.Diagnostics.Process.Start("msedge.exe", savefile.FileName);

                }
                
            }
        }//------------------------------------------------------------

          
        private void cb_mau_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtsoluong.Text = "";
            capnhat_SL();
        }
        private bool ValidData()
        {
            if (txtsoluong.Text == "")
            {
                errorProvider1.SetError(txtsoluong, "Bạn cần nhập số lượng");
                txtsoluong.Focus();
                return false;
            }
            return true;
        }
        private void txtsoluong_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtsoluong, "");
        }

        private void but_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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
                txtthanhtien.Text = (int.Parse(txtsoluong.Text) * decimal.Parse(txtDonGia.Text)).ToString("0.0000");
            }
            catch
            {

            }
        }

        public string manql { get; set; } // TRUYỀN THAM TRỊ GIỮA NHIỀU FORM

        public DoiTra( String shd)
        {
            InitializeComponent();
            this.shd = shd;          
        }
    }
}

