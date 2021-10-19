
namespace StoreApp.QuanLySanPham
{
    partial class HoaDon7Ngay
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
            this.but_Tim = new System.Windows.Forms.Button();
            this.txt_Sohoadon = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.data_dshoadon = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.but_doitra = new System.Windows.Forms.Button();
            this.but_thoat = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_shd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Ngaylap = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_dshoadon)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(438, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(787, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH HÓA ĐƠN TRONG VÒNG 7 NGÀY GẦN ĐÂY";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.but_Tim);
            this.groupBox1.Controls.Add(this.txt_Sohoadon);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Location = new System.Drawing.Point(72, 216);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(542, 104);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TÌM KIẾM NHANH";
            // 
            // but_Tim
            // 
            this.but_Tim.Image = global::StoreApp.Properties.Resources.TimNho1;
            this.but_Tim.Location = new System.Drawing.Point(485, 45);
            this.but_Tim.Name = "but_Tim";
            this.but_Tim.Size = new System.Drawing.Size(32, 31);
            this.but_Tim.TabIndex = 14;
            this.but_Tim.UseVisualStyleBackColor = true;
            this.but_Tim.Click += new System.EventHandler(this.but_Tim_Click);
            // 
            // txt_Sohoadon
            // 
            this.txt_Sohoadon.Location = new System.Drawing.Point(192, 42);
            this.txt_Sohoadon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Sohoadon.Name = "txt_Sohoadon";
            this.txt_Sohoadon.Size = new System.Drawing.Size(269, 34);
            this.txt_Sohoadon.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(18, 45);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(117, 28);
            this.label13.TabIndex = 11;
            this.label13.Text = "Số hóa đơn";
            // 
            // data_dshoadon
            // 
            this.data_dshoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_dshoadon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column3});
            this.data_dshoadon.Location = new System.Drawing.Point(72, 459);
            this.data_dshoadon.Name = "data_dshoadon";
            this.data_dshoadon.RowHeadersWidth = 51;
            this.data_dshoadon.RowTemplate.Height = 29;
            this.data_dshoadon.Size = new System.Drawing.Size(934, 458);
            this.data_dshoadon.TabIndex = 2;
            this.data_dshoadon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_dshoadon_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "SoHD";
            this.Column1.HeaderText = "Mã hóa đơn";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 90;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MaSP";
            this.Column2.HeaderText = "Mã sản phẩm";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 90;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "SoLuongBan";
            this.Column5.HeaderText = "Số lượng bán";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 90;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "GiaBan";
            this.Column6.HeaderText = "Giá bán";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 140;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "ThanhTien";
            this.Column7.HeaderText = "Thành tiền";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 140;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "NgayBan";
            this.Column8.HeaderText = "Ngày bán";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 200;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Mau";
            this.Column3.HeaderText = "Màu";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(85, 378);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(529, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Danh sách hóa đơn đã bán trong vòng 7 ngày gần đây";
            // 
            // but_doitra
            // 
            this.but_doitra.Location = new System.Drawing.Point(1319, 598);
            this.but_doitra.Name = "but_doitra";
            this.but_doitra.Size = new System.Drawing.Size(113, 37);
            this.but_doitra.TabIndex = 4;
            this.but_doitra.Text = "Đổi trả";
            this.but_doitra.UseVisualStyleBackColor = true;
            this.but_doitra.Click += new System.EventHandler(this.but_doitra_Click);
            // 
            // but_thoat
            // 
            this.but_thoat.Location = new System.Drawing.Point(1319, 673);
            this.but_thoat.Name = "but_thoat";
            this.but_thoat.Size = new System.Drawing.Size(113, 38);
            this.but_thoat.TabIndex = 5;
            this.but_thoat.Text = "Thoát";
            this.but_thoat.UseVisualStyleBackColor = true;
            this.but_thoat.Click += new System.EventHandler(this.but_thoat_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_shd);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_Ngaylap);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(904, 216);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(528, 204);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin hóa đơn";
            // 
            // txt_shd
            // 
            this.txt_shd.Enabled = false;
            this.txt_shd.Location = new System.Drawing.Point(183, 51);
            this.txt_shd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_shd.Name = "txt_shd";
            this.txt_shd.Size = new System.Drawing.Size(269, 34);
            this.txt_shd.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 28);
            this.label4.TabIndex = 16;
            this.label4.Text = "Số hóa đơn";
            // 
            // txt_Ngaylap
            // 
            this.txt_Ngaylap.Enabled = false;
            this.txt_Ngaylap.Location = new System.Drawing.Point(183, 128);
            this.txt_Ngaylap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Ngaylap.Name = "txt_Ngaylap";
            this.txt_Ngaylap.Size = new System.Drawing.Size(269, 34);
            this.txt_Ngaylap.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 28);
            this.label3.TabIndex = 14;
            this.label3.Text = "Ngày lập";
            // 
            // HoaDon7Ngay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1700, 1055);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.but_thoat);
            this.Controls.Add(this.but_doitra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.data_dshoadon);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HoaDon7Ngay";
            this.Text = "HoaDon7Ngay";
            this.Load += new System.EventHandler(this.HoaDon7Ngay_Load);
            this.Click += new System.EventHandler(this.HoaDon7Ngay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_dshoadon)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button but_Tim;
        private System.Windows.Forms.TextBox txt_Sohoadon;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView data_dshoadon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button but_doitra;
        private System.Windows.Forms.Button but_thoat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_shd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Ngaylap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}