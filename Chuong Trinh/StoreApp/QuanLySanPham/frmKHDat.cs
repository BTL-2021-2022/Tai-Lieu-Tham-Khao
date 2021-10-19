using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using StoreApp.Models;
using System.Reflection;
using System.IO;
using Aspose.Words;
using Aspose.Words.Tables;
using System.Threading.Tasks;
using System.Diagnostics;

namespace StoreApp.QuanLySanPham
{
    public partial class frmKHDat : Form
    {
        QuanLyBanGiayContext db = new QuanLyBanGiayContext();
        Sanpham findSp = new Sanpham();

        List<Chitietkhdat> sanphams = new List<Chitietkhdat>();
        Document doc;
        object objMiss = Missing.Value;
        string oldSize = "";
        string oldColor = "";

        
        public frmKHDat()
        {
            InitializeComponent();
        }

        private void frmKHDat_Load(object sender, EventArgs e)
        {
            cbTinhTrang.SelectedItem = "Chờ xử lý";
            UpdateSoHd();
            btnThanhToan.Visible = Global.Status == "ADMIN" ? false : true;
        }

        #region Chức năng
        static string ConvertToMoney(decimal money)
        {
            return String.Format("{0:C01}", money).Replace("$", "").Replace(".0", "") + " VND";
        }
        public async Task SaveDocumentAsync(string docPath)
        {
            statusStrip1.Visible = true;
            toolStripStatusLabel1.Text = "Đang xuất file, vui lòng đợi.....";
            processBar.Visible = true;
            processBar.Value = 0;
            Action saveAction = new Action(() => doc.Save(docPath));
            await Task.Run(saveAction);
        }

        private List<int> GetSize(string detail)
        {
            try
            {
                List<int> arr = new List<int>();
                string[] size = detail.Split(" - ");
                for (int i = int.Parse(size[0]); i <= int.Parse(size[1]); i++)
                {
                    arr.Add(i);
                }
                return arr;
            }
            catch (Exception)
            {
                MessageBox.Show("Không tìm thấy thông tin size của sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        private async void ExportInvoice(string saveDir)
        {
            try
            {
                string FileLocation = Path.Combine(Path.GetFullPath(@"..\..\..\"), "Resources") + @"\HoaDon.docx";
                //string dataDir = @"E:\STUDY\Windows\BTL\store_app\StoreApp\StoreApp\InHoaDon\";
                //string fileName = "HoaDon.docx";
                doc = new Document(FileLocation);
                // thay thông tin hóa đơn
                doc.Range.Replace("[sohoadon]", txtMaHd.Text);
                doc.Range.Replace("[ngaydat]", dtpNgayDat.Value.ToString());
                doc.Range.Replace("[tennhanvien]", Global.UserName);
                doc.Range.Replace("[tenkhachhang]", txtTenKh.Text);
                doc.Range.Replace("[sdt]", txtSdtKh.Text);
                doc.Range.Replace("[diachi]", txtDiaChi.Text);


                // chèn dữ liệu vào bảng

                Table table = (Table)doc.GetChild(NodeType.Table, 0, true);

                foreach (var item in sanphams)
                {
                    decimal thanhTien = item.DonGiaNhap * item.SoLuongDat * decimal.Parse("0.1"); 
                    Row lastRow = (Row) table.LastRow;
                    lastRow.Cells[0].LastParagraph.AppendChild(new Run(doc,item.MaSp+ ControlChar.LineBreak));
                    lastRow.Cells[1].FirstParagraph.AppendChild(new Run(doc,item.TenSp + ControlChar.LineBreak));
                    lastRow.Cells[2].FirstParagraph.AppendChild(new Run(doc,item.Size.ToString() + ControlChar.LineBreak));
                    lastRow.Cells[3].FirstParagraph.AppendChild(new Run(doc,item.SoLuongDat.ToString() + ControlChar.LineBreak));
                    lastRow.Cells[4].FirstParagraph.AppendChild(new Run(doc,item.Mau + ControlChar.LineBreak));
                    lastRow.Cells[5].FirstParagraph.AppendChild(new Run(doc,item.DonGiaNhap.ToString("0") + ControlChar.LineBreak));
                    lastRow.Cells[6].FirstParagraph.AppendChild(new Run(doc, thanhTien.ToString("0") + ControlChar.LineBreak));
                    
                }
                doc.Range.Replace("[tongphaitra]", txtTongTien.Text);
                doc.Range.Replace("[khachdua]", txtKhachDua.Text);
                doc.Range.Replace("[tralai]", txtTraLai.Text);

                var saveTask = SaveDocumentAsync(saveDir);
                for (int i = 0; i < 10; i++)
                {
                    processBar.PerformStep();

                }
                Task isFinished = await Task.WhenAny(saveTask);
                // async await show dialog
               
                if (isFinished == saveTask)
                {
                    statusStrip1.Visible = false;
                    processBar.Visible = false;
                    toolStripStatusLabel1.Text = "";
            
                    var psi = new System.Diagnostics.ProcessStartInfo();
                    psi.UseShellExecute = true;
                    psi.FileName = saveDir;
                    System.Diagnostics.Process.Start(psi);



                    ClearTextboxes();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //---------------------------
        private void DisplayDetailsProduct(List<Chitietkhdat> list)
        {
            decimal tienCoc = 0;
            foreach (var item in list)
            {
                tienCoc +=  item.DonGiaNhap* item.SoLuongDat * Convert.ToDecimal(0.1);
            }
            txtTienSp.Text = tienCoc.ToString("0");
            txtTongTien.Text = tienCoc.ToString("0");
            dgvSanPhams.DataSource = list.Select(sp=> new { sp.MaSp, sp.TenSp, sp.Size, sp.SoLuongDat, sp.Mau, DonGiaNhap = ConvertToMoney(sp.DonGiaNhap), ThanhTien = ConvertToMoney(sp.ThanhTien) }).ToList();
            lblTongSanPham.Text = list.Count().ToString();

        }
        private void ClearTextboxes()
        {
            txtTenKh.Clear();
            txtDiaChi.Clear();
            txtSdtKh.Clear();
            txtSoLuong.Clear();
            txtMaHd.Clear();
            txtTenSp.Clear();
            cbSize.Text = "";
            txtSoLuong.Clear();
            txtTienCoc.Clear();
            txtTongTien.Clear();
            txtTienSp.Clear();
            txtTraLai.Clear();
            txtKhachDua.Clear();
            txtMau.Clear();
            sanphams = new List<Chitietkhdat>();
            dgvSanPhams.DataSource = sanphams;
            cbTinhTrang.SelectedValue = "Chờ xử lý";
            dtpNgayDat.Value = DateTime.Now;
        }
        private void UpdateSoHd()
        {
            List<Donkhdat> getDon = db.Donkhdats.ToList();
            txtMaHd.Text = getDon.Count() + 1 + "";
        }
        private bool hasProductInfo()
        {
            //if (txtMaSp.Text == "")
            //{
            //    MessageBox.Show("Vui lòng chọn sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return false;
            //}
            if (txtMau.Text == "")
            {
                MessageBox.Show("Vui lòng nhập màu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtSoLuong.Text == "")
            {
                MessageBox.Show("Vui lòng điền số lượng của sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private bool hasCustomerInfo()
        {
            if (txtTenKh.Text == "")
            {
                MessageBox.Show("Vui lòng điền tên khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtDiaChi.Text == "")
            {
                MessageBox.Show("Vui lòng điền địa chỉ của khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtSdtKh.Text == "")
            {
                MessageBox.Show("Vui lòng điền số điền thoại của khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(txtKhachDua.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số tiền khách đưa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; 
            }
            return true;
        }
        #endregion

       private void dgvSanPhams_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            string masp = dgvSanPhams.Rows[index].Cells["MaSp"].Value.ToString();
            findSp = db.Sanphams.Find(masp);
            cbSize.DataSource = GetSize(findSp.ThongTin);
            txtTenSp.Text = findSp.TenSp;
            txtSoLuong.Text = dgvSanPhams.Rows[index].Cells["SoLuongDat"].Value.ToString();
            cbSize.Text = dgvSanPhams.Rows[index].Cells["Size"].Value.ToString();
            oldSize = dgvSanPhams.Rows[index].Cells["Size"].Value.ToString();
            txtMau.Text = dgvSanPhams.Rows[index].Cells["Mau"].Value.ToString();
            oldColor = dgvSanPhams.Rows[index].Cells["Mau"].Value.ToString();
        }

        private void btnTimSp_Click(object sender, EventArgs e)
        {
            frmListSp frm = new frmListSp();
            frm.ShowDialog();
            if(frm.CommunicationStuff != "")
            {
                findSp = db.Sanphams.Find(frm.CommunicationStuff);
                txtTenSp.Text = findSp.TenSp;
                //ShowSize(frm.CommunicationStuff);
                cbSize.DataSource = GetSize(findSp.ThongTin);
                txtSoLuong.Clear();
            }
            else
            {
                MessageBox.Show("Sản phẩm chưa được chọn vui lòng chọn lại hoặc nhập tên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThemSp_Click(object sender, EventArgs e)
        {
            
            if (hasProductInfo())
            {
                if(!sanphams.Exists(sp=> sp.MaSp == findSp.TenSp && sp.Size == int.Parse(cbSize.SelectedValue.ToString())))
                {

                    Chitietkhdat newHd = new Chitietkhdat();
                    newHd.SoHd = int.Parse(txtMaHd.Text);
                    newHd.MaSp = findSp.MaSp;
                    newHd.TenSp = findSp.TenSp;
                    newHd.Size = int.Parse(cbSize.SelectedValue.ToString());
                    newHd.DonGiaNhap = findSp.GiaBan;
                    newHd.SoLuongDat = int.Parse(txtSoLuong.Text);
                    newHd.ThanhTien = findSp.GiaBan*newHd.SoLuongDat*Convert.ToDecimal(0.1);
                    newHd.Mau = txtMau.Text;
                    sanphams.Add(newHd);
                    DisplayDetailsProduct(sanphams);
                    dgvSanPhams.Refresh();
                    txtTenSp.Clear();
                    cbSize.Text = "";
                    txtSoLuong.Clear();
                    txtMau.Clear();
                }
                else
                {
                    MessageBox.Show("Sản phẩm với size này đã được chọn vui lòng sửa lại thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }  
           
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (hasProductInfo())
            {
                foreach (var item in sanphams)
                {
                    if ((item.MaSp == findSp.MaSp && item.Size == int.Parse(oldSize)) && item.Mau == oldColor)
                    {
                        item.SoLuongDat = int.Parse(txtSoLuong.Text);
                        item.Size = int.Parse(cbSize.SelectedValue.ToString());
                        item.Mau = txtMau.Text;
                        item.ThanhTien = item.DonGiaNhap*item.SoLuongDat * Convert.ToDecimal(0.1);
                    }
                }
            }
            DisplayDetailsProduct(sanphams);
        }

        private void btnXoaSp_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Bạn có chắc muốn xóa sản phẩm khỏi danh sách?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(answer == DialogResult.Yes)
            {
                Donkhdat getDon = db.Donkhdats.Find(int.Parse(txtMaHd.Text));
                if (hasProductInfo())
                {
                    Chitietkhdat found = sanphams.Find(sp => (sp.MaSp == findSp.MaSp && sp.Size == int.Parse(oldSize)) && sp.Mau == oldColor);
                    sanphams.Remove(found);
                    DisplayDetailsProduct(sanphams);
                    txtTenSp.Clear();
                    cbSize.Text = "";
                    txtSoLuong.Clear();
                    txtMau.Clear();
                }   
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {


            ExportInvoice(saveBill.FileName);

            if (hasCustomerInfo())
            {
                Donkhdat newDon = new Donkhdat();
                newDon.TenKh = txtTenKh.Text;
                newDon.Sdt = txtSdtKh.Text;
                newDon.DiaChiKh = txtDiaChi.Text;
                newDon.TinhTrang = cbTinhTrang.SelectedItem.ToString();
                newDon.NgayDat = dtpNgayDat.Value;
                newDon.TienCoc = decimal.Parse(txtTongTien.Text);
                db.Donkhdats.Add(newDon);
                db.SaveChanges();

                foreach (var item in sanphams)
                {
                    db.Chitietkhdats.Add(item);
                    db.SaveChanges();
                }
                DialogResult answer = MessageBox.Show("Bạn có muốn in hóa đơn không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (answer == DialogResult.Yes)
                {
                    // choose file location
                    saveBill.Filter = "PDF(*.pdf)|*.pdf";
                    saveBill.Title = "Chọn vị trí lưu";
                    saveBill.FileName = "HoaDon_" + txtMaHd.Text + "_" + dtpNgayDat.Value.ToString("dd:MM:yyy:hh:mm").Replace(":", "_") + ".pdf";
                    saveBill.ShowDialog();
                    if (saveBill.FileName != "")
                    {
                        ExportInvoice(saveBill.FileName);
                    }
                }
            }
        }



        private void txtTenSp_Leave(object sender, EventArgs e)
        {
            findSp = db.Sanphams.FirstOrDefault(sp => sp.TenSp.Contains(txtTenSp.Text));
            if(findSp!= null)
            {
                txtTenSp.Text = findSp.TenSp;
                cbSize.DataSource = GetSize(findSp.ThongTin);
                //ShowSize(findSp.MaSp);
            }
            else
            {
                MessageBox.Show("Không tìm thấy sản phẩm, vui lòng nhập đúng tên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDanhSach_Click(object sender, EventArgs e)
        {
            frmDanhSachDonDat newfrm = new frmDanhSachDonDat();
            newfrm.Show();
        }

        private void txtTienCoc_Changed(object sender, EventArgs e)
        {
            if (txtTienCoc.Text!= "" && int.Parse(txtTienCoc.Text) > int.Parse(txtTienSp.Text))
            {
                txtTongTien.Text = txtTienCoc.Text;
            }
        }

        private void txtKhachDua_Changed(object sender, EventArgs e)
        {
            int tongTien = int.Parse(txtTongTien.Text);
            int khachDua = txtKhachDua.Text != ""? int.Parse(txtKhachDua.Text) : 0;

            txtTraLai.Text = khachDua>tongTien? Convert.ToString(khachDua - tongTien) : "0";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
