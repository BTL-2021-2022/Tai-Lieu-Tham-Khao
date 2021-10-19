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
using System.Reflection;
using Aspose.Words;
using Aspose.Words.Tables;
using System.Diagnostics;
namespace StoreApp.DatHangNCC
{
    public partial class frmDatHang : Form
    {
        QuanLyBanGiayContext db = new QuanLyBanGiayContext();
        List<Chitietdathang> sanphams = new List<Chitietdathang>();
        public frmDatHang()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void frmDatHang_Load(object sender, EventArgs e)
        {

            var q = from m in db.ChitietdathangNhaps
                    select m;
            //MessageBox.Show(q.ToString());
            foreach (var item in q)
            {
                db.ChitietdathangNhaps.Remove(item);

            }
            db.SaveChanges();

            var u = db.Dathangnccs.Select(p => p); // LẤY RA MÃ SỐ ĐƠN ĐẶT HÀNG
            txtsohd.Text = (u.Count() + 1).ToString(); 
            var p = db.Sanphams.Select(p => p.TenSp);
            cbboxTenSP.DataSource = p.ToList();
            
            var ncc = db.Nhacungcaps.Select(p => p);
            cbboxncc.DataSource = ncc.Select(p => p.TenNcc).ToList();
            txtNguoiLap.Text = Global.UserName;

        }
        private void cbboxncc_SelectedIndexChanged(object sender, EventArgs e)
        {
            var ncc = from n in db.Nhacungcaps
                      where n.TenNcc == cbboxncc.Text
                      select n;
            txtsdt.Text = ncc.Select(p => p.Sdtncc).ToList().FirstOrDefault();
            txtdiachi.Text = ncc.Select(p => p.DiaChiNcc).ToList().FirstOrDefault();
        }
        private void txtSLNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(cbbsize.Text) || string.IsNullOrWhiteSpace(txtDGnhap.Text)|| string.IsNullOrWhiteSpace(txtSLNhap.Text)|| string.IsNullOrWhiteSpace(txtTienCoc.Text)|| string.IsNullOrWhiteSpace(cbbMau.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu ");
            }
            else if (Convert.ToInt32(txtDGnhap.Text) <= 0 || Convert.ToInt32(txtSLNhap.Text) <= 0)
            {
                MessageBox.Show("Vui lòng nhập số lượng và đơn giá nhập lớn hơn 0");
            }
            else if (Convert.ToInt32(txtTienCoc.Text)>Convert.ToInt32(txtDGnhap.Text)* Convert.ToInt32(txtSLNhap.Text))
            {
                MessageBox.Show("Tiền cọc phải nhỏ hơn thành tiền");
            }
            else
            {
                ChitietdathangNhap dh = new ChitietdathangNhap();
                var masp = from p in db.Sanphams
                           where p.TenSp == cbboxTenSP.Text
                           select p.MaSp;
         
                dh.MaSp = masp.ToList().FirstOrDefault();  // LẤY RA MASP TỪ TÊN SP
                dh.Size = Convert.ToInt32(cbbsize.Text);
                dh.Mau = cbbMau.Text;
                dh.TenSp = cbboxTenSP.Text;         
                dh.DonGiaDat = Convert.ToInt32(txtDGnhap.Text);
                dh.SoLuongDat = Convert.ToInt32(txtSLNhap.Text);
                dh.TienCoc = Convert.ToInt32(txtTienCoc.Text);
                dh.ThanhTien = Convert.ToInt32(txtThanhTien.Text);
                // var check = mydb.GioHangs.FirstOrDefault(s => s.MaSP == id && s.SDT == sdt);
                var check = db.ChitietdathangNhaps.FirstOrDefault(p => p.Size == Convert.ToInt32(cbbsize.Text) && p.MaSp == masp.ToList().FirstOrDefault()&&p.Mau==cbbMau.Text);
                // KIỂM TRA TRÙNG HÀNG XEM HÀNG CÓ TRONG LIST DANH SÁCH HAY CHƯA/ CHƯA CÓ THÌ ADD
                if (check == null)
                {
                    db.ChitietdathangNhaps.Add(dh);
                    db.SaveChanges();
                    var kq = from p in db.ChitietdathangNhaps
                             select new { 
                                masp=p.MaSp,
                                size=p.Size,
                                mau=p.Mau,
                                tensp=p.TenSp,
                                sld=p.SoLuongDat,
                                dgd=p.DonGiaDat,
                                tc=p.TienCoc,
                                tt=p.ThanhTien
                             };
                    dataGridView1.DataSource = kq.ToList();
                    //dataGridView1.Columns[0].HeaderText = "Mã sản phẩm";
                    //dataGridView1.Columns[1].HeaderText = "Size";
                    //dataGridView1.Columns[2].HeaderText = "Tên sản phẩm";
                    //dataGridView1.Columns[3].HeaderText = "Số lượng";
                    //dataGridView1.Columns[4].HeaderText = "Đơn giá";
                    //dataGridView1.Columns[5].HeaderText = "Tiền cọc";
                    //dataGridView1.Columns[6].HeaderText = "Thành tiền";
                    
                }
                else
                {
                    MessageBox.Show("Trùng hàng");
                }
                decimal tongtien = 0;
                decimal tiencoc = 0;
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    tongtien = tongtien + Convert.ToDecimal(dataGridView1.Rows[i].Cells[7].Value.ToString());
                    tiencoc=tiencoc+ Convert.ToDecimal(dataGridView1.Rows[i].Cells[6].Value.ToString());
                }
                lblTongTien.Text = ConvertToMoney(tongtien);
                lblTienCoc.Text = ConvertToMoney(tiencoc);

            }

        }
        static string ConvertToMoney(decimal money)
        {
            return String.Format("{0:C01}", money).Replace("$", "").Replace(".0", "") + " VND";
        }
        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            var masp = from p in db.Sanphams
                       where p.TenSp == cbboxTenSP.Text
                       select p.MaSp;
            //MessageBox.Show(masp.ToList().FirstOrDefault());
            string MaSp = masp.ToList().FirstOrDefault();
            int size = Convert.ToInt32(cbbsize.Text);

            var check = db.ChitietdathangNhaps.FirstOrDefault(p => p.Size == size && p.MaSp == MaSp&&p.Mau==cbbMau.Text);
            if (check != null)
            {
                db.ChitietdathangNhaps.Remove(check);
                db.SaveChanges();
                var kq = from p in db.ChitietdathangNhaps
                         select new {
                             masp = p.MaSp,
                             size = p.Size,
                             mau=p.Mau,
                             tensp = p.TenSp,
                             sld = p.SoLuongDat,
                             dgd = p.DonGiaDat,
                             tc = p.TienCoc,
                             tt = p.ThanhTien
                         };
                dataGridView1.DataSource = kq.ToList();
                //dataGridView1.Columns[0].HeaderText = "Mã sản phẩm";
                //dataGridView1.Columns[1].HeaderText = "Size";
                //dataGridView1.Columns[2].HeaderText = "Tên sản phẩm";
                //dataGridView1.Columns[3].HeaderText = "Số lượng";
                //dataGridView1.Columns[4].HeaderText = "Đơn giá";
                //dataGridView1.Columns[5].HeaderText = "Tiền cọc";
                //dataGridView1.Columns[6].HeaderText = "Thành tiền";
            }
            decimal tongtien = 0;
            decimal tiencoc = 0;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                tongtien = tongtien + Convert.ToDecimal(dataGridView1.Rows[i].Cells[7].Value.ToString());
                tiencoc = tiencoc + Convert.ToDecimal(dataGridView1.Rows[i].Cells[6].Value.ToString());
            }
            lblTongTien.Text = ConvertToMoney(tongtien);
            lblTienCoc.Text = ConvertToMoney(tiencoc);

        }

        private void cbboxTenSP_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void cbnguoilap_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbbsize_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtDGnhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtSLNhap_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtThanhTien.Text = Convert.ToInt32(txtDGnhap.Text) * Convert.ToInt32(txtSLNhap.Text) + "";

            }
            catch (Exception)
            {
                txtThanhTien.Text = "NULL";
            }
        }

        private void txtDGnhap_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtThanhTien.Text = Convert.ToInt32(txtDGnhap.Text) * Convert.ToInt32(txtSLNhap.Text) + "";

            }
            catch (Exception)
            {

                txtThanhTien.Text = "NULL";
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có chắc chắn muốn thoát khỏi đơn đặt hàng này", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (kq.Equals(DialogResult.Yes))
            {
                this.Close();

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int d = e.RowIndex;
                cbboxTenSP.Text = dataGridView1.Rows[d].Cells[3].Value.ToString();
                cbbsize.Text = dataGridView1.Rows[d].Cells[1].Value.ToString();
                cbbMau.Text = dataGridView1.Rows[d].Cells[2].Value.ToString();
            }
            catch (Exception)
            {


            }
        }

        private void frmDatHang_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void btnXN_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount < 1)
            {
                MessageBox.Show("Số lượng bản ghi phải lơn hơn 0!");

            }
            else
            {
                DialogResult kq1 = MessageBox.Show("Xác nhận đặt hàng?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (kq1.Equals(DialogResult.Yes))
                {
                   

                    var kq = from n in db.Nhacungcaps
                                 where n.TenNcc == cbboxncc.Text
                                 select n.MaNcc;
                        string MNCC = kq.ToList().FirstOrDefault();


                        Dathangncc dathang = new Dathangncc();
                        dathang.MaNcc = MNCC;
                        dathang.NgayThang = dtpNgayNhap.Value;
                        dathang.TinhTrang = 0;
                        dathang.NguoiLap = txtNguoiLap.Text;
                        db.Dathangnccs.Add(dathang);
                        db.SaveChanges();

                        for (int i = 0; i < dataGridView1.RowCount; i++)
                        {
                            Chitietdathang chitiet = new Chitietdathang();

                            string masp = dataGridView1.Rows[i].Cells[0].Value.ToString();
                            string mau = dataGridView1.Rows[i].Cells[2].Value.ToString();
                            int size = Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value.ToString());
                            int sld = Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value.ToString());
                            decimal thanhtien = Convert.ToDecimal(dataGridView1.Rows[i].Cells[7].Value.ToString());
                            decimal tiencoc = Convert.ToDecimal(dataGridView1.Rows[i].Cells[6].Value.ToString());
                            string tensp = dataGridView1.Rows[i].Cells[3].Value.ToString();
                            decimal dongiadat = Convert.ToDecimal(dataGridView1.Rows[i].Cells[5].Value.ToString());


                            chitiet.MaHddatHang = Convert.ToInt32(txtsohd.Text);
                            chitiet.SoLuongDat = sld;
                            chitiet.Mau = mau;
                            chitiet.ThanhTien = thanhtien;
                            chitiet.Size = size;
                            chitiet.MaSp = masp;
                            chitiet.DonGiaDat = dongiadat;
                            chitiet.TenSp = tensp;
                            chitiet.TienCoc = tiencoc;
                            db.Chitietdathangs.Add(chitiet);
                            sanphams.Add(chitiet);
                            db.SaveChanges();



                        }

                    var u = db.Dathangnccs.Select(p => p); // LẤY RA MÃ SỐ ĐƠN ĐẶT HÀNG
                    txtsohd.Text = (u.Count() + 1).ToString();

                    DialogResult kq2 = MessageBox.Show("Bạn có muốn xuất hóa đơn?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (kq2.Equals(DialogResult.Yes))
                    {
                        ExportInvoice();
                    }
                    //frmChiTietDatHang f = new frmChiTietDatHang(txtsohd.Text);
                    //f.Show();


                }

            }
        }
        private void ExportInvoice()
        {
            try
            {
                string dataDir = @"D:\LTWindows\BaiTapLonStoreApp\StoreApp\StoreApp\InHoaDon\";
                string fileName = "ChiTietDatHangNCC.docx";
                Document doc = new Document(dataDir + fileName);
                // thay thông tin hóa đơn
                doc.Range.Replace("[sohoadon]",(Convert.ToInt32(txtsohd.Text)-1).ToString());
                doc.Range.Replace("[ngaydat]", dtpNgayNhap.Value.ToString());
                doc.Range.Replace("[tenncc]", cbboxncc.Text);
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

                string invoiceId = "HoaDonDat_" + (Convert.ToInt32(txtsohd.Text)-1).ToString() + ".pdf";
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
        private void SOhd_Click(object sender, EventArgs e)
        {

        }

        private void txtTienCoc_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTienCoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtThanhTien_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void cbbMau_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
