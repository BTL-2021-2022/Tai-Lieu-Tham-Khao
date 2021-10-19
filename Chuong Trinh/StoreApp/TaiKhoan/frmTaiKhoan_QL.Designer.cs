
namespace StoreApp.TaiKhoan
{
    partial class frmTaiKhoan_QL
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
            this.but_Thoát = new System.Windows.Forms.Button();
            this.but_Sua = new System.Windows.Forms.Button();
            this.but_Them = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.combo_Loai = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_mk = new System.Windows.Forms.TextBox();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.txt_dc = new System.Windows.Forms.TextBox();
            this.txt_Ten = new System.Windows.Forms.TextBox();
            this.txt_Ma = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.group_Timkiem = new System.Windows.Forms.GroupBox();
            this.but_Tim = new System.Windows.Forms.Button();
            this.txt_MaTim = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.data_QLTK = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.group_Timkiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_QLTK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // but_Thoát
            // 
            this.but_Thoát.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.but_Thoát.Location = new System.Drawing.Point(1264, 345);
            this.but_Thoát.Name = "but_Thoát";
            this.but_Thoát.Size = new System.Drawing.Size(176, 62);
            this.but_Thoát.TabIndex = 17;
            this.but_Thoát.Text = "Thoát";
            this.but_Thoát.UseVisualStyleBackColor = true;
            this.but_Thoát.Click += new System.EventHandler(this.but_Thoát_Click);
            // 
            // but_Sua
            // 
            this.but_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.but_Sua.Location = new System.Drawing.Point(1264, 241);
            this.but_Sua.Name = "but_Sua";
            this.but_Sua.Size = new System.Drawing.Size(176, 59);
            this.but_Sua.TabIndex = 15;
            this.but_Sua.Text = "Sửa ";
            this.but_Sua.UseVisualStyleBackColor = true;
            this.but_Sua.Click += new System.EventHandler(this.but_Sua_Click);
            // 
            // but_Them
            // 
            this.but_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.but_Them.Location = new System.Drawing.Point(1264, 141);
            this.but_Them.Name = "but_Them";
            this.but_Them.Size = new System.Drawing.Size(176, 58);
            this.but_Them.TabIndex = 14;
            this.but_Them.Text = "Thêm";
            this.but_Them.UseVisualStyleBackColor = true;
            this.but_Them.Click += new System.EventHandler(this.but_Them_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.combo_Loai);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_mk);
            this.groupBox1.Controls.Add(this.txt_sdt);
            this.groupBox1.Controls.Add(this.txt_dc);
            this.groupBox1.Controls.Add(this.txt_Ten);
            this.groupBox1.Controls.Add(this.txt_Ma);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(686, 145);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(496, 286);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tài khoản";
            // 
            // combo_Loai
            // 
            this.combo_Loai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.combo_Loai.FormattingEnabled = true;
            this.combo_Loai.Items.AddRange(new object[] {
            "ADMIN",
            "NV",
            "VHH"});
            this.combo_Loai.Location = new System.Drawing.Point(174, 236);
            this.combo_Loai.Name = "combo_Loai";
            this.combo_Loai.Size = new System.Drawing.Size(289, 30);
            this.combo_Loai.TabIndex = 12;
            this.combo_Loai.Validated += new System.EventHandler(this.combo_Loai_Validated);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(49, 242);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 18);
            this.label9.TabIndex = 11;
            this.label9.Text = "Loại tài khoản:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(86, 200);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 18);
            this.label8.TabIndex = 10;
            this.label8.Text = "Mật khẩu:";
            // 
            // txt_mk
            // 
            this.txt_mk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_mk.Location = new System.Drawing.Point(174, 194);
            this.txt_mk.Name = "txt_mk";
            this.txt_mk.Size = new System.Drawing.Size(289, 28);
            this.txt_mk.TabIndex = 6;
            this.txt_mk.Validated += new System.EventHandler(this.txt_mk_Validated);
            // 
            // txt_sdt
            // 
            this.txt_sdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_sdt.Location = new System.Drawing.Point(174, 110);
            this.txt_sdt.MaxLength = 10;
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(289, 28);
            this.txt_sdt.TabIndex = 7;
            this.txt_sdt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sdt_KeyPress);
            this.txt_sdt.Validated += new System.EventHandler(this.txt_sdt_Validated);
            // 
            // txt_dc
            // 
            this.txt_dc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_dc.Location = new System.Drawing.Point(174, 152);
            this.txt_dc.Name = "txt_dc";
            this.txt_dc.Size = new System.Drawing.Size(289, 28);
            this.txt_dc.TabIndex = 6;
            this.txt_dc.Validated += new System.EventHandler(this.txt_dc_Validated);
            // 
            // txt_Ten
            // 
            this.txt_Ten.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_Ten.Location = new System.Drawing.Point(174, 68);
            this.txt_Ten.Name = "txt_Ten";
            this.txt_Ten.Size = new System.Drawing.Size(289, 28);
            this.txt_Ten.TabIndex = 5;
            this.txt_Ten.Validated += new System.EventHandler(this.txt_Ten_Validated);
            // 
            // txt_Ma
            // 
            this.txt_Ma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_Ma.Location = new System.Drawing.Point(174, 34);
            this.txt_Ma.Name = "txt_Ma";
            this.txt_Ma.Size = new System.Drawing.Size(289, 28);
            this.txt_Ma.TabIndex = 4;
            this.txt_Ma.Validated += new System.EventHandler(this.txt_Ma_Validated);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(16, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 18);
            this.label7.TabIndex = 3;
            this.label7.Text = "Địa chỉ người dùng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(56, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 18);
            this.label6.TabIndex = 2;
            this.label6.Text = "Số điện thoại:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(40, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tên người dùng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(132, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã:";
            // 
            // group_Timkiem
            // 
            this.group_Timkiem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.group_Timkiem.Controls.Add(this.but_Tim);
            this.group_Timkiem.Controls.Add(this.txt_MaTim);
            this.group_Timkiem.Controls.Add(this.label3);
            this.group_Timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.group_Timkiem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.group_Timkiem.Location = new System.Drawing.Point(142, 145);
            this.group_Timkiem.Name = "group_Timkiem";
            this.group_Timkiem.Size = new System.Drawing.Size(353, 88);
            this.group_Timkiem.TabIndex = 12;
            this.group_Timkiem.TabStop = false;
            this.group_Timkiem.Text = "Tìm kiếm nhanh";
            // 
            // but_Tim
            // 
            this.but_Tim.Image = global::StoreApp.Properties.Resources.TimNho;
            this.but_Tim.Location = new System.Drawing.Point(317, 44);
            this.but_Tim.Name = "but_Tim";
            this.but_Tim.Size = new System.Drawing.Size(30, 26);
            this.but_Tim.TabIndex = 2;
            this.but_Tim.UseVisualStyleBackColor = true;
            this.but_Tim.Click += new System.EventHandler(this.but_Tim_Click);
            // 
            // txt_MaTim
            // 
            this.txt_MaTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_MaTim.Location = new System.Drawing.Point(126, 40);
            this.txt_MaTim.Name = "txt_MaTim";
            this.txt_MaTim.Size = new System.Drawing.Size(179, 30);
            this.txt_MaTim.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(14, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã tài khoản:";
            // 
            // data_QLTK
            // 
            this.data_QLTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_QLTK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.data_QLTK.Location = new System.Drawing.Point(271, 526);
            this.data_QLTK.Name = "data_QLTK";
            this.data_QLTK.RowHeadersWidth = 51;
            this.data_QLTK.RowTemplate.Height = 24;
            this.data_QLTK.Size = new System.Drawing.Size(987, 304);
            this.data_QLTK.TabIndex = 11;
            this.data_QLTK.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_QLTK_CellContentClick);
            this.data_QLTK.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_QLTK_CellContentClick);
            this.data_QLTK.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.data_QLTK_CellFormatting);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaNQL";
            this.Column1.HeaderText = "Mã tài khoản";
            this.Column1.MinimumWidth = 15;
            this.Column1.Name = "Column1";
            this.Column1.Width = 70;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenNQL";
            this.Column2.HeaderText = "Tên người dùng";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "SDTNQL";
            this.Column3.HeaderText = "Số điện thoại";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 130;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "DiaChiNQL";
            this.Column4.HeaderText = "Địa chỉ người dùng";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 270;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "MatKhau";
            this.Column5.HeaderText = "Mật khẩu";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 130;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "TinhTrang";
            this.Column6.HeaderText = "Loại tài khoản";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 130;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(271, 463);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "Danh sách tài khoản:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(690, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "QUẢN LÝ TÀI KHOẢN";
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // frmTaiKhoan_QL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1597, 842);
            this.Controls.Add(this.but_Thoát);
            this.Controls.Add(this.but_Sua);
            this.Controls.Add(this.but_Them);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.group_Timkiem);
            this.Controls.Add(this.data_QLTK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "frmTaiKhoan_QL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTaiKhoan_QL";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTaiKhoan_QL_Load);
            this.Click += new System.EventHandler(this.frmTaiKhoan_QL_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.group_Timkiem.ResumeLayout(false);
            this.group_Timkiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_QLTK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but_Thoát;
        private System.Windows.Forms.Button but_Sua;
        private System.Windows.Forms.Button but_Them;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox combo_Loai;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_mk;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.TextBox txt_dc;
        private System.Windows.Forms.TextBox txt_Ten;
        private System.Windows.Forms.TextBox txt_Ma;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox group_Timkiem;
        private System.Windows.Forms.Button but_Tim;
        private System.Windows.Forms.TextBox txt_MaTim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView data_QLTK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.ErrorProvider error;
    }
}