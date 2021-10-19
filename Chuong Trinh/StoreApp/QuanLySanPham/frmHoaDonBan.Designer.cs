
namespace StoreApp
{
    partial class frmHoaDonBan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.txtngayban = new System.Windows.Forms.TextBox();
            this.txtsohd = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXemChiTiet = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXemHDTheoKH = new System.Windows.Forms.Button();
            this.btnXemHDTheoNQL = new System.Windows.Forms.Button();
            this.cbbHDTheoKH = new System.Windows.Forms.ComboBox();
            this.cbbHDTheoNQL = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbltongsohoadondanhap = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SoHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrangDoiTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvHoaDon
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dgvHoaDon.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SoHD,
            this.NgayBan,
            this.TinhTrangDoiTra});
            this.dgvHoaDon.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvHoaDon.Location = new System.Drawing.Point(99, 466);
            this.dgvHoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.ReadOnly = true;
            this.dgvHoaDon.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dgvHoaDon.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHoaDon.RowTemplate.Height = 24;
            this.dgvHoaDon.Size = new System.Drawing.Size(463, 263);
            this.dgvHoaDon.TabIndex = 16;
            this.dgvHoaDon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDon_CellContentClick);
            // 
            // txtngayban
            // 
            this.txtngayban.Enabled = false;
            this.txtngayban.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtngayban.Location = new System.Drawing.Point(864, 472);
            this.txtngayban.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtngayban.Name = "txtngayban";
            this.txtngayban.Size = new System.Drawing.Size(234, 30);
            this.txtngayban.TabIndex = 14;
            // 
            // txtsohd
            // 
            this.txtsohd.Enabled = false;
            this.txtsohd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtsohd.Location = new System.Drawing.Point(864, 417);
            this.txtsohd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtsohd.Name = "txtsohd";
            this.txtsohd.Size = new System.Drawing.Size(234, 30);
            this.txtsohd.TabIndex = 15;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(864, 605);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(148, 46);
            this.btnThoat.TabIndex = 12;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXemChiTiet
            // 
            this.btnXemChiTiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnXemChiTiet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXemChiTiet.Location = new System.Drawing.Point(864, 549);
            this.btnXemChiTiet.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnXemChiTiet.Name = "btnXemChiTiet";
            this.btnXemChiTiet.Size = new System.Drawing.Size(148, 44);
            this.btnXemChiTiet.TabIndex = 13;
            this.btnXemChiTiet.Text = "Xem chi tiết";
            this.btnXemChiTiet.UseVisualStyleBackColor = true;
            this.btnXemChiTiet.Click += new System.EventHandler(this.btnXemChiTiet_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(731, 482);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 22);
            this.label4.TabIndex = 11;
            this.label4.Text = "Ngày bán";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(731, 417);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 22);
            this.label2.TabIndex = 10;
            this.label2.Text = "Số hóa đơn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(172, 417);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 26);
            this.label1.TabIndex = 9;
            this.label1.Text = "Những hóa đơn đã bán:";
            // 
            // btnXemHDTheoKH
            // 
            this.btnXemHDTheoKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnXemHDTheoKH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXemHDTheoKH.Location = new System.Drawing.Point(24, 149);
            this.btnXemHDTheoKH.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnXemHDTheoKH.Name = "btnXemHDTheoKH";
            this.btnXemHDTheoKH.Size = new System.Drawing.Size(92, 38);
            this.btnXemHDTheoKH.TabIndex = 17;
            this.btnXemHDTheoKH.Text = "XEM";
            this.btnXemHDTheoKH.UseVisualStyleBackColor = true;
            this.btnXemHDTheoKH.Click += new System.EventHandler(this.btnXemHDTheoKH_Click);
            // 
            // btnXemHDTheoNQL
            // 
            this.btnXemHDTheoNQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnXemHDTheoNQL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXemHDTheoNQL.Location = new System.Drawing.Point(32, 149);
            this.btnXemHDTheoNQL.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnXemHDTheoNQL.Name = "btnXemHDTheoNQL";
            this.btnXemHDTheoNQL.Size = new System.Drawing.Size(111, 38);
            this.btnXemHDTheoNQL.TabIndex = 18;
            this.btnXemHDTheoNQL.Text = "XEM";
            this.btnXemHDTheoNQL.UseVisualStyleBackColor = true;
            this.btnXemHDTheoNQL.Click += new System.EventHandler(this.btnXemHDTheoNQL_Click);
            // 
            // cbbHDTheoKH
            // 
            this.cbbHDTheoKH.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbHDTheoKH.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbHDTheoKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbbHDTheoKH.FormattingEnabled = true;
            this.cbbHDTheoKH.Location = new System.Drawing.Point(8, 95);
            this.cbbHDTheoKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbHDTheoKH.Name = "cbbHDTheoKH";
            this.cbbHDTheoKH.Size = new System.Drawing.Size(195, 28);
            this.cbbHDTheoKH.TabIndex = 19;
            this.cbbHDTheoKH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbbHDTheoKH_KeyPress);
            // 
            // cbbHDTheoNQL
            // 
            this.cbbHDTheoNQL.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbHDTheoNQL.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbHDTheoNQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbbHDTheoNQL.FormattingEnabled = true;
            this.cbbHDTheoNQL.Items.AddRange(new object[] {
            "N",
            "K"});
            this.cbbHDTheoNQL.Location = new System.Drawing.Point(7, 95);
            this.cbbHDTheoNQL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbHDTheoNQL.Name = "cbbHDTheoNQL";
            this.cbbHDTheoNQL.Size = new System.Drawing.Size(195, 28);
            this.cbbHDTheoNQL.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(50, 53);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "*Nhập số điện thoại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(53, 53);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "*Nhập mã NQL";
            // 
            // lbltongsohoadondanhap
            // 
            this.lbltongsohoadondanhap.AutoSize = true;
            this.lbltongsohoadondanhap.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbltongsohoadondanhap.ForeColor = System.Drawing.SystemColors.Info;
            this.lbltongsohoadondanhap.Location = new System.Drawing.Point(481, 787);
            this.lbltongsohoadondanhap.Name = "lbltongsohoadondanhap";
            this.lbltongsohoadondanhap.Size = new System.Drawing.Size(28, 32);
            this.lbltongsohoadondanhap.TabIndex = 24;
            this.lbltongsohoadondanhap.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.Info;
            this.label6.Location = new System.Drawing.Point(118, 787);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(348, 32);
            this.label6.TabIndex = 25;
            this.label6.Text = "Tổng số hoá đơn bán đã tạo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbHDTheoKH);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnXemHDTheoKH);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(160, 131);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(243, 204);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Xem hoá đơn bán theo khách hàng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbbHDTheoNQL);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnXemHDTheoNQL);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(509, 131);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(247, 204);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Xem hoá đơn bán theo NQL";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(447, 24);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(260, 38);
            this.label7.TabIndex = 44;
            this.label7.Text = "HOÁ ĐƠN BÁN";
            // 
            // SoHD
            // 
            this.SoHD.DataPropertyName = "SoHD";
            this.SoHD.HeaderText = "Số hoá đơn";
            this.SoHD.MinimumWidth = 6;
            this.SoHD.Name = "SoHD";
            this.SoHD.ReadOnly = true;
            this.SoHD.Width = 125;
            // 
            // NgayBan
            // 
            this.NgayBan.DataPropertyName = "NgayBan";
            this.NgayBan.HeaderText = "Ngày bán";
            this.NgayBan.MinimumWidth = 6;
            this.NgayBan.Name = "NgayBan";
            this.NgayBan.ReadOnly = true;
            this.NgayBan.Width = 220;
            // 
            // TinhTrangDoiTra
            // 
            this.TinhTrangDoiTra.DataPropertyName = "TinhTrangDoiTra";
            this.TinhTrangDoiTra.HeaderText = "Tình trạng đổi trả";
            this.TinhTrangDoiTra.MinimumWidth = 6;
            this.TinhTrangDoiTra.Name = "TinhTrangDoiTra";
            this.TinhTrangDoiTra.ReadOnly = true;
            this.TinhTrangDoiTra.Width = 180;
            // 
            // frmHoaDonBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1775, 899);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbltongsohoadondanhap);
            this.Controls.Add(this.dgvHoaDon);
            this.Controls.Add(this.txtngayban);
            this.Controls.Add(this.txtsohd);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXemChiTiet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmHoaDonBan";
            this.Text = "frmHoaDonBan";
            this.Load += new System.EventHandler(this.frmHoaDonBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.TextBox txtngayban;
        private System.Windows.Forms.TextBox txtsohd;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXemChiTiet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXemHDTheoKH;
        private System.Windows.Forms.Button btnXemHDTheoNQL;
        private System.Windows.Forms.ComboBox cbbHDTheoKH;
        private System.Windows.Forms.ComboBox cbbHDTheoNQL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbltongsohoadondanhap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrangDoiTra;
    }
}