using StoreApp.Models;
using StoreApp.QuanLySanPham;
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
    public partial class frmChiTietHoaDon : Form
    {

        QuanLyBanGiayContext db = new QuanLyBanGiayContext();
        int shd;
        public frmChiTietHoaDon(int shd)
        {
            InitializeComponent();
            this.shd = shd;
        }


        public void hienThiChiTiet()
        {
            // thong tin hoa don
            txtSoHD.Text = shd.ToString();
            var hoaDonBan = (from s in db.Hoadonbans
                             where s.SoHd == shd
                             select s).FirstOrDefault();
            dtpngay.Value = hoaDonBan.NgayBan;

            txtNguoiLap.Text = (from s in db.Nguoiquanlies
                                where s.MaNql == hoaDonBan.MaNql
                                select s.TenNql).FirstOrDefault();

            // thong tin khach hang
            var kh = (from s in db.Khachhangs
                      where s.Sdt == hoaDonBan.Sdt
                      select s).FirstOrDefault();
            txtsdt.Text = kh.Sdt;
            txtTen.Text = kh.TenKh;
            txtDiaChi.Text = kh.DiaChiKh;

            //
            var sanPhams = (from s in db.Chitiethoadons
                            where s.SoHd == shd
                            select new
                            {
                                s.MaSp,
                                s.MaSpNavigation.TenSp,
                                s.Size,
                                s.Mau,
                                s.SoLuongBan,
                                s.GiaBan,
                            }).ToList();
            dgvhoadonchitiet.DataSource = sanPhams;

            // tinh tong tien
            decimal tien = 0;
            foreach (var s in sanPhams)
            {
                tien += (s.GiaBan) * (s.SoLuongBan);
            }
            txtTongTien.Text = tien.ToString("0.");

            // chiet khau
            txtChietKhau.Text = hoaDonBan.ChietKhau.ToString();

            //tien hoa don
            decimal tien_hd = (tien * (1 - decimal.Parse(txtChietKhau.Text) / 100));
            txtTTien.Text = tien_hd.ToString("0.");

        }

        private void frmChiTietHoaDon_Load(object sender, EventArgs e)
        {
            hienThiChiTiet();
        }
            
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXuatPDF_Click(object sender, EventArgs e)
        {
            xuat_PDF();
        }

        public void xuat_PDF()
        {
            hienThiChiTiet();
            var hoaDonBan = (from s in db.Hoadonbans
                             where s.SoHd == shd
                             select s).FirstOrDefault();
            String ngay_ban = hoaDonBan.NgayBan.ToString();

            String filename = "HD" + txtSoHD.Text;
            var savefile = new SaveFileDialog();
            savefile.FileName = filename;
            savefile.DefaultExt = ".pdf";
            if (savefile.ShowDialog() == DialogResult.OK)
            { // set up để thêm dữ liệu
                Document document = new Document(PageSize.A4, 10f, 20f, 20f, 20f);
                Stream stream = new FileStream(savefile.FileName, FileMode.Create);
                PdfWriter.GetInstance(document, stream);
                document.Open();

                PdfPTable table = new PdfPTable(3);
                float[] columnsWidth = { 1, 1, 1 };
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


                Phrase phrase2 = new Phrase("Chi tiết hóa đơn", fontHearder);
                PdfPCell pdfPCell2 = new PdfPCell(phrase2);
                pdfPCell2.Border = iTextSharp.text.Rectangle.NO_BORDER;
                pdfPCell2.Colspan = 3;
                pdfPCell2.HorizontalAlignment = Element.ALIGN_CENTER;
                pdfPCell2.PaddingBottom = 25;
                pdfPCell2.PaddingLeft = 20;
                table.AddCell(pdfPCell2);


                // số hóa đơn
                Phrase phrase1 = new Phrase("Số HD: " + txtSoHD.Text, font);
                PdfPCell pdfPCell1 = new PdfPCell(phrase1);
                pdfPCell1.Border = iTextSharp.text.Rectangle.NO_BORDER;
                pdfPCell1.Colspan = 1;
                pdfPCell1.HorizontalAlignment = Element.ALIGN_LEFT;
                pdfPCell1.Padding = 10;
                table.AddCell(pdfPCell1);
                //tên
                Phrase phrase3 = new Phrase("Tên khách hàng: " + txtTen.Text, font);
                PdfPCell pdfPCell3 = new PdfPCell(phrase3);
                pdfPCell3.Border = iTextSharp.text.Rectangle.NO_BORDER;
                pdfPCell3.Colspan = 1;
                pdfPCell3.HorizontalAlignment = Element.ALIGN_CENTER;
                pdfPCell3.Padding = 10;
                table.AddCell(pdfPCell3);


                //Tiền sản phẩm
                Phrase phrase4 = new Phrase("Tiền sản phẩm: " + txtTongTien.Text, font);
                PdfPCell pdfPCell4 = new PdfPCell(phrase4);
                pdfPCell4.Border = iTextSharp.text.Rectangle.NO_BORDER;
                pdfPCell4.Colspan = 1;
                pdfPCell4.HorizontalAlignment = Element.ALIGN_RIGHT;
                pdfPCell4.Padding = 10;
                table.AddCell(pdfPCell4);

                // ngày lập
                Phrase phrase5 = new Phrase("\nNgày lập: " + ngay_ban, font);
                PdfPCell pdfPCell5 = new PdfPCell(phrase5);
                pdfPCell5.Border = iTextSharp.text.Rectangle.NO_BORDER;
                pdfPCell5.Colspan = 1;
                pdfPCell5.HorizontalAlignment = Element.ALIGN_LEFT;
                pdfPCell5.Padding = 10;
                table.AddCell(pdfPCell5);
                //địa chỉ
                Phrase phrase6 = new Phrase("Địa chỉ: " + txtDiaChi.Text, font);
                PdfPCell pdfPCell6 = new PdfPCell(phrase6);
                pdfPCell6.Border = iTextSharp.text.Rectangle.NO_BORDER;
                pdfPCell6.Colspan = 1;
                pdfPCell6.Padding = 10;
                pdfPCell6.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(pdfPCell6);
                //chiết khấu

                Phrase phrase7 = new Phrase("Chiết khấu: " + txtChietKhau.Text, font);
                PdfPCell pdfPCell7 = new PdfPCell(phrase7);
                pdfPCell7.Border = iTextSharp.text.Rectangle.NO_BORDER;
                pdfPCell7.Colspan = 1;
                pdfPCell7.HorizontalAlignment = Element.ALIGN_RIGHT;
                pdfPCell7.Padding = 10;
                table.AddCell(pdfPCell7);
                //người lập

                Phrase phrase8 = new Phrase("Người lập: " + txtNguoiLap.Text, font);
                PdfPCell pdfPCell8 = new PdfPCell(phrase8);
                pdfPCell8.Border = iTextSharp.text.Rectangle.NO_BORDER;
                pdfPCell8.Colspan = 1;
                pdfPCell8.HorizontalAlignment = Element.ALIGN_LEFT;
                pdfPCell8.Padding = 10;
                table.AddCell(pdfPCell8);
                //sđt

                Phrase phrase9 = new Phrase("SĐT: " + txtsdt.Text, font);
                PdfPCell pdfPCell9 = new PdfPCell(phrase9);
                pdfPCell9.Border = iTextSharp.text.Rectangle.NO_BORDER;
                pdfPCell9.Colspan = 1;
                pdfPCell9.HorizontalAlignment = Element.ALIGN_CENTER;
                pdfPCell9.Padding = 10;
                table.AddCell(pdfPCell9);
                //thành tiền

                Phrase phrase10 = new Phrase("Tiền hoá đơn" +
                    ": " + txtTTien.Text, font);
                PdfPCell pdfPCell10 = new PdfPCell(phrase10);
                pdfPCell10.Border = iTextSharp.text.Rectangle.NO_BORDER;
                pdfPCell10.Colspan = 1;
                pdfPCell10.HorizontalAlignment = Element.ALIGN_RIGHT;
                pdfPCell10.Padding = 10;
                table.AddCell(pdfPCell10);
                //table Sản phẩm
                PdfPTable tableProduct = new PdfPTable(dgvhoadonchitiet.ColumnCount);
                tableProduct.DefaultCell.PaddingBottom = 10;
                tableProduct.DefaultCell.PaddingTop = 10;
                tableProduct.WidthPercentage = 90;
                tableProduct.HorizontalAlignment = Element.ALIGN_CENTER;
                tableProduct.DefaultCell.BorderWidth = 1;

                //add
                //
                foreach (DataGridViewColumn column in dgvhoadonchitiet.Columns)
                {
                    PdfPCell pdfPCell = new PdfPCell(new Phrase(column.HeaderText, fontBold));
                    pdfPCell.HorizontalAlignment = Element.ALIGN_CENTER;
                    pdfPCell.PaddingBottom = 2;
                    tableProduct.AddCell(pdfPCell);
                }

                // add cell
                foreach (DataGridViewRow row in dgvhoadonchitiet.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        PdfPCell pdfPCell = new PdfPCell(new Phrase(cell.Value.ToString(), font));
                        pdfPCell.HorizontalAlignment = Element.ALIGN_CENTER;
                        pdfPCell.PaddingBottom = 2;
                        tableProduct.AddCell(pdfPCell);
                    }
                }

                Paragraph parablank = new Paragraph(" ", font);

                document.Add(table);
                document.Add(parablank);
                document.Add(tableProduct);
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

        }

        private void dgvhoadonchitiet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
