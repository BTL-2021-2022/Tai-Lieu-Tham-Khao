
namespace StoreApp
{
    partial class frmHDBanTheoNV
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
            this.lblTK = new System.Windows.Forms.Label();
            this.txtngayban = new System.Windows.Forms.TextBox();
            this.txtsohd = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXemChiTiet = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTongHD = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvHoadondaban = new System.Windows.Forms.DataGridView();
            this.SoHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrangDoiTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoadondaban)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTK
            // 
            this.lblTK.AutoSize = true;
            this.lblTK.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTK.Location = new System.Drawing.Point(54, 462);
            this.lblTK.Name = "lblTK";
            this.lblTK.Size = new System.Drawing.Size(304, 32);
            this.lblTK.TabIndex = 24;
            this.lblTK.Text = "Tổng số hoá đơn đã bán";
            // 
            // txtngayban
            // 
            this.txtngayban.Enabled = false;
            this.txtngayban.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtngayban.Location = new System.Drawing.Point(745, 250);
            this.txtngayban.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtngayban.Name = "txtngayban";
            this.txtngayban.Size = new System.Drawing.Size(241, 30);
            this.txtngayban.TabIndex = 22;
            // 
            // txtsohd
            // 
            this.txtsohd.Enabled = false;
            this.txtsohd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtsohd.Location = new System.Drawing.Point(745, 204);
            this.txtsohd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtsohd.Name = "txtsohd";
            this.txtsohd.Size = new System.Drawing.Size(241, 30);
            this.txtsohd.TabIndex = 23;
            // 
            // btnThoat
            // 
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(791, 406);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(145, 40);
            this.btnThoat.TabIndex = 20;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXemChiTiet
            // 
            this.btnXemChiTiet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemChiTiet.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnXemChiTiet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXemChiTiet.Location = new System.Drawing.Point(791, 325);
            this.btnXemChiTiet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXemChiTiet.Name = "btnXemChiTiet";
            this.btnXemChiTiet.Size = new System.Drawing.Size(145, 44);
            this.btnXemChiTiet.TabIndex = 21;
            this.btnXemChiTiet.Text = "Xem chi tiết";
            this.btnXemChiTiet.UseVisualStyleBackColor = true;
            this.btnXemChiTiet.Click += new System.EventHandler(this.btnXemChiTiet_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(638, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 22);
            this.label4.TabIndex = 19;
            this.label4.Text = "Ngày bán";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(638, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 22);
            this.label2.TabIndex = 18;
            this.label2.Text = "Số hóa đơn";
            // 
            // lblTongHD
            // 
            this.lblTongHD.AutoSize = true;
            this.lblTongHD.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTongHD.Location = new System.Drawing.Point(365, 462);
            this.lblTongHD.Name = "lblTongHD";
            this.lblTongHD.Size = new System.Drawing.Size(28, 32);
            this.lblTongHD.TabIndex = 25;
            this.lblTongHD.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(257, 62);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(564, 38);
            this.label7.TabIndex = 46;
            this.label7.Text = "HOÁ ĐƠN BÁN THEO NHÂN VIÊN";
            // 
            // dgvHoadondaban
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dgvHoadondaban.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHoadondaban.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHoadondaban.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoadondaban.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SoHD,
            this.NgayBan,
            this.TinhTrangDoiTra});
            this.dgvHoadondaban.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvHoadondaban.Location = new System.Drawing.Point(54, 221);
            this.dgvHoadondaban.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvHoadondaban.Name = "dgvHoadondaban";
            this.dgvHoadondaban.ReadOnly = true;
            this.dgvHoadondaban.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dgvHoadondaban.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHoadondaban.RowTemplate.Height = 24;
            this.dgvHoadondaban.Size = new System.Drawing.Size(535, 211);
            this.dgvHoadondaban.TabIndex = 47;
            this.dgvHoadondaban.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoadondaban_CellContentClick_1);
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
            this.NgayBan.Width = 200;
            // 
            // TinhTrangDoiTra
            // 
            this.TinhTrangDoiTra.DataPropertyName = "TinhTrangDoiTra";
            this.TinhTrangDoiTra.HeaderText = "Tình trạng đổi trả";
            this.TinhTrangDoiTra.MinimumWidth = 6;
            this.TinhTrangDoiTra.Name = "TinhTrangDoiTra";
            this.TinhTrangDoiTra.ReadOnly = true;
            this.TinhTrangDoiTra.Width = 160;
            // 
            // frmHDBanTheoNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1103, 728);
            this.Controls.Add(this.dgvHoadondaban);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblTongHD);
            this.Controls.Add(this.lblTK);
            this.Controls.Add(this.txtngayban);
            this.Controls.Add(this.txtsohd);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXemChiTiet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmHDBanTheoNV";
            this.Text = "frmHDBanTheoNV";
            this.Load += new System.EventHandler(this.frmHDBanTheoNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoadondaban)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTK;
        private System.Windows.Forms.TextBox txtngayban;
        private System.Windows.Forms.TextBox txtsohd;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXemChiTiet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTongHD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvHoadondaban;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrangDoiTra;
    }
}