
namespace StoreApp
{
    partial class frmChonHDDat
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
            this.dgvDSachDonDat = new System.Windows.Forms.DataGridView();
            this.SoHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayDat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienCoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTimTheoSDT = new System.Windows.Forms.Button();
            this.txtTimtheosdt = new System.Windows.Forms.TextBox();
            this.txtTimtheoSHD = new System.Windows.Forms.TextBox();
            this.btnTimTheoSoHD = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnChon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSachDonDat)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDSachDonDat
            // 
            this.dgvDSachDonDat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSachDonDat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SoHD,
            this.SDT,
            this.TenKH,
            this.NgayDat,
            this.TienCoc});
            this.dgvDSachDonDat.Location = new System.Drawing.Point(49, 68);
            this.dgvDSachDonDat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvDSachDonDat.Name = "dgvDSachDonDat";
            this.dgvDSachDonDat.RowHeadersWidth = 51;
            this.dgvDSachDonDat.RowTemplate.Height = 25;
            this.dgvDSachDonDat.Size = new System.Drawing.Size(848, 501);
            this.dgvDSachDonDat.TabIndex = 12;
            this.dgvDSachDonDat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSachDonDat_CellContentClick);
            // 
            // SoHD
            // 
            this.SoHD.DataPropertyName = "SoHD";
            this.SoHD.HeaderText = "Số hoá đơn";
            this.SoHD.MinimumWidth = 6;
            this.SoHD.Name = "SoHD";
            this.SoHD.Width = 125;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "Số điện thoại";
            this.SDT.MinimumWidth = 6;
            this.SDT.Name = "SDT";
            this.SDT.Width = 150;
            // 
            // TenKH
            // 
            this.TenKH.DataPropertyName = "TenKH";
            this.TenKH.HeaderText = "Tên khách hàng";
            this.TenKH.MinimumWidth = 6;
            this.TenKH.Name = "TenKH";
            this.TenKH.Width = 175;
            // 
            // NgayDat
            // 
            this.NgayDat.DataPropertyName = "NgayDat";
            this.NgayDat.HeaderText = "Ngày đặt";
            this.NgayDat.MinimumWidth = 6;
            this.NgayDat.Name = "NgayDat";
            this.NgayDat.Width = 195;
            // 
            // TienCoc
            // 
            this.TienCoc.DataPropertyName = "TienCoc";
            this.TienCoc.HeaderText = "Tiền cọc";
            this.TienCoc.MinimumWidth = 6;
            this.TienCoc.Name = "TienCoc";
            this.TienCoc.Width = 150;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTimTheoSDT);
            this.groupBox2.Controls.Add(this.txtTimtheosdt);
            this.groupBox2.Controls.Add(this.txtTimtheoSHD);
            this.groupBox2.Controls.Add(this.btnTimTheoSoHD);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(1023, 132);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(432, 149);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm hoá đơn";
            // 
            // btnTimTheoSDT
            // 
            this.btnTimTheoSDT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimTheoSDT.Location = new System.Drawing.Point(286, 72);
            this.btnTimTheoSDT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTimTheoSDT.Name = "btnTimTheoSDT";
            this.btnTimTheoSDT.Size = new System.Drawing.Size(136, 42);
            this.btnTimTheoSDT.TabIndex = 3;
            this.btnTimTheoSDT.Text = "Tìm theo SĐT";
            this.btnTimTheoSDT.UseVisualStyleBackColor = true;
            this.btnTimTheoSDT.Click += new System.EventHandler(this.btnTimTheoSDT_Click);
            // 
            // txtTimtheosdt
            // 
            this.txtTimtheosdt.Location = new System.Drawing.Point(62, 80);
            this.txtTimtheosdt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTimtheosdt.MaxLength = 15;
            this.txtTimtheosdt.Name = "txtTimtheosdt";
            this.txtTimtheosdt.Size = new System.Drawing.Size(201, 27);
            this.txtTimtheosdt.TabIndex = 1;
            this.txtTimtheosdt.TextChanged += new System.EventHandler(this.txtTimtheosdt_TextChanged);
            this.txtTimtheosdt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTimtheosdt_KeyPress);
            // 
            // txtTimtheoSHD
            // 
            this.txtTimtheoSHD.Location = new System.Drawing.Point(62, 32);
            this.txtTimtheoSHD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTimtheoSHD.MaxLength = 15;
            this.txtTimtheoSHD.Name = "txtTimtheoSHD";
            this.txtTimtheoSHD.Size = new System.Drawing.Size(201, 27);
            this.txtTimtheoSHD.TabIndex = 0;
            this.txtTimtheoSHD.TextChanged += new System.EventHandler(this.txtTimtheoten_TextChanged);
            this.txtTimtheoSHD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTimtheoSHD_KeyPress);
            // 
            // btnTimTheoSoHD
            // 
            this.btnTimTheoSoHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimTheoSoHD.Location = new System.Drawing.Point(286, 25);
            this.btnTimTheoSoHD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTimTheoSoHD.Name = "btnTimTheoSoHD";
            this.btnTimTheoSoHD.Size = new System.Drawing.Size(136, 42);
            this.btnTimTheoSoHD.TabIndex = 2;
            this.btnTimTheoSoHD.Text = "Tìm Số hoá đơn";
            this.btnTimTheoSoHD.UseVisualStyleBackColor = true;
            this.btnTimTheoSoHD.Click += new System.EventHandler(this.btnTimTheoSoHD_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(184, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 32);
            this.label1.TabIndex = 11;
            this.label1.Text = "Danh sách đơn đặt chờ xử lý";
            // 
            // btnChon
            // 
            this.btnChon.Location = new System.Drawing.Point(468, 580);
            this.btnChon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(109, 35);
            this.btnChon.TabIndex = 13;
            this.btnChon.Text = "Chọn";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // frmChonHDDat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1501, 640);
            this.Controls.Add(this.dgvDSachDonDat);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnChon);
            this.Name = "frmChonHDDat";
            this.Text = "frmChonHDDat";
            this.Load += new System.EventHandler(this.frmChonHDDat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSachDonDat)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDSachDonDat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTimTheoSDT;
        private System.Windows.Forms.TextBox txtTimtheosdt;
        private System.Windows.Forms.TextBox txtTimtheoSHD;
        private System.Windows.Forms.Button btnTimTheoSoHD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayDat;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienCoc;
    }
}