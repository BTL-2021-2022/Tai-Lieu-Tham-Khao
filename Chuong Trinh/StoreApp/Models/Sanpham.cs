using System;
using System.Collections.Generic;

#nullable disable

namespace StoreApp.Models
{
    public partial class Sanpham
    {
        public Sanpham()
        {
            Chitietdathangs = new HashSet<Chitietdathang>();
            Chitiethoadonnhaps = new HashSet<Chitiethoadonnhap>();
            Chitiethoadons = new HashSet<Chitiethoadon>();
            Chitietkhdats = new HashSet<Chitietkhdat>();
            SoLuongCons = new HashSet<SoLuongCon>();
        }

        public string MaSp { get; set; }
        public string TenSp { get; set; }
        public decimal GiaBan { get; set; }
        public string TinhTrang { get; set; }
        public string ThongTin { get; set; }

        public virtual ICollection<Chitietdathang> Chitietdathangs { get; set; }
        public virtual ICollection<Chitiethoadonnhap> Chitiethoadonnhaps { get; set; }
        public virtual ICollection<Chitiethoadon> Chitiethoadons { get; set; }
        public virtual ICollection<Chitietkhdat> Chitietkhdats { get; set; }
        public virtual ICollection<SoLuongCon> SoLuongCons { get; set; }
    }
}
