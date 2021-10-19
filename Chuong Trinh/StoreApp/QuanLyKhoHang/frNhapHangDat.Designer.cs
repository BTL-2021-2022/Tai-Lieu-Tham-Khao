
namespace StoreApp.QuanLyKhoHang
{
    partial class frNhapHangDat
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.date_lap = new System.Windows.Forms.DateTimePicker();
            this.txt_tenncc = new System.Windows.Forms.TextBox();
            this.txt_sohd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.soluong1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.data_hangdat = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.data_hangnhap = new System.Windows.Forms.DataGridView();
            this.ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_hangdat)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_hangnhap)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(336, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập hàng vào kho";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.date_lap);
            this.groupBox1.Controls.Add(this.txt_tenncc);
            this.groupBox1.Controls.Add(this.txt_sohd);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(959, 71);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hóa đơn nhập";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // date_lap
            // 
            this.date_lap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_lap.Location = new System.Drawing.Point(770, 26);
            this.date_lap.Name = "date_lap";
            this.date_lap.Size = new System.Drawing.Size(160, 27);
            this.date_lap.TabIndex = 5;
            // 
            // txt_tenncc
            // 
            this.txt_tenncc.Location = new System.Drawing.Point(476, 26);
            this.txt_tenncc.Name = "txt_tenncc";
            this.txt_tenncc.ReadOnly = true;
            this.txt_tenncc.Size = new System.Drawing.Size(170, 27);
            this.txt_tenncc.TabIndex = 4;
            // 
            // txt_sohd
            // 
            this.txt_sohd.Location = new System.Drawing.Point(111, 26);
            this.txt_sohd.Name = "txt_sohd";
            this.txt_sohd.ReadOnly = true;
            this.txt_sohd.Size = new System.Drawing.Size(140, 27);
            this.txt_sohd.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(692, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ngày lập:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số hóa đơn:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(343, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên nhà cung cấp:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.soluong1);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.data_hangdat);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(16, 128);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(954, 288);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin hàng đặt";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // soluong1
            // 
            this.soluong1.Location = new System.Drawing.Point(154, 207);
            this.soluong1.Name = "soluong1";
            this.soluong1.Size = new System.Drawing.Size(93, 27);
            this.soluong1.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(357, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(242, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "Nhập hàng";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // data_hangdat
            // 
            this.data_hangdat.AllowUserToAddRows = false;
            this.data_hangdat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_hangdat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_hangdat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column13,
            this.Column4,
            this.Column5,
            this.Column6});
            this.data_hangdat.Location = new System.Drawing.Point(28, 42);
            this.data_hangdat.Name = "data_hangdat";
            this.data_hangdat.RowHeadersVisible = false;
            this.data_hangdat.RowHeadersWidth = 51;
            this.data_hangdat.RowTemplate.Height = 29;
            this.data_hangdat.Size = new System.Drawing.Size(898, 148);
            this.data_hangdat.TabIndex = 5;
            this.data_hangdat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.show);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã sản phẩm";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên sản phẩm";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Size";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Màu";
            this.Column13.MinimumWidth = 6;
            this.Column13.Name = "Column13";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Số lượng đặt";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Đơn giá đặt";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Thành tiền";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Số lượng nhập:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.data_hangnhap);
            this.groupBox3.Location = new System.Drawing.Point(16, 433);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(954, 278);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin nhập hàng";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // data_hangnhap
            // 
            this.data_hangnhap.AllowUserToAddRows = false;
            this.data_hangnhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_hangnhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_hangnhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ma,
            this.ten,
            this.size,
            this.mau,
            this.sl,
            this.dongia,
            this.thanhtien});
            this.data_hangnhap.Location = new System.Drawing.Point(29, 35);
            this.data_hangnhap.Name = "data_hangnhap";
            this.data_hangnhap.RowHeadersVisible = false;
            this.data_hangnhap.RowHeadersWidth = 51;
            this.data_hangnhap.RowTemplate.Height = 29;
            this.data_hangnhap.Size = new System.Drawing.Size(897, 160);
            this.data_hangnhap.TabIndex = 14;
            // 
            // ma
            // 
            this.ma.HeaderText = "Mã sản phẩm";
            this.ma.MinimumWidth = 6;
            this.ma.Name = "ma";
            // 
            // ten
            // 
            this.ten.HeaderText = "Tên sản phẩm";
            this.ten.MinimumWidth = 6;
            this.ten.Name = "ten";
            // 
            // size
            // 
            this.size.HeaderText = "Size";
            this.size.MinimumWidth = 6;
            this.size.Name = "size";
            // 
            // mau
            // 
            this.mau.HeaderText = "Màu";
            this.mau.MinimumWidth = 6;
            this.mau.Name = "mau";
            // 
            // sl
            // 
            this.sl.HeaderText = "Số lượng nhập";
            this.sl.MinimumWidth = 6;
            this.sl.Name = "sl";
            // 
            // dongia
            // 
            this.dongia.HeaderText = "Đơn giá nhập";
            this.dongia.MinimumWidth = 6;
            this.dongia.Name = "dongia";
            // 
            // thanhtien
            // 
            this.thanhtien.HeaderText = "Thành tiền";
            this.thanhtien.MinimumWidth = 6;
            this.thanhtien.Name = "thanhtien";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(357, 224);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(242, 35);
            this.button3.TabIndex = 13;
            this.button3.Text = "Xóa hàng nhập";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(339, 747);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(319, 42);
            this.button4.TabIndex = 4;
            this.button4.Text = "Hoàn tất";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // frNhapHangDat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 826);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frNhapHangDat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frNhapHangDat";
            this.Load += new System.EventHandler(this.frNhapHangDat_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_hangdat)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_hangnhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView data_hangdat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox soluong1;
        private System.Windows.Forms.DataGridView data_hangnhap;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DateTimePicker date_lap;
        private System.Windows.Forms.TextBox txt_tenncc;
        private System.Windows.Forms.TextBox txt_sohd;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn size;
        private System.Windows.Forms.DataGridViewTextBoxColumn mau;
        private System.Windows.Forms.DataGridViewTextBoxColumn sl;
        private System.Windows.Forms.DataGridViewTextBoxColumn dongia;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhtien;
    }
}