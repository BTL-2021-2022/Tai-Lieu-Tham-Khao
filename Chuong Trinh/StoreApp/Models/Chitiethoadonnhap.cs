using System;
using System.Collections.Generic;

#nullable disable

namespace StoreApp.Models
{
    public partial class Chitiethoadonnhap
    {
        public int SoHdn { get; set; }
        public string MaSp { get; set; }
        public int Size { get; set; }
        public string Mau { get; set; }
        public string TenSp { get; set; }
        public int SoLuongNhap { get; set; }
        public decimal DonGiaNhap { get; set; }
        public decimal ThanhTien { get; set; }

        public virtual Sanpham MaSpNavigation { get; set; }
        public virtual Hoadonnhap SoHdnNavigation { get; set; }
    }
}
