
namespace StoreApp.QuanLyKhoHang
{
    partial class frNhaCungCap
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
            this.data_ncc = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cb_tinhtrang = new System.Windows.Forms.ComboBox();
            this.txt_ten = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_ma = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.but_Tim = new System.Windows.Forms.Button();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.but_Them = new System.Windows.Forms.Button();
            this.but_Sua = new System.Windows.Forms.Button();
            this.but_Thoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data_ncc)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // data_ncc
            // 
            this.data_ncc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.data_ncc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_ncc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_ncc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.data_ncc.Location = new System.Drawing.Point(44, 488);
            this.data_ncc.Name = "data_ncc";
            this.data_ncc.RowHeadersVisible = false;
            this.data_ncc.RowHeadersWidth = 51;
            this.data_ncc.RowTemplate.Height = 24;
            this.data_ncc.Size = new System.Drawing.Size(1009, 199);
            this.data_ncc.TabIndex = 1;
            this.data_ncc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.show);
            this.data_ncc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_ncc_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã nhà cung cấp";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên nhà cung cấp";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Số diện thoại";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Địa chỉ";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Tình trạng";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // cb_tinhtrang
            // 
            this.cb_tinhtrang.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cb_tinhtrang.FormattingEnabled = true;
            this.cb_tinhtrang.Items.AddRange(new object[] {
            "N",
            "K"});
            this.cb_tinhtrang.Location = new System.Drawing.Point(201, 259);
            this.cb_tinhtrang.Name = "cb_tinhtrang";
            this.cb_tinhtrang.Size = new System.Drawing.Size(220, 28);
            this.cb_tinhtrang.TabIndex = 4;
            // 
            // txt_ten
            // 
            this.txt_ten.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_ten.Location = new System.Drawing.Point(201, 103);
            this.txt_ten.Name = "txt_ten";
            this.txt_ten.Size = new System.Drawing.Size(220, 27);
            this.txt_ten.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên nhà cung cấp";
            // 
            // txt_sdt
            // 
            this.txt_sdt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_sdt.Location = new System.Drawing.Point(201, 155);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(220, 27);
            this.txt_sdt.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Số điện thoại";
            // 
            // txt_diachi
            // 
            this.txt_diachi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_diachi.Location = new System.Drawing.Point(201, 207);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(220, 27);
            this.txt_diachi.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(114, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Địa chỉ";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tình trạng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(371, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 36);
            this.label1.TabIndex = 12;
            this.label1.Text = "NHÀ CUNG CẤP";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_ma);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_ten);
            this.groupBox1.Controls.Add(this.cb_tinhtrang);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_diachi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_sdt);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(44, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(445, 298);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhà cung cấp";
            // 
            // txt_ma
            // 
            this.txt_ma.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_ma.Location = new System.Drawing.Point(201, 51);
            this.txt_ma.Name = "txt_ma";
            this.txt_ma.Size = new System.Drawing.Size(220, 27);
            this.txt_ma.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Mã nhà cung cấp";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(39, 435);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(295, 29);
            this.label7.TabIndex = 14;
            this.label7.Text = "Danh sách nhà cung cấp";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.but_Tim);
            this.groupBox2.Controls.Add(this.txt_timkiem);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(589, 88);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(464, 143);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm nhanh";
            // 
            // but_Tim
            // 
            this.but_Tim.Location = new System.Drawing.Point(395, 60);
            this.but_Tim.Name = "but_Tim";
            this.but_Tim.Size = new System.Drawing.Size(51, 41);
            this.but_Tim.TabIndex = 0;
            this.but_Tim.UseVisualStyleBackColor = true;
            this.but_Tim.Click += new System.EventHandler(this.but_Tim_Click_1);
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_timkiem.Location = new System.Drawing.Point(191, 67);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(186, 27);
            this.txt_timkiem.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Tên nhà cung cấp";
            // 
            // but_Them
            // 
            this.but_Them.Location = new System.Drawing.Point(944, 273);
            this.but_Them.Name = "but_Them";
            this.but_Them.Size = new System.Drawing.Size(109, 35);
            this.but_Them.TabIndex = 1;
            this.but_Them.Text = "Thêm";
            this.but_Them.UseVisualStyleBackColor = true;
            this.but_Them.Click += new System.EventHandler(this.but_Them_Click_1);
            // 
            // but_Sua
            // 
            this.but_Sua.Location = new System.Drawing.Point(944, 342);
            this.but_Sua.Name = "but_Sua";
            this.but_Sua.Size = new System.Drawing.Size(109, 37);
            this.but_Sua.TabIndex = 2;
            this.but_Sua.Text = "Sửa";
            this.but_Sua.UseVisualStyleBackColor = true;
            this.but_Sua.Click += new System.EventHandler(this.but_Sua_Click_1);
            // 
            // but_Thoat
            // 
            this.but_Thoat.Location = new System.Drawing.Point(944, 723);
            this.but_Thoat.Name = "but_Thoat";
            this.but_Thoat.Size = new System.Drawing.Size(109, 37);
            this.but_Thoat.TabIndex = 16;
            this.but_Thoat.Text = "Thoát";
            this.but_Thoat.UseVisualStyleBackColor = true;
            // 
            // frNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1236, 772);
            this.Controls.Add(this.but_Thoat);
            this.Controls.Add(this.but_Them);
            this.Controls.Add(this.but_Sua);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.data_ncc);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frNhaCungCap";
            this.Text = "NhaCungCap";
            this.Load += new System.EventHandler(this.frNhaCungCap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_ncc)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView data_ncc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.ComboBox cb_tinhtrang;
        private System.Windows.Forms.TextBox txt_ten;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_ma;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button but_Tim;
        private System.Windows.Forms.TextBox txt_timkiem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button but_Them;
        private System.Windows.Forms.Button but_Sua;
        private System.Windows.Forms.Button but_Thoat;
    }
}