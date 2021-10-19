
namespace StoreApp
{
    partial class frmSPham
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
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnTimTheoMa = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTimmaSP = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTimTheoTen = new System.Windows.Forms.Button();
            this.txtTimTenSP = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMauSPham = new System.Windows.Forms.TextBox();
            this.txtOrderLevel = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtThongTin = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbTinhTrang = new System.Windows.Forms.ComboBox();
            this.txtSlcon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbsize = new System.Windows.Forms.ComboBox();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dgvsanpham = new System.Windows.Forms.DataGridView();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThongTin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSoLuong = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLCon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSuaSPham = new System.Windows.Forms.Button();
            this.btnThemSPham = new System.Windows.Forms.Button();
            this.btnXoaSPham = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsanpham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLamMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLamMoi.Location = new System.Drawing.Point(1147, 450);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(124, 54);
            this.btnLamMoi.TabIndex = 18;
            this.btnLamMoi.Text = "Nhập lại";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnTimTheoMa
            // 
            this.btnTimTheoMa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimTheoMa.Location = new System.Drawing.Point(328, 24);
            this.btnTimTheoMa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimTheoMa.Name = "btnTimTheoMa";
            this.btnTimTheoMa.Size = new System.Drawing.Size(137, 42);
            this.btnTimTheoMa.TabIndex = 2;
            this.btnTimTheoMa.Text = "Tìm theo mã";
            this.btnTimTheoMa.UseVisualStyleBackColor = true;
            this.btnTimTheoMa.Click += new System.EventHandler(this.btnTimTheoMa_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 22);
            this.label8.TabIndex = 1;
            this.label8.Text = "Tên sản phẩm";
            // 
            // txtTimmaSP
            // 
            this.txtTimmaSP.Location = new System.Drawing.Point(152, 29);
            this.txtTimmaSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimmaSP.Name = "txtTimmaSP";
            this.txtTimmaSP.Size = new System.Drawing.Size(136, 30);
            this.txtTimmaSP.TabIndex = 0;
            this.txtTimmaSP.TextChanged += new System.EventHandler(this.txtTimmaSP_TextChanged);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(26, 32);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(107, 35);
            this.btnThoat.TabIndex = 20;
            this.btnThoat.Text = "Quay lại";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnTimTheoTen
            // 
            this.btnTimTheoTen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimTheoTen.Location = new System.Drawing.Point(328, 80);
            this.btnTimTheoTen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimTheoTen.Name = "btnTimTheoTen";
            this.btnTimTheoTen.Size = new System.Drawing.Size(137, 36);
            this.btnTimTheoTen.TabIndex = 3;
            this.btnTimTheoTen.Text = "Tìm theo tên";
            this.btnTimTheoTen.UseVisualStyleBackColor = true;
            this.btnTimTheoTen.Click += new System.EventHandler(this.btnTimTheoTen_Click);
            // 
            // txtTimTenSP
            // 
            this.txtTimTenSP.Location = new System.Drawing.Point(152, 74);
            this.txtTimTenSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimTenSP.Name = "txtTimTenSP";
            this.txtTimTenSP.Size = new System.Drawing.Size(136, 30);
            this.txtTimTenSP.TabIndex = 1;
            this.txtTimTenSP.TextChanged += new System.EventHandler(this.txtTimTenSP_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 22);
            this.label7.TabIndex = 0;
            this.label7.Text = "Mã sản phẩm";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(525, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(181, 36);
            this.label9.TabIndex = 23;
            this.label9.Text = "SẢN PHẨM";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnTimTheoTen);
            this.groupBox3.Controls.Add(this.txtTimTenSP);
            this.groupBox3.Controls.Add(this.txtTimmaSP);
            this.groupBox3.Controls.Add(this.btnTimTheoMa);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(13, 152);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(498, 130);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm nhanh";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMauSPham);
            this.groupBox1.Controls.Add(this.txtOrderLevel);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtThongTin);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbbTinhTrang);
            this.groupBox1.Controls.Add(this.txtSlcon);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbbsize);
            this.groupBox1.Controls.Add(this.txtGiaBan);
            this.groupBox1.Controls.Add(this.txtTenSP);
            this.groupBox1.Controls.Add(this.txtMaSP);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(584, 104);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(647, 325);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sản phẩm";
            // 
            // txtMauSPham
            // 
            this.txtMauSPham.Location = new System.Drawing.Point(147, 275);
            this.txtMauSPham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMauSPham.MaxLength = 15;
            this.txtMauSPham.Name = "txtMauSPham";
            this.txtMauSPham.Size = new System.Drawing.Size(116, 30);
            this.txtMauSPham.TabIndex = 18;
            this.txtMauSPham.Validated += new System.EventHandler(this.txtMauSPham_Validated);
            // 
            // txtOrderLevel
            // 
            this.txtOrderLevel.Location = new System.Drawing.Point(434, 273);
            this.txtOrderLevel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOrderLevel.MaxLength = 15;
            this.txtOrderLevel.Name = "txtOrderLevel";
            this.txtOrderLevel.Size = new System.Drawing.Size(116, 30);
            this.txtOrderLevel.TabIndex = 16;
            this.txtOrderLevel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOrderLevel_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(313, 281);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(107, 22);
            this.label13.TabIndex = 17;
            this.label13.Text = "Order Level";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(83, 278);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 22);
            this.label12.TabIndex = 15;
            this.label12.Text = "Màu";
            // 
            // txtThongTin
            // 
            this.txtThongTin.Location = new System.Drawing.Point(147, 149);
            this.txtThongTin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtThongTin.MaxLength = 15;
            this.txtThongTin.Name = "txtThongTin";
            this.txtThongTin.Size = new System.Drawing.Size(342, 30);
            this.txtThongTin.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(43, 157);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 22);
            this.label11.TabIndex = 13;
            this.label11.Text = "Thông tin";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(330, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 22);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tình trạng";
            // 
            // cbbTinhTrang
            // 
            this.cbbTinhTrang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTinhTrang.FormattingEnabled = true;
            this.cbbTinhTrang.Items.AddRange(new object[] {
            "N",
            "K"});
            this.cbbTinhTrang.Location = new System.Drawing.Point(434, 83);
            this.cbbTinhTrang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbTinhTrang.Name = "cbbTinhTrang";
            this.cbbTinhTrang.Size = new System.Drawing.Size(116, 30);
            this.cbbTinhTrang.TabIndex = 3;
            this.cbbTinhTrang.Validated += new System.EventHandler(this.cbbTinhTrang_Validated);
            // 
            // txtSlcon
            // 
            this.txtSlcon.Location = new System.Drawing.Point(434, 202);
            this.txtSlcon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSlcon.MaxLength = 15;
            this.txtSlcon.Name = "txtSlcon";
            this.txtSlcon.Size = new System.Drawing.Size(116, 30);
            this.txtSlcon.TabIndex = 5;
            this.txtSlcon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSlcon_KeyPress);
            this.txtSlcon.Validated += new System.EventHandler(this.txtSlcon_Validated);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(313, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Số lượng còn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Size";
            // 
            // cbbsize
            // 
            this.cbbsize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbsize.FormattingEnabled = true;
            this.cbbsize.Items.AddRange(new object[] {
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
            this.cbbsize.Location = new System.Drawing.Point(147, 204);
            this.cbbsize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbsize.Name = "cbbsize";
            this.cbbsize.Size = new System.Drawing.Size(116, 30);
            this.cbbsize.TabIndex = 4;
            this.cbbsize.Validated += new System.EventHandler(this.cbbsize_Validated);
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Location = new System.Drawing.Point(147, 82);
            this.txtGiaBan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGiaBan.MaxLength = 15;
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(116, 30);
            this.txtGiaBan.TabIndex = 2;
            this.txtGiaBan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaBan_KeyPress);
            this.txtGiaBan.Validated += new System.EventHandler(this.txtGiaBan_Validated);
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(434, 27);
            this.txtTenSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenSP.MaxLength = 15;
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(207, 30);
            this.txtTenSP.TabIndex = 1;
            this.txtTenSP.Validated += new System.EventHandler(this.txtTenSP_Validated);
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(147, 31);
            this.txtMaSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(116, 30);
            this.txtMaSP.TabIndex = 0;
            this.txtMaSP.Validated += new System.EventHandler(this.txtMaSP_Validated);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "Giá bán";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(310, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên sản phẩm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sản phẩm";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dgvsanpham
            // 
            this.dgvsanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsanpham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSP,
            this.TenSP,
            this.GiaBan,
            this.TinhTrang,
            this.ThongTin});
            this.dgvsanpham.Location = new System.Drawing.Point(26, 642);
            this.dgvsanpham.Margin = new System.Windows.Forms.Padding(4);
            this.dgvsanpham.Name = "dgvsanpham";
            this.dgvsanpham.RowHeadersWidth = 51;
            this.dgvsanpham.Size = new System.Drawing.Size(639, 292);
            this.dgvsanpham.TabIndex = 32;
            this.dgvsanpham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvsanpham_CellContentClick_1);
            // 
            // MaSP
            // 
            this.MaSP.DataPropertyName = "MaSP";
            this.MaSP.HeaderText = "Mã sản phẩm";
            this.MaSP.MinimumWidth = 6;
            this.MaSP.Name = "MaSP";
            this.MaSP.Width = 125;
            // 
            // TenSP
            // 
            this.TenSP.DataPropertyName = "TenSP";
            this.TenSP.HeaderText = "Tên sản phẩm";
            this.TenSP.MinimumWidth = 6;
            this.TenSP.Name = "TenSP";
            this.TenSP.Width = 175;
            // 
            // GiaBan
            // 
            this.GiaBan.DataPropertyName = "GiaBan";
            this.GiaBan.HeaderText = "Giá Bán";
            this.GiaBan.MinimumWidth = 6;
            this.GiaBan.Name = "GiaBan";
            this.GiaBan.Width = 125;
            // 
            // TinhTrang
            // 
            this.TinhTrang.DataPropertyName = "TinhTrang";
            this.TinhTrang.HeaderText = "Tình Trạng";
            this.TinhTrang.MinimumWidth = 6;
            this.TinhTrang.Name = "TinhTrang";
            this.TinhTrang.Width = 125;
            // 
            // ThongTin
            // 
            this.ThongTin.DataPropertyName = "ThongTin";
            this.ThongTin.HeaderText = "Thông Tin";
            this.ThongTin.MinimumWidth = 6;
            this.ThongTin.Name = "ThongTin";
            this.ThongTin.Width = 200;
            // 
            // dgvSoLuong
            // 
            this.dgvSoLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSoLuong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.Size,
            this.Mau,
            this.SLCon,
            this.OrderLevel});
            this.dgvSoLuong.Location = new System.Drawing.Point(731, 642);
            this.dgvSoLuong.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSoLuong.Name = "dgvSoLuong";
            this.dgvSoLuong.RowHeadersWidth = 51;
            this.dgvSoLuong.Size = new System.Drawing.Size(569, 292);
            this.dgvSoLuong.TabIndex = 33;
            this.dgvSoLuong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSoLuong_CellContentClick_1);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenSp";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên sản phẩm";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 175;
            // 
            // Size
            // 
            this.Size.DataPropertyName = "Size";
            this.Size.HeaderText = "Size";
            this.Size.MinimumWidth = 6;
            this.Size.Name = "Size";
            this.Size.Width = 125;
            // 
            // Mau
            // 
            this.Mau.DataPropertyName = "Mau";
            this.Mau.HeaderText = "Màu";
            this.Mau.MinimumWidth = 6;
            this.Mau.Name = "Mau";
            this.Mau.Width = 125;
            // 
            // SLCon
            // 
            this.SLCon.DataPropertyName = "SLCon";
            this.SLCon.HeaderText = "Số lượng còn";
            this.SLCon.MinimumWidth = 6;
            this.SLCon.Name = "SLCon";
            this.SLCon.Width = 125;
            // 
            // OrderLevel
            // 
            this.OrderLevel.DataPropertyName = "OrderLevel";
            this.OrderLevel.HeaderText = "Order Level";
            this.OrderLevel.MinimumWidth = 6;
            this.OrderLevel.Name = "OrderLevel";
            this.OrderLevel.Width = 125;
            // 
            // btnSuaSPham
            // 
            this.btnSuaSPham.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSuaSPham.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaSPham.Location = new System.Drawing.Point(760, 450);
            this.btnSuaSPham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSuaSPham.Name = "btnSuaSPham";
            this.btnSuaSPham.Size = new System.Drawing.Size(133, 59);
            this.btnSuaSPham.TabIndex = 34;
            this.btnSuaSPham.Text = "Sửa thông tin sản phẩm";
            this.btnSuaSPham.UseVisualStyleBackColor = true;
            this.btnSuaSPham.Click += new System.EventHandler(this.btnSuaSPham_Click);
            // 
            // btnThemSPham
            // 
            this.btnThemSPham.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnThemSPham.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemSPham.Location = new System.Drawing.Point(543, 450);
            this.btnThemSPham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemSPham.Name = "btnThemSPham";
            this.btnThemSPham.Size = new System.Drawing.Size(163, 59);
            this.btnThemSPham.TabIndex = 35;
            this.btnThemSPham.Text = "Thêm sản phẩm";
            this.btnThemSPham.UseVisualStyleBackColor = true;
            this.btnThemSPham.Click += new System.EventHandler(this.btnThemSPham_Click);
            // 
            // btnXoaSPham
            // 
            this.btnXoaSPham.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnXoaSPham.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaSPham.Location = new System.Drawing.Point(948, 450);
            this.btnXoaSPham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoaSPham.Name = "btnXoaSPham";
            this.btnXoaSPham.Size = new System.Drawing.Size(163, 59);
            this.btnXoaSPham.TabIndex = 36;
            this.btnXoaSPham.Text = "Xoá sản phẩm";
            this.btnXoaSPham.UseVisualStyleBackColor = true;
            this.btnXoaSPham.Click += new System.EventHandler(this.btnXoaSPham_Click);
            // 
            // frmSPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1787, 1055);
            this.Controls.Add(this.btnXoaSPham);
            this.Controls.Add(this.btnThemSPham);
            this.Controls.Add(this.btnSuaSPham);
            this.Controls.Add(this.dgvSoLuong);
            this.Controls.Add(this.dgvsanpham);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmSPham";
            this.Text = "frmSPham";
            this.Load += new System.EventHandler(this.frmSPham_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsanpham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnTimTheoMa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTimmaSP;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTimTheoTen;
        private System.Windows.Forms.TextBox txtTimTenSP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbTinhTrang;
        private System.Windows.Forms.TextBox txtSlcon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbsize;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView dgvSoLuong;
        private System.Windows.Forms.DataGridView dgvsanpham;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThongTin;
        private System.Windows.Forms.TextBox txtOrderLevel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtThongTin;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnXoaSPham;
        private System.Windows.Forms.Button btnThemSPham;
        private System.Windows.Forms.Button btnSuaSPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Size;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mau;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLCon;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderLevel;
        private System.Windows.Forms.TextBox txtMauSPham;
    }
}