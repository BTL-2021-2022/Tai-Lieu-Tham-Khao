
namespace StoreApp
{
    partial class frmTaoHDBan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtChietKhau = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.txtsodienthoai = new System.Windows.Forms.TextBox();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dgvBanHang = new System.Windows.Forms.DataGridView();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongMua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGiaMua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoaHang = new System.Windows.Forms.Button();
            this.btnThemHang = new System.Windows.Forms.Button();
            this.cbbNguoiLap = new System.Windows.Forms.ComboBox();
            this.txtSLcon = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtMahoadon = new System.Windows.Forms.TextBox();
            this.cbbSize = new System.Windows.Forms.ComboBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtthanhtien = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.cbbTenHang = new System.Windows.Forms.ComboBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.cbbMau = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpngay = new System.Windows.Forms.DateTimePicker();
            this.txtTTien = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.btnDonDat = new System.Windows.Forms.Button();
            this.txtTienCoc = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btnTimKhach = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTienTra = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBanHang)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtChietKhau
            // 
            this.txtChietKhau.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtChietKhau.Location = new System.Drawing.Point(1012, 598);
            this.txtChietKhau.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtChietKhau.Name = "txtChietKhau";
            this.txtChietKhau.Size = new System.Drawing.Size(140, 30);
            this.txtChietKhau.TabIndex = 61;
            this.txtChietKhau.Text = "0";
            this.txtChietKhau.TextChanged += new System.EventHandler(this.txtChietKhau_TextChanged);
            this.txtChietKhau.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtChietKhau_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 35);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tên hàng";
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(141, 156);
            this.txtdiachi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(196, 27);
            this.txtdiachi.TabIndex = 2;
            this.txtdiachi.Validated += new System.EventHandler(this.txtdiachi_Validated);
            // 
            // txtsodienthoai
            // 
            this.txtsodienthoai.Location = new System.Drawing.Point(141, 104);
            this.txtsodienthoai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtsodienthoai.Name = "txtsodienthoai";
            this.txtsodienthoai.Size = new System.Drawing.Size(196, 27);
            this.txtsodienthoai.TabIndex = 1;
            this.txtsodienthoai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsodienthoai_KeyPress);
            this.txtsodienthoai.Validated += new System.EventHandler(this.txtsodienthoai_Validated);
            // 
            // txthoten
            // 
            this.txthoten.Location = new System.Drawing.Point(141, 61);
            this.txthoten.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(196, 27);
            this.txthoten.TabIndex = 0;
            this.txthoten.Validated += new System.EventHandler(this.txthoten_Validated);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 165);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Địa chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 107);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số điện thoại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 175);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 19);
            this.label6.TabIndex = 1;
            this.label6.Text = "Số lượng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ tên";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(896, 598);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 22);
            this.label13.TabIndex = 60;
            this.label13.Text = "Chiết khấu";
            // 
            // dgvBanHang
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dgvBanHang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBanHang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBanHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBanHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBanHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSP,
            this.TenSP,
            this.Size,
            this.Mau,
            this.SoLuongMua,
            this.DonGiaMua});
            this.dgvBanHang.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvBanHang.Location = new System.Drawing.Point(37, 546);
            this.dgvBanHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvBanHang.Name = "dgvBanHang";
            this.dgvBanHang.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBanHang.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBanHang.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dgvBanHang.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBanHang.RowTemplate.Height = 24;
            this.dgvBanHang.Size = new System.Drawing.Size(659, 279);
            this.dgvBanHang.TabIndex = 59;
            this.dgvBanHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBanHang_CellContentClick);
            // 
            // MaSP
            // 
            this.MaSP.DataPropertyName = "MaSP";
            this.MaSP.HeaderText = "Mã sản phẩm";
            this.MaSP.MinimumWidth = 6;
            this.MaSP.Name = "MaSP";
            this.MaSP.ReadOnly = true;
            this.MaSP.Width = 125;
            // 
            // TenSP
            // 
            this.TenSP.DataPropertyName = "TenSP";
            this.TenSP.HeaderText = "Tên sản phẩm";
            this.TenSP.MinimumWidth = 6;
            this.TenSP.Name = "TenSP";
            this.TenSP.ReadOnly = true;
            this.TenSP.Width = 175;
            // 
            // Size
            // 
            this.Size.DataPropertyName = "Size";
            this.Size.HeaderText = "Size";
            this.Size.MinimumWidth = 6;
            this.Size.Name = "Size";
            this.Size.ReadOnly = true;
            this.Size.Width = 75;
            // 
            // Mau
            // 
            this.Mau.DataPropertyName = "Mau";
            this.Mau.HeaderText = "Màu";
            this.Mau.MinimumWidth = 6;
            this.Mau.Name = "Mau";
            this.Mau.ReadOnly = true;
            this.Mau.Width = 125;
            // 
            // SoLuongMua
            // 
            this.SoLuongMua.DataPropertyName = "SoLuongMua";
            this.SoLuongMua.HeaderText = "Số lượng";
            this.SoLuongMua.MinimumWidth = 6;
            this.SoLuongMua.Name = "SoLuongMua";
            this.SoLuongMua.ReadOnly = true;
            this.SoLuongMua.Width = 125;
            // 
            // DonGiaMua
            // 
            this.DonGiaMua.DataPropertyName = "DonGiaMua";
            this.DonGiaMua.HeaderText = "Đơn giá";
            this.DonGiaMua.MinimumWidth = 6;
            this.DonGiaMua.Name = "DonGiaMua";
            this.DonGiaMua.ReadOnly = true;
            this.DonGiaMua.Width = 150;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(12, 64);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 19);
            this.label11.TabIndex = 54;
            this.label11.Text = "Mã hóa đơn";
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(863, 797);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(132, 47);
            this.btnLuu.TabIndex = 51;
            this.btnLuu.Text = "Tạo hoá đơn";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoaHang
            // 
            this.btnXoaHang.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnXoaHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaHang.Location = new System.Drawing.Point(190, 221);
            this.btnXoaHang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoaHang.Name = "btnXoaHang";
            this.btnXoaHang.Size = new System.Drawing.Size(78, 54);
            this.btnXoaHang.TabIndex = 50;
            this.btnXoaHang.Text = "Bỏ hàng";
            this.btnXoaHang.UseVisualStyleBackColor = true;
            this.btnXoaHang.Click += new System.EventHandler(this.btnXoaHang_Click);
            // 
            // btnThemHang
            // 
            this.btnThemHang.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnThemHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemHang.Location = new System.Drawing.Point(35, 227);
            this.btnThemHang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThemHang.Name = "btnThemHang";
            this.btnThemHang.Size = new System.Drawing.Size(100, 48);
            this.btnThemHang.TabIndex = 48;
            this.btnThemHang.Text = "Thêm mặt hàng";
            this.btnThemHang.UseVisualStyleBackColor = true;
            this.btnThemHang.Click += new System.EventHandler(this.btnThemHang_Click);
            // 
            // cbbNguoiLap
            // 
            this.cbbNguoiLap.Enabled = false;
            this.cbbNguoiLap.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbbNguoiLap.FormattingEnabled = true;
            this.cbbNguoiLap.Location = new System.Drawing.Point(112, 159);
            this.cbbNguoiLap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbbNguoiLap.Name = "cbbNguoiLap";
            this.cbbNguoiLap.Size = new System.Drawing.Size(176, 27);
            this.cbbNguoiLap.TabIndex = 46;
            // 
            // txtSLcon
            // 
            this.txtSLcon.Enabled = false;
            this.txtSLcon.Location = new System.Drawing.Point(130, 116);
            this.txtSLcon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSLcon.MaxLength = 15;
            this.txtSLcon.Name = "txtSLcon";
            this.txtSLcon.ReadOnly = true;
            this.txtSLcon.Size = new System.Drawing.Size(112, 27);
            this.txtSLcon.TabIndex = 6;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(17, 121);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(99, 19);
            this.label16.TabIndex = 7;
            this.label16.Text = "Số lượng còn";
            // 
            // txtMahoadon
            // 
            this.txtMahoadon.Enabled = false;
            this.txtMahoadon.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMahoadon.Location = new System.Drawing.Point(112, 64);
            this.txtMahoadon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMahoadon.Name = "txtMahoadon";
            this.txtMahoadon.Size = new System.Drawing.Size(176, 27);
            this.txtMahoadon.TabIndex = 43;
            // 
            // cbbSize
            // 
            this.cbbSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSize.FormattingEnabled = true;
            this.cbbSize.Location = new System.Drawing.Point(130, 70);
            this.cbbSize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbSize.Name = "cbbSize";
            this.cbbSize.Size = new System.Drawing.Size(112, 27);
            this.cbbSize.TabIndex = 5;
            this.cbbSize.SelectedIndexChanged += new System.EventHandler(this.cbbSize_SelectedIndexChanged);
            this.cbbSize.Validated += new System.EventHandler(this.cbbSize_Validated);
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(1039, 797);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(113, 44);
            this.btnHuy.TabIndex = 53;
            this.btnHuy.Text = "Hủy hóa đơn";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(865, 546);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(123, 22);
            this.label12.TabIndex = 57;
            this.label12.Text = "Tiền sản phẩm";
            // 
            // txtthanhtien
            // 
            this.txtthanhtien.Enabled = false;
            this.txtthanhtien.Location = new System.Drawing.Point(406, 167);
            this.txtthanhtien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtthanhtien.MaxLength = 20;
            this.txtthanhtien.Name = "txtthanhtien";
            this.txtthanhtien.ReadOnly = true;
            this.txtthanhtien.Size = new System.Drawing.Size(108, 27);
            this.txtthanhtien.TabIndex = 3;
            this.txtthanhtien.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(12, 164);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 19);
            this.label10.TabIndex = 52;
            this.label10.Text = "Người lập";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtdiachi);
            this.groupBox1.Controls.Add(this.txtsodienthoai);
            this.groupBox1.Controls.Add(this.txthoten);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(341, 201);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(385, 231);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(548, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 38);
            this.label1.TabIndex = 42;
            this.label1.Text = "BÁN HÀNG";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Enabled = false;
            this.txtDonGia.Location = new System.Drawing.Point(402, 25);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDonGia.MaxLength = 15;
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.ReadOnly = true;
            this.txtDonGia.Size = new System.Drawing.Size(112, 27);
            this.txtDonGia.TabIndex = 2;
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(130, 170);
            this.txtsoluong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtsoluong.MaxLength = 15;
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(112, 27);
            this.txtsoluong.TabIndex = 1;
            this.txtsoluong.TextChanged += new System.EventHandler(this.txtsoluong_TextChanged);
            this.txtsoluong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsoluong_KeyPress);
            this.txtsoluong.Validated += new System.EventHandler(this.txtsoluong_Validated);
            // 
            // cbbTenHang
            // 
            this.cbbTenHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTenHang.FormattingEnabled = true;
            this.cbbTenHang.Location = new System.Drawing.Point(130, 25);
            this.cbbTenHang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbbTenHang.Name = "cbbTenHang";
            this.cbbTenHang.Size = new System.Drawing.Size(112, 27);
            this.cbbTenHang.TabIndex = 0;
            this.cbbTenHang.SelectedIndexChanged += new System.EventHandler(this.cbbTenHang_SelectedIndexChanged);
            this.cbbTenHang.Validated += new System.EventHandler(this.cbbTenHang_Validated);
            // 
            // txtTongTien
            // 
            this.txtTongTien.Enabled = false;
            this.txtTongTien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTongTien.Location = new System.Drawing.Point(1012, 546);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(140, 30);
            this.txtTongTien.TabIndex = 58;
            this.txtTongTien.Text = "0";
            this.txtTongTien.TextChanged += new System.EventHandler(this.txtTongTien_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLamMoi);
            this.groupBox2.Controls.Add(this.txtSLcon);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.cbbSize);
            this.groupBox2.Controls.Add(this.cbbMau);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txtthanhtien);
            this.groupBox2.Controls.Add(this.txtDonGia);
            this.groupBox2.Controls.Add(this.txtsoluong);
            this.groupBox2.Controls.Add(this.btnXoaHang);
            this.groupBox2.Controls.Add(this.cbbTenHang);
            this.groupBox2.Controls.Add(this.btnThemHang);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(773, 201);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(531, 290);
            this.groupBox2.TabIndex = 47;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mặt hàng";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLamMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLamMoi.Location = new System.Drawing.Point(423, 227);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(95, 48);
            this.btnLamMoi.TabIndex = 65;
            this.btnLamMoi.Text = "Nhập lại";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(338, 72);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(39, 19);
            this.label20.TabIndex = 15;
            this.label20.Text = "Màu";
            // 
            // cbbMau
            // 
            this.cbbMau.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMau.FormattingEnabled = true;
            this.cbbMau.Items.AddRange(new object[] {
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44"});
            this.cbbMau.Location = new System.Drawing.Point(402, 67);
            this.cbbMau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbMau.Name = "cbbMau";
            this.cbbMau.Size = new System.Drawing.Size(112, 27);
            this.cbbMau.TabIndex = 14;
            this.cbbMau.SelectedIndexChanged += new System.EventHandler(this.cbbMau_SelectedIndexChanged);
            this.cbbMau.Validated += new System.EventHandler(this.cbbMau_Validated);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(17, 78);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 19);
            this.label15.TabIndex = 4;
            this.label15.Text = "Size";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(298, 175);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 19);
            this.label8.TabIndex = 1;
            this.label8.Text = "Thành tiền";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(315, 28);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 19);
            this.label7.TabIndex = 1;
            this.label7.Text = "Đơn giá";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(12, 108);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 19);
            this.label9.TabIndex = 49;
            this.label9.Text = "Ngày lập";
            // 
            // dtpngay
            // 
            this.dtpngay.CustomFormat = "dd/MM/yyyy";
            this.dtpngay.Enabled = false;
            this.dtpngay.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpngay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpngay.Location = new System.Drawing.Point(112, 107);
            this.dtpngay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpngay.Name = "dtpngay";
            this.dtpngay.Size = new System.Drawing.Size(176, 27);
            this.dtpngay.TabIndex = 44;
            // 
            // txtTTien
            // 
            this.txtTTien.Enabled = false;
            this.txtTTien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTTien.Location = new System.Drawing.Point(1012, 649);
            this.txtTTien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTTien.Name = "txtTTien";
            this.txtTTien.Size = new System.Drawing.Size(140, 30);
            this.txtTTien.TabIndex = 63;
            this.txtTTien.Text = "0";
            this.txtTTien.TextChanged += new System.EventHandler(this.txtTTien_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(876, 652);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(113, 22);
            this.label18.TabIndex = 62;
            this.label18.Text = "Tiền hoá đơn";
            // 
            // btnDonDat
            // 
            this.btnDonDat.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDonDat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDonDat.Location = new System.Drawing.Point(206, 164);
            this.btnDonDat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDonDat.Name = "btnDonDat";
            this.btnDonDat.Size = new System.Drawing.Size(111, 40);
            this.btnDonDat.TabIndex = 65;
            this.btnDonDat.Text = "Đơn đã đặt";
            this.btnDonDat.UseVisualStyleBackColor = true;
            this.btnDonDat.Click += new System.EventHandler(this.btnDonDat_Click);
            // 
            // txtTienCoc
            // 
            this.txtTienCoc.Enabled = false;
            this.txtTienCoc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTienCoc.Location = new System.Drawing.Point(1012, 699);
            this.txtTienCoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTienCoc.Name = "txtTienCoc";
            this.txtTienCoc.Size = new System.Drawing.Size(140, 30);
            this.txtTienCoc.TabIndex = 67;
            this.txtTienCoc.Text = "0";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(896, 699);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(78, 22);
            this.label17.TabIndex = 66;
            this.label17.Text = "Tiền cọc";
            // 
            // btnTimKhach
            // 
            this.btnTimKhach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTimKhach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKhach.Location = new System.Drawing.Point(564, 164);
            this.btnTimKhach.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnTimKhach.Name = "btnTimKhach";
            this.btnTimKhach.Size = new System.Drawing.Size(110, 38);
            this.btnTimKhach.TabIndex = 68;
            this.btnTimKhach.Text = "Tìm khách";
            this.btnTimKhach.UseVisualStyleBackColor = true;
            this.btnTimKhach.Click += new System.EventHandler(this.btnTimKhach_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtMahoadon);
            this.groupBox3.Controls.Add(this.dtpngay);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.cbbNguoiLap);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(11, 201);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(306, 231);
            this.groupBox3.TabIndex = 46;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin đơn hàng";
            // 
            // txtTienTra
            // 
            this.txtTienTra.Enabled = false;
            this.txtTienTra.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTienTra.Location = new System.Drawing.Point(1012, 739);
            this.txtTienTra.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTienTra.Name = "txtTienTra";
            this.txtTienTra.Size = new System.Drawing.Size(140, 30);
            this.txtTienTra.TabIndex = 72;
            this.txtTienTra.Text = "0";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label19.Location = new System.Drawing.Point(896, 739);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(110, 22);
            this.label19.TabIndex = 71;
            this.label19.Text = "Tiền phải trả";
            // 
            // frmTaoHDBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1715, 1026);
            this.Controls.Add(this.txtTienTra);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnTimKhach);
            this.Controls.Add(this.txtTienCoc);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.btnDonDat);
            this.Controls.Add(this.txtTTien);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtChietKhau);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dgvBanHang);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmTaoHDBan";
            this.Text = "frmTaoHDBan";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmTaoHDBan_FormClosed);
            this.Load += new System.EventHandler(this.frmTaoHDBan_Load);
            this.Enter += new System.EventHandler(this.btnThemHang_Click);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBanHang)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtTTien;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtChietKhau;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dgvBanHang;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoaHang;
        private System.Windows.Forms.Button btnThemHang;
        private System.Windows.Forms.ComboBox cbbNguoiLap;
        private System.Windows.Forms.TextBox txtMahoadon;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.TextBox txtsodienthoai;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSLcon;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cbbSize;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtthanhtien;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.ComboBox cbbTenHang;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpngay;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cbbMau;
        private System.Windows.Forms.TextBox txtTienCoc;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnDonDat;
        private System.Windows.Forms.Button btnTimKhach;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtTienTra;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Size;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mau;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongMua;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGiaMua;
    }
}