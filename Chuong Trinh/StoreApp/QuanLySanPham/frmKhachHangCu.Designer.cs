
namespace StoreApp
{
    partial class frmKhachHangCu
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
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChiKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnChon = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTimTheoSDT = new System.Windows.Forms.Button();
            this.txtTimtheosdt = new System.Windows.Forms.TextBox();
            this.txtTimtheoten = new System.Windows.Forms.TextBox();
            this.btnTimTheoTen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenKH,
            this.SDT,
            this.DiaChiKH});
            this.dgvKhachHang.Location = new System.Drawing.Point(149, 116);
            this.dgvKhachHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.RowHeadersWidth = 51;
            this.dgvKhachHang.RowTemplate.Height = 25;
            this.dgvKhachHang.Size = new System.Drawing.Size(551, 501);
            this.dgvKhachHang.TabIndex = 7;
            this.dgvKhachHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachHang_CellContentClick);
            // 
            // TenKH
            // 
            this.TenKH.DataPropertyName = "TenKH";
            this.TenKH.HeaderText = "Tên khách hàng";
            this.TenKH.MinimumWidth = 6;
            this.TenKH.Name = "TenKH";
            this.TenKH.Width = 150;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "Số điện thoại";
            this.SDT.MinimumWidth = 6;
            this.SDT.Name = "SDT";
            this.SDT.Width = 150;
            // 
            // DiaChiKH
            // 
            this.DiaChiKH.DataPropertyName = "DiaChiKH";
            this.DiaChiKH.HeaderText = "Địa chỉ khách hàng";
            this.DiaChiKH.MinimumWidth = 6;
            this.DiaChiKH.Name = "DiaChiKH";
            this.DiaChiKH.Width = 200;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(284, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Danh sách khách hàng";
            // 
            // btnChon
            // 
            this.btnChon.Location = new System.Drawing.Point(568, 628);
            this.btnChon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(86, 31);
            this.btnChon.TabIndex = 8;
            this.btnChon.Text = "Chọn";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTimTheoSDT);
            this.groupBox2.Controls.Add(this.txtTimtheosdt);
            this.groupBox2.Controls.Add(this.txtTimtheoten);
            this.groupBox2.Controls.Add(this.btnTimTheoTen);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(730, 179);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(432, 149);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm khách hàng";
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
            // txtTimtheoten
            // 
            this.txtTimtheoten.Location = new System.Drawing.Point(62, 32);
            this.txtTimtheoten.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTimtheoten.MaxLength = 15;
            this.txtTimtheoten.Name = "txtTimtheoten";
            this.txtTimtheoten.Size = new System.Drawing.Size(201, 27);
            this.txtTimtheoten.TabIndex = 0;
            this.txtTimtheoten.TextChanged += new System.EventHandler(this.txtTimtheoten_TextChanged);
            // 
            // btnTimTheoTen
            // 
            this.btnTimTheoTen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimTheoTen.Location = new System.Drawing.Point(286, 25);
            this.btnTimTheoTen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTimTheoTen.Name = "btnTimTheoTen";
            this.btnTimTheoTen.Size = new System.Drawing.Size(136, 42);
            this.btnTimTheoTen.TabIndex = 2;
            this.btnTimTheoTen.Text = "Tìm theo tên";
            this.btnTimTheoTen.UseVisualStyleBackColor = true;
            this.btnTimTheoTen.Click += new System.EventHandler(this.btnTimTheoTen_Click);
            // 
            // frmKhachHangCu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 721);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvKhachHang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnChon);
            this.Name = "frmKhachHangCu";
            this.Text = "frmKhachHangCu";
            this.Load += new System.EventHandler(this.frmKhachHangCu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChiKH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTimTheoSDT;
        private System.Windows.Forms.TextBox txtTimtheosdt;
        private System.Windows.Forms.TextBox txtTimtheoten;
        private System.Windows.Forms.Button btnTimTheoTen;
    }
}