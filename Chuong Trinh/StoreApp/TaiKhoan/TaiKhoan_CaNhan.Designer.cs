
namespace StoreApp.TaiKhoan
{
    partial class TaiKhoan_CaNhan
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Matk = new System.Windows.Forms.TextBox();
            this.txt_Tennguoidung = new System.Windows.Forms.TextBox();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.txt_MK = new System.Windows.Forms.TextBox();
            this.txt_Loaitk = new System.Windows.Forms.TextBox();
            this.but_Sua = new System.Windows.Forms.Button();
            this.but_Thoat = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(95, 152);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 51);
            this.label1.TabIndex = 0;
            // 
            // txt_Matk
            // 
            this.txt_Matk.Enabled = false;
            this.txt_Matk.Location = new System.Drawing.Point(619, 384);
            this.txt_Matk.Name = "txt_Matk";
            this.txt_Matk.Size = new System.Drawing.Size(290, 32);
            this.txt_Matk.TabIndex = 7;
            // 
            // txt_Tennguoidung
            // 
            this.txt_Tennguoidung.Location = new System.Drawing.Point(619, 448);
            this.txt_Tennguoidung.Name = "txt_Tennguoidung";
            this.txt_Tennguoidung.Size = new System.Drawing.Size(290, 32);
            this.txt_Tennguoidung.TabIndex = 8;
            this.txt_Tennguoidung.Validated += new System.EventHandler(this.txt_Tennguoidung_Validated);
            // 
            // txt_SDT
            // 
            this.txt_SDT.Location = new System.Drawing.Point(619, 513);
            this.txt_SDT.MaxLength = 10;
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(290, 32);
            this.txt_SDT.TabIndex = 9;
            this.txt_SDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SDT_KeyPress);
            this.txt_SDT.Validated += new System.EventHandler(this.txt_SDT_Validated);
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Location = new System.Drawing.Point(619, 584);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(290, 32);
            this.txt_DiaChi.TabIndex = 10;
            this.txt_DiaChi.Validated += new System.EventHandler(this.txt_DiaChi_Validated);
            // 
            // txt_MK
            // 
            this.txt_MK.Location = new System.Drawing.Point(619, 647);
            this.txt_MK.Name = "txt_MK";
            this.txt_MK.Size = new System.Drawing.Size(290, 32);
            this.txt_MK.TabIndex = 11;
            this.txt_MK.Validated += new System.EventHandler(this.txt_MK_Validated);
            // 
            // txt_Loaitk
            // 
            this.txt_Loaitk.Enabled = false;
            this.txt_Loaitk.Location = new System.Drawing.Point(619, 708);
            this.txt_Loaitk.Name = "txt_Loaitk";
            this.txt_Loaitk.Size = new System.Drawing.Size(290, 32);
            this.txt_Loaitk.TabIndex = 12;
            this.txt_Loaitk.Text = "NV";
            // 
            // but_Sua
            // 
            this.but_Sua.Location = new System.Drawing.Point(1070, 478);
            this.but_Sua.Name = "but_Sua";
            this.but_Sua.Size = new System.Drawing.Size(213, 55);
            this.but_Sua.TabIndex = 13;
            this.but_Sua.Text = "Sửa thông tin";
            this.but_Sua.UseVisualStyleBackColor = true;
            this.but_Sua.Click += new System.EventHandler(this.but_Sua_Click);
            // 
            // but_Thoat
            // 
            this.but_Thoat.Location = new System.Drawing.Point(1070, 590);
            this.but_Thoat.Name = "but_Thoat";
            this.but_Thoat.Size = new System.Drawing.Size(213, 50);
            this.but_Thoat.TabIndex = 14;
            this.but_Thoat.Text = "Thoát";
            this.but_Thoat.UseVisualStyleBackColor = true;
            this.but_Thoat.Click += new System.EventHandler(this.but_Thoat_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(384, 390);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(162, 26);
            this.label9.TabIndex = 16;
            this.label9.Text = "Mã tài khoản :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(357, 454);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(189, 26);
            this.label10.TabIndex = 17;
            this.label10.Text = "Tên người dùng :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(380, 519);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(166, 26);
            this.label11.TabIndex = 18;
            this.label11.Text = "Số điện thoại :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(423, 653);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(123, 26);
            this.label12.TabIndex = 19;
            this.label12.Text = "Mật khẩu :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(446, 590);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 26);
            this.label13.TabIndex = 20;
            this.label13.Text = "Địa chỉ :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(371, 714);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(175, 26);
            this.label14.TabIndex = 21;
            this.label14.Text = "Loại tài khoản :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(532, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(654, 69);
            this.label2.TabIndex = 22;
            this.label2.Text = "TÀI KHOẢN CÁ NHÂN";
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // TaiKhoan_CaNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1295, 797);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.but_Thoat);
            this.Controls.Add(this.but_Sua);
            this.Controls.Add(this.txt_Loaitk);
            this.Controls.Add(this.txt_MK);
            this.Controls.Add(this.txt_DiaChi);
            this.Controls.Add(this.txt_SDT);
            this.Controls.Add(this.txt_Tennguoidung);
            this.Controls.Add(this.txt_Matk);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "TaiKhoan_CaNhan";
            this.Text = "TaiKhoan_CaNhan";
            this.Load += new System.EventHandler(this.TaiKhoan_CaNhan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Matk;
        private System.Windows.Forms.TextBox txt_Tennguoidung;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.TextBox txt_MK;
        private System.Windows.Forms.TextBox txt_Loaitk;
        private System.Windows.Forms.Button but_Sua;
        private System.Windows.Forms.Button but_Thoat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider error;
    }
}