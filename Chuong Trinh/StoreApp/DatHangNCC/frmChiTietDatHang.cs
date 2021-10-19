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
using Aspose.Words;
using Aspose.Words.Tables;
using System.Diagnostics;
namespace StoreApp.DatHangNCC
{
    public partial class frmChiTietDatHang : Form
    {
        QuanLyBanGiayContext db = new QuanLyBanGiayContext();
        List<Chitietdathang> sanphams = new List<Chitietdathang>();

        int shd;
        public frmChiTietDatHang(string shd)
        {
           
            this.shd = Convert.ToInt32(shd);
            InitializeComponent();
        }

        private void frmChiTietNhapHang_Load(object sender, EventArgs e)
        {
            txtSohdn.Text = shd + "";
            var kq = from n in db.Dathangnccs
                     where n.MaHddatHang == shd
                     select n.NgayThang;
            dtpNgayNhap.Value = kq.ToList().FirstOrDefault();

            var kq2 = from n in db.Dathangnccs
                      where n.MaHddatHang == shd
                      select n.MaNcc;
            string mancc = kq2.ToList().FirstOrDefault();

            var kq3 = from n in db.Nhacungcaps
                      where n.MaNcc == mancc
                      select n.TenNcc;
            txtTenncc.Text = kq3.ToList().FirstOrDefault();
            var kq4 = from n in db.Nhacungcaps
                      where n.MaNcc == mancc
                      select n.DiaChiNcc;
            txtdiachi.Text = kq4.ToList().FirstOrDefault();
            var kq5 = from n in db.Nhacungcaps
                      where n.MaNcc == mancc
                      select n.Sdtncc;
            txtsdt.Text = kq5.ToList().FirstOrDefault();
            var kq6 = from n in db.Dathangnccs
                      where n.MaHddatHang == shd
                      select n.NguoiLap;
            txtNguoiLap.Text = kq6.ToList().FirstOrDefault();
            var list = from p in db.Chitietdathangs
                       where p.MaHddatHang == shd
                       select new
                       {
                            p.MaSp,
                            p.TenSp,
                            p.Size,
                            p.Mau,
                            p.SoLuongDat,
                            p.DonGiaDat,
                            p.TienCoc,
                            p.ThanhTien
                       };
                   
            dgvChiTietHangNhap.DataSource = list.ToList();
            dgvChiTietHangNhap.Columns[0].HeaderText = "Mã sản phẩm";
            dgvChiTietHangNhap.Columns[1].HeaderText = "Tên sản phẩm";
            dgvChiTietHangNhap.Columns[2].HeaderText = "Size";
            dgvChiTietHangNhap.Columns[3].HeaderText = "Màu";
            dgvChiTietHangNhap.Columns[4].HeaderText = "Số lượng đặt";
            dgvChiTietHangNhap.Columns[5].HeaderText = "Đơn giá đặt ";
            dgvChiTietHangNhap.Columns[6].HeaderText = "Tiền cọc";
            dgvChiTietHangNhap.Columns[7].HeaderText = "Thành tiền";
            decimal tongtien = 0;
            decimal tiencoc = 0;
            foreach(var item in list)
            {
                tiencoc += item.TienCoc * Convert.ToDecimal(1.0);
                tongtien+=item.ThanhTien * Convert.ToDecimal(1.0);
            }
            lblTongTien.Text = ConvertToMoney(tongtien);
            lblTienCoc.Text = ConvertToMoney(tiencoc);
        }
        static string ConvertToMoney(decimal money)
        {
            return String.Format("{0:C01}", money).Replace("$", "").Replace(".0", "") + " VND";
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtTenncc_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtdiachi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtsdt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvChiTietHangNhap.RowCount; i++)
            {
                Chitietdathang chitiet = new Chitietdathang();

                string masp = dgvChiTietHangNhap.Rows[i].Cells[0].Value.ToString();
                int size = Convert.ToInt32(dgvChiTietHangNhap.Rows[i].Cells[2].Value.ToString());
                string mau = dgvChiTietHangNhap.Rows[i].Cells[3].Value.ToString();
                int sld = Convert.ToInt32(dgvChiTietHangNhap.Rows[i].Cells[4].Value.ToString());
                decimal thanhtien = Convert.ToDecimal(dgvChiTietHangNhap.Rows[i].Cells[7].Value.ToString());
                decimal tiencoc = Convert.ToDecimal(dgvChiTietHangNhap.Rows[i].Cells[6].Value.ToString());
                string tensp = dgvChiTietHangNhap.Rows[i].Cells[1].Value.ToString();
                decimal dongiadat = Convert.ToDecimal(dgvChiTietHangNhap.Rows[i].Cells[5].Value.ToString());


                chitiet.MaHddatHang = Convert.ToInt32(txtSohdn.Text);
                chitiet.SoLuongDat = sld;
                chitiet.ThanhTien = thanhtien;
                chitiet.Size = size;
                chitiet.Mau = mau;
                chitiet.MaSp = masp;
                chitiet.DonGiaDat = dongiadat;
                chitiet.TenSp = tensp;
                chitiet.TienCoc = tiencoc;
                sanphams.Add(chitiet);
            }
            ExportInvoice();
        }
        private void ExportInvoice()
        {
            try
            {
                string dataDir = @"D:\LTWindows\BaiTapLonStoreApp\StoreApp\StoreApp\InHoaDon\";
                string fileName = "ChiTietDatHangNCC.docx";
                Document doc = new Document(dataDir + fileName);
                // thay thông tin hóa đơn
                doc.Range.Replace("[sohoadon]", txtSohdn.Text);
                doc.Range.Replace("[ngaydat]", dtpNgayNhap.Value.ToString());
                doc.Range.Replace("[tenncc]", txtTenncc.Text);
                doc.Range.Replace("[sdt]", txtsdt.Text);
                doc.Range.Replace("[diachi]", txtdiachi.Text);
                doc.Range.Replace("[nguoilap]", txtNguoiLap.Text);
                

                // chèn dữ liệu vào bảng

                Table table = (Table)doc.GetChild(NodeType.Table, 0, true);

                foreach (var item in sanphams)
                {
                    Row lastRow = (Row)table.LastRow;
                    lastRow.Cells[0].LastParagraph.AppendChild(new Run(doc, item.MaSp + ControlChar.LineBreak));
                    lastRow.Cells[1].FirstParagraph.AppendChild(new Run(doc, item.TenSp + ControlChar.LineBreak));
                    lastRow.Cells[2].FirstParagraph.AppendChild(new Run(doc, item.Size.ToString() + ControlChar.LineBreak));
                    lastRow.Cells[3].FirstParagraph.AppendChild(new Run(doc, item.Mau.ToString() + ControlChar.LineBreak));
                    lastRow.Cells[4].FirstParagraph.AppendChild(new Run(doc, item.SoLuongDat.ToString() + ControlChar.LineBreak));
                    lastRow.Cells[5].FirstParagraph.AppendChild(new Run(doc, item.DonGiaDat.ToString("0") + ControlChar.LineBreak));
                    lastRow.Cells[6].FirstParagraph.AppendChild(new Run(doc, item.TienCoc.ToString("0") + ControlChar.LineBreak));
                    lastRow.Cells[7].FirstParagraph.AppendChild(new Run(doc, item.ThanhTien.ToString("0") + ControlChar.LineBreak));

                }
                doc.Range.Replace("[tongtien]", lblTongTien.Text);
                doc.Range.Replace("[tiencoc]", lblTienCoc.Text);

                string invoiceId = "HoaDonDat_" + txtSohdn.Text + ".pdf";
                doc.Save(dataDir + invoiceId);
                MessageBox.Show(dataDir + invoiceId);
                Process.Start("C:\\Program Files (x86)\\Microsoft\\Edge\\Application\\msedge.exe", $"{dataDir + invoiceId}");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {

            }
            
        }

        private void txtSohdn_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
