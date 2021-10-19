
namespace StoreApp.QuanLySanPham
{
    partial class frmKHDat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKHDat));
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSanPhams = new System.Windows.Forms.DataGridView();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongDat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTenKh = new System.Windows.Forms.TextBox();
            this.txtSdtKh = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTongSanPham = new System.Windows.Forms.Label();
            this.btnThemSp = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMau = new System.Windows.Forms.TextBox();
            this.cbSize = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btnTimSp = new System.Windows.Forms.PictureBox();
            this.btnXoaSp = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.txtTenSp = new System.Windows.Forms.TextBox();
            this.cbTinhTrang = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpNgayDat = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtMaHd = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtTienSp = new System.Windows.Forms.TextBox();
            this.txtTienCoc = new System.Windows.Forms.TextBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.txtKhachDua = new System.Windows.Forms.TextBox();
            this.txtTraLai = new System.Windows.Forms.TextBox();
            this.btnDanhSach = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.processBar = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.saveBill = new System.Windows.Forms.SaveFileDialog();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPhams)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnTimSp)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(646, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐƠN ĐẶT HÀNG";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvSanPhams
            // 
            this.dgvSanPhams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPhams.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSP,
            this.TenSP,
            this.Size,
            this.SoLuongDat,
            this.Mau,
            this.Column4,
            this.Column5});
            this.dgvSanPhams.Location = new System.Drawing.Point(137, 499);
            this.dgvSanPhams.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSanPhams.Name = "dgvSanPhams";
            this.dgvSanPhams.RowHeadersWidth = 51;
            this.dgvSanPhams.Size = new System.Drawing.Size(817, 292);
            this.dgvSanPhams.TabIndex = 3;
            this.dgvSanPhams.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanPhams_CellContentClick);
            // 
            // MaSP
            // 
            this.MaSP.DataPropertyName = "MaSP";
            this.MaSP.HeaderText = "Mã sản phẩm";
            this.MaSP.MinimumWidth = 6;
            this.MaSP.Name = "MaSP";
            this.MaSP.Width = 50;
            // 
            // TenSP
            // 
            this.TenSP.DataPropertyName = "TenSP";
            this.TenSP.HeaderText = "Tên sản phẩm";
            this.TenSP.MinimumWidth = 6;
            this.TenSP.Name = "TenSP";
            this.TenSP.Width = 250;
            // 
            // Size
            // 
            this.Size.DataPropertyName = "Size";
            this.Size.HeaderText = "Size";
            this.Size.MinimumWidth = 6;
            this.Size.Name = "Size";
            this.Size.Width = 50;
            // 
            // SoLuongDat
            // 
            this.SoLuongDat.DataPropertyName = "SoLuongDat";
            this.SoLuongDat.HeaderText = "SLuong";
            this.SoLuongDat.MinimumWidth = 6;
            this.SoLuongDat.Name = "SoLuongDat";
            this.SoLuongDat.Width = 75;
            // 
            // Mau
            // 
            this.Mau.DataPropertyName = "Mau";
            this.Mau.HeaderText = "Màu sắc";
            this.Mau.Name = "Mau";
            this.Mau.Width = 75;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "DonGiaNhap";
            this.Column4.HeaderText = "Đơn giá nhập";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "ThanhTien";
            this.Column5.HeaderText = "Thành tiền (=10% tiền bán)";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 150;
            // 
            // txtTenKh
            // 
            this.txtTenKh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTenKh.Location = new System.Drawing.Point(146, 58);
            this.txtTenKh.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenKh.Name = "txtTenKh";
            this.txtTenKh.Size = new System.Drawing.Size(177, 26);
            this.txtTenKh.TabIndex = 5;
            // 
            // txtSdtKh
            // 
            this.txtSdtKh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSdtKh.Location = new System.Drawing.Point(146, 100);
            this.txtSdtKh.Margin = new System.Windows.Forms.Padding(4);
            this.txtSdtKh.MaxLength = 10;
            this.txtSdtKh.Name = "txtSdtKh";
            this.txtSdtKh.Size = new System.Drawing.Size(177, 26);
            this.txtSdtKh.TabIndex = 6;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDiaChi.Location = new System.Drawing.Point(147, 141);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(176, 26);
            this.txtDiaChi.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(31, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tên khách hàng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(31, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "Số điện thoại:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(31, 142);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "Địa chỉ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(26, 104);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 19);
            this.label6.TabIndex = 14;
            this.label6.Text = "Kích cỡ:";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(148, 146);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(184, 26);
            this.txtSoLuong.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(26, 148);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 19);
            this.label7.TabIndex = 16;
            this.label7.Text = "Số lượng:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(137, 470);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 15);
            this.label8.TabIndex = 17;
            this.label8.Text = "Số lượng sản phẩm:";
            // 
            // lblTongSanPham
            // 
            this.lblTongSanPham.AutoSize = true;
            this.lblTongSanPham.Location = new System.Drawing.Point(277, 470);
            this.lblTongSanPham.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTongSanPham.Name = "lblTongSanPham";
            this.lblTongSanPham.Size = new System.Drawing.Size(13, 15);
            this.lblTongSanPham.TabIndex = 18;
            this.lblTongSanPham.Text = "0";
            // 
            // btnThemSp
            // 
            this.btnThemSp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnThemSp.Location = new System.Drawing.Point(275, 230);
            this.btnThemSp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnThemSp.Name = "btnThemSp";
            this.btnThemSp.Size = new System.Drawing.Size(57, 31);
            this.btnThemSp.TabIndex = 19;
            this.btnThemSp.Text = "Thêm";
            this.btnThemSp.UseVisualStyleBackColor = true;
            this.btnThemSp.Click += new System.EventHandler(this.btnThemSp_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.txtSdtKh);
            this.groupBox1.Controls.Add(this.txtTenKh);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(577, 153);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(347, 204);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMau);
            this.groupBox2.Controls.Add(this.cbSize);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.btnTimSp);
            this.groupBox2.Controls.Add(this.btnXoaSp);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnThemSp);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtSoLuong);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtTenSp);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(137, 153);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(397, 280);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin sản phẩm";
            // 
            // txtMau
            // 
            this.txtMau.Location = new System.Drawing.Point(148, 191);
            this.txtMau.Name = "txtMau";
            this.txtMau.Size = new System.Drawing.Size(184, 26);
            this.txtMau.TabIndex = 38;
            // 
            // cbSize
            // 
            this.cbSize.FormattingEnabled = true;
            this.cbSize.Location = new System.Drawing.Point(148, 99);
            this.cbSize.Name = "cbSize";
            this.cbSize.Size = new System.Drawing.Size(71, 27);
            this.cbSize.TabIndex = 37;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(26, 54);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(96, 19);
            this.label17.TabIndex = 36;
            this.label17.Text = "Tên sản phẩm:";
            // 
            // btnTimSp
            // 
            this.btnTimSp.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTimSp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnTimSp.Image = ((System.Drawing.Image)(resources.GetObject("btnTimSp.Image")));
            this.btnTimSp.Location = new System.Drawing.Point(367, 19);
            this.btnTimSp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnTimSp.Name = "btnTimSp";
            this.btnTimSp.Size = new System.Drawing.Size(21, 19);
            this.btnTimSp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnTimSp.TabIndex = 21;
            this.btnTimSp.TabStop = false;
            this.btnTimSp.Click += new System.EventHandler(this.btnTimSp_Click);
            // 
            // btnXoaSp
            // 
            this.btnXoaSp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnXoaSp.Location = new System.Drawing.Point(148, 230);
            this.btnXoaSp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnXoaSp.Name = "btnXoaSp";
            this.btnXoaSp.Size = new System.Drawing.Size(58, 31);
            this.btnXoaSp.TabIndex = 20;
            this.btnXoaSp.Text = "Xóa";
            this.btnXoaSp.UseVisualStyleBackColor = true;
            this.btnXoaSp.Click += new System.EventHandler(this.btnXoaSp_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSua.Location = new System.Drawing.Point(212, 230);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(58, 31);
            this.btnSua.TabIndex = 19;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(26, 195);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(68, 19);
            this.label18.TabIndex = 16;
            this.label18.Text = "Màu sắc: ";
            // 
            // txtTenSp
            // 
            this.txtTenSp.Location = new System.Drawing.Point(148, 51);
            this.txtTenSp.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenSp.Name = "txtTenSp";
            this.txtTenSp.Size = new System.Drawing.Size(184, 26);
            this.txtTenSp.TabIndex = 9;
            this.txtTenSp.Leave += new System.EventHandler(this.txtTenSp_Leave);
            // 
            // cbTinhTrang
            // 
            this.cbTinhTrang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbTinhTrang.FormattingEnabled = true;
            this.cbTinhTrang.Items.AddRange(new object[] {
            "Đã xử lý",
            "Chờ xử lý"});
            this.cbTinhTrang.Location = new System.Drawing.Point(151, 82);
            this.cbTinhTrang.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbTinhTrang.Name = "cbTinhTrang";
            this.cbTinhTrang.Size = new System.Drawing.Size(159, 27);
            this.cbTinhTrang.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(44, 86);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 19);
            this.label10.TabIndex = 27;
            this.label10.Text = "Tình trạng:";
            // 
            // dtpNgayDat
            // 
            this.dtpNgayDat.Enabled = false;
            this.dtpNgayDat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpNgayDat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayDat.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpNgayDat.Location = new System.Drawing.Point(151, 138);
            this.dtpNgayDat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpNgayDat.Name = "dtpNgayDat";
            this.dtpNgayDat.Size = new System.Drawing.Size(100, 22);
            this.dtpNgayDat.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(44, 138);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 19);
            this.label11.TabIndex = 27;
            this.label11.Text = "Ngày đặt:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtMaHd);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.dtpNgayDat);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.cbTinhTrang);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(959, 153);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Size = new System.Drawing.Size(397, 204);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin đơn đặt";
            // 
            // txtMaHd
            // 
            this.txtMaHd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMaHd.Location = new System.Drawing.Point(151, 36);
            this.txtMaHd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMaHd.Name = "txtMaHd";
            this.txtMaHd.ReadOnly = true;
            this.txtMaHd.Size = new System.Drawing.Size(159, 26);
            this.txtMaHd.TabIndex = 30;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(44, 40);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 19);
            this.label12.TabIndex = 29;
            this.label12.Text = "Mã đơn:";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(137, 37);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 30;
            this.button5.Text = "Quay lại";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnThanhToan.Location = new System.Drawing.Point(1129, 747);
            this.btnThanhToan.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(133, 38);
            this.btnThanhToan.TabIndex = 33;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(979, 499);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 17);
            this.label9.TabIndex = 34;
            this.label9.Text = "Tiền sản phẩm:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(979, 548);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 17);
            this.label13.TabIndex = 34;
            this.label13.Text = "Tiền cọc:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(979, 597);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 17);
            this.label14.TabIndex = 34;
            this.label14.Text = "Tổng phải trả:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(979, 646);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 17);
            this.label15.TabIndex = 34;
            this.label15.Text = "Khách đưa:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(979, 695);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 17);
            this.label16.TabIndex = 34;
            this.label16.Text = "Trả lại:";
            // 
            // txtTienSp
            // 
            this.txtTienSp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTienSp.Location = new System.Drawing.Point(1085, 493);
            this.txtTienSp.Margin = new System.Windows.Forms.Padding(4);
            this.txtTienSp.Name = "txtTienSp";
            this.txtTienSp.ReadOnly = true;
            this.txtTienSp.Size = new System.Drawing.Size(177, 26);
            this.txtTienSp.TabIndex = 35;
            // 
            // txtTienCoc
            // 
            this.txtTienCoc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTienCoc.Location = new System.Drawing.Point(1085, 537);
            this.txtTienCoc.Margin = new System.Windows.Forms.Padding(4);
            this.txtTienCoc.Name = "txtTienCoc";
            this.txtTienCoc.Size = new System.Drawing.Size(177, 26);
            this.txtTienCoc.TabIndex = 35;
            this.txtTienCoc.TextChanged += new System.EventHandler(this.txtTienCoc_Changed);
            // 
            // txtTongTien
            // 
            this.txtTongTien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTongTien.Location = new System.Drawing.Point(1085, 586);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(4);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(177, 26);
            this.txtTongTien.TabIndex = 35;
            // 
            // txtKhachDua
            // 
            this.txtKhachDua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtKhachDua.Location = new System.Drawing.Point(1085, 640);
            this.txtKhachDua.Margin = new System.Windows.Forms.Padding(4);
            this.txtKhachDua.Name = "txtKhachDua";
            this.txtKhachDua.Size = new System.Drawing.Size(177, 26);
            this.txtKhachDua.TabIndex = 35;
            this.txtKhachDua.TextChanged += new System.EventHandler(this.txtKhachDua_Changed);
            // 
            // txtTraLai
            // 
            this.txtTraLai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTraLai.Location = new System.Drawing.Point(1085, 689);
            this.txtTraLai.Margin = new System.Windows.Forms.Padding(4);
            this.txtTraLai.Name = "txtTraLai";
            this.txtTraLai.ReadOnly = true;
            this.txtTraLai.Size = new System.Drawing.Size(177, 26);
            this.txtTraLai.TabIndex = 35;
            // 
            // btnDanhSach
            // 
            this.btnDanhSach.Location = new System.Drawing.Point(1171, 37);
            this.btnDanhSach.Name = "btnDanhSach";
            this.btnDanhSach.Size = new System.Drawing.Size(156, 60);
            this.btnDanhSach.TabIndex = 36;
            this.btnDanhSach.Text = "Danh sách đơn đặt";
            this.btnDanhSach.UseVisualStyleBackColor = true;
            this.btnDanhSach.Click += new System.EventHandler(this.btnDanhSach_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.processBar,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 726);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1282, 24);
            this.statusStrip1.TabIndex = 37;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.Visible = false;
            // 
            // processBar
            // 
            this.processBar.Name = "processBar";
            this.processBar.Size = new System.Drawing.Size(100, 18);
            this.processBar.Visible = false;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 19);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(145, 507);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 38;
            this.label5.Text = "label5";
            // 
            // frmKHDat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1408, 824);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDanhSach);
            this.Controls.Add(this.txtTraLai);
            this.Controls.Add(this.txtKhachDua);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.txtTienCoc);
            this.Controls.Add(this.txtTienSp);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTongSanPham);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvSanPhams);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmKHDat";
            this.Text = "danh sách khách hàng dặt";
            this.Load += new System.EventHandler(this.frmKHDat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPhams)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnTimSp)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSanPhams;
        private System.Windows.Forms.TextBox txtTenKh;
        private System.Windows.Forms.TextBox txtSdtKh;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTongSanPham;
        private System.Windows.Forms.Button btnThemSp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbTinhTrang;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpNgayDat;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtMaHd;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnXoaSp;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.PictureBox btnTimSp;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtTienSp;
        private System.Windows.Forms.TextBox txtTienCoc;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.TextBox txtKhachDua;
        private System.Windows.Forms.TextBox txtTraLai;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtTenSp;
        private System.Windows.Forms.ComboBox cbSize;
        private System.Windows.Forms.Button btnDanhSach;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar processBar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.SaveFileDialog saveBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Size;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongDat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mau;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.TextBox txtMau;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label5;
    }
}