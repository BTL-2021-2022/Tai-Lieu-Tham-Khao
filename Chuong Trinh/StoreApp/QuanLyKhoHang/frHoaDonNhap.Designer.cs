
namespace StoreApp.QuanLyKhoHang
{
    partial class frHoaDonNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frHoaDonNhap));
            this.label1 = new System.Windows.Forms.Label();
            this.data_hoadon = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_ma = new System.Windows.Forms.TextBox();
            this.txt_so = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nql = new System.Windows.Forms.TextBox();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_date = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.data_hoadon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(629, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 36);
            this.label1.TabIndex = 8;
            this.label1.Text = "Danh sách hóa đơn";
            // 
            // data_hoadon
            // 
            this.data_hoadon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_hoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_hoadon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.data_hoadon.Location = new System.Drawing.Point(399, 367);
            this.data_hoadon.Name = "data_hoadon";
            this.data_hoadon.RowHeadersVisible = false;
            this.data_hoadon.RowHeadersWidth = 51;
            this.data_hoadon.RowTemplate.Height = 24;
            this.data_hoadon.Size = new System.Drawing.Size(752, 228);
            this.data_hoadon.TabIndex = 14;
            this.data_hoadon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.show);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Số hóa đơn";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Mã nhà cung cấp";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Mã NQL";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Ngày";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(399, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Mã NCC";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(400, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Ngày";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(399, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Số hóa đơn";
            // 
            // txt_ma
            // 
            this.txt_ma.Enabled = false;
            this.txt_ma.Location = new System.Drawing.Point(596, 211);
            this.txt_ma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_ma.Name = "txt_ma";
            this.txt_ma.ReadOnly = true;
            this.txt_ma.Size = new System.Drawing.Size(555, 27);
            this.txt_ma.TabIndex = 3;
            // 
            // txt_so
            // 
            this.txt_so.Enabled = false;
            this.txt_so.Location = new System.Drawing.Point(596, 166);
            this.txt_so.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_so.Name = "txt_so";
            this.txt_so.ReadOnly = true;
            this.txt_so.Size = new System.Drawing.Size(555, 27);
            this.txt_so.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(400, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Mã NQL";
            // 
            // txt_nql
            // 
            this.txt_nql.Location = new System.Drawing.Point(596, 252);
            this.txt_nql.Name = "txt_nql";
            this.txt_nql.ReadOnly = true;
            this.txt_nql.Size = new System.Drawing.Size(555, 27);
            this.txt_nql.TabIndex = 16;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(823, 622);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 63);
            this.button1.TabIndex = 17;
            this.button1.Text = "Xem chi tiết hóa đơn";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_date
            // 
            this.txt_date.Location = new System.Drawing.Point(596, 298);
            this.txt_date.Name = "txt_date";
            this.txt_date.ReadOnly = true;
            this.txt_date.Size = new System.Drawing.Size(555, 27);
            this.txt_date.TabIndex = 18;
            // 
            // frHoaDonNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1400, 744);
            this.Controls.Add(this.txt_date);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_nql);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_so);
            this.Controls.Add(this.txt_ma);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.data_hoadon);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frHoaDonNhap";
            this.Text = "HoaDonNhap";
            this.Load += new System.EventHandler(this.frHoaDonNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_hoadon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView data_hoadon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_ma;
        private System.Windows.Forms.TextBox txt_so;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nql;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_date;
    }
}