using StoreApp.DAO;
using StoreApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using Aspose.Words;
using Aspose.Words.Tables;
using Document = Aspose.Words.Document;

namespace StoreApp.QuanLyKhoHang
{
    public partial class frChiTietDonNhap : Form
    {
        private ChiTietHoaDonNhapDAO chiTietHoaDonNhapDAO;
        private List<Chitiethoadonnhap> listNhap;
        private HoaDonNhapDao hoaDonNhapDao;
        private NhaCungCapDAO nhaCungCapDAO;
        private NguoiQuanLyDAO nguoiQuanLyDAO;
        decimal tongtien;
        string idnql;
        string idncc;
        string idhd;
        public frChiTietDonNhap(string sohd, string mancc, string manql)
        {
            idnql = manql;
            idncc = mancc;
            idhd = sohd;
            InitializeComponent();
            chiTietHoaDonNhapDAO = new ChiTietHoaDonNhapDAO();
            listNhap = new List<Chitiethoadonnhap>();
            nhaCungCapDAO = new NhaCungCapDAO();
            hoaDonNhapDao = new HoaDonNhapDao();
            nguoiQuanLyDAO = new NguoiQuanLyDAO();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frChiTietDonNhap_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                listNhap = chiTietHoaDonNhapDAO.layBangSoHoaDon(Int32.Parse(idhd));
                Hoadonnhap hoadon = hoaDonNhapDao.getById(Int32.Parse(idhd));
                //Hoadonnhap hoadon = hoaDonNhapDao.getById(cthoadon.SoHdn);
                Nhacungcap ncc = nhaCungCapDAO.getByID(hoadon.MaNcc);
                Nguoiquanly nql = nguoiQuanLyDAO.getByID(idnql);
                data_spnhap.Rows.Clear();
                foreach (Chitiethoadonnhap i in listNhap)
                {
                    data_spnhap.Rows.Add(i.MaSp, i.TenSp, i.Size,i.Mau, i.SoLuongNhap, i.DonGiaNhap, i.ThanhTien);
                    tongtien += i.ThanhTien;
                }
                txt_sohd.Text = hoadon.SoHdn.ToString();
                txt_nguoinhap.Text = nql.TenNql;
                txt_tenncc.Text = ncc.TenNcc;
                txt_sdt.Text = ncc.Sdtncc;
                txt_diachi.Text = ncc.DiaChiNcc;
                txt_ngaynhap.Text = hoadon.NgayNhap.ToString();
                label.Text = tongtien.ToString();

            }
            catch
            {
                MessageBox.Show("err");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExportInvoice();
            this.Close();
        }
        private void ExportInvoice()
        {
            try
            {
                listNhap = chiTietHoaDonNhapDAO.layBangSoHoaDon(Int32.Parse(idhd));
                Hoadonnhap hoadon = hoaDonNhapDao.getById(Int32.Parse(idhd));
                Nhacungcap ncc = nhaCungCapDAO.getByID(hoadon.MaNcc);
                Nguoiquanly nql = nguoiQuanLyDAO.getByID(idnql);
                string dataDir = @"D:\store_app\StoreApp\StoreApp\InHoaDon\";
                string fileName = "ChiTietHoaDonNhap.docx";
                Document doc = new Document(dataDir + fileName);
                // thay thông tin hóa đơn
                doc.Range.Replace("[sohoadon]", txt_sohd.Text);
                doc.Range.Replace("[ngaynhap]", txt_ngaynhap.Text);
                doc.Range.Replace("[tennhanvien]", txt_nguoinhap.Text);
                doc.Range.Replace("[tennhacungcap]", txt_tenncc.Text);
                doc.Range.Replace("[sdt]", txt_sdt.Text);
                doc.Range.Replace("[diachi]", txt_diachi.Text);
                // chèn dữ liệu vào bảng

                Table table = (Table)doc.GetChild(NodeType.Table, 0, true);

                foreach (Chitiethoadonnhap i in listNhap)
                {
                    Row lastRow = (Row)table.LastRow;
                    lastRow.Cells[0].LastParagraph.AppendChild(new Run(doc, i.MaSp + ControlChar.LineBreak));
                    lastRow.Cells[1].FirstParagraph.AppendChild(new Run(doc, i.TenSp + ControlChar.LineBreak));
                    lastRow.Cells[2].FirstParagraph.AppendChild(new Run(doc, i.Size + ControlChar.LineBreak));
                    lastRow.Cells[3].FirstParagraph.AppendChild(new Run(doc, i.Mau + ControlChar.LineBreak));
                    lastRow.Cells[4].FirstParagraph.AppendChild(new Run(doc, i.SoLuongNhap + ControlChar.LineBreak));
                    lastRow.Cells[5].FirstParagraph.AppendChild(new Run(doc, i.DonGiaNhap + ControlChar.LineBreak));
                    lastRow.Cells[6].FirstParagraph.AppendChild(new Run(doc, i.ThanhTien + ControlChar.LineBreak));
                   
                }
                doc.Range.Replace("[tongphaitra]", label.Text);
                string invoiceId = "HoaDonNhap_" + txt_sohd.Text + ".pdf";
                doc.Save(dataDir + invoiceId);
                MessageBox.Show(dataDir + invoiceId);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {

            }
        }
    }

}

