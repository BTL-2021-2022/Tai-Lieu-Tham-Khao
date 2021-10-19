using System;
using System.Collections.Generic;

#nullable disable

namespace StoreApp.Models
{
    public partial class Chitiethoadon
    {
        public string MaSp { get; set; }
        public int SoHd { get; set; }
        public int Size { get; set; }
        public string Mau { get; set; }
        public int SoLuongBan { get; set; }
        public decimal GiaBan { get; set; }
        public decimal ThanhTien { get; set; }

        public virtual Sanpham MaSpNavigation { get; set; }
        public virtual Hoadonban SoHdNavigation { get; set; }
    }
}
