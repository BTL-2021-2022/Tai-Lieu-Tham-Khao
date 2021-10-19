using System;
using System.Collections.Generic;

#nullable disable

namespace StoreApp.Models
{
    public partial class Phieudoitra
    {
        public int SoPhieu { get; set; }
        public int SoHd { get; set; }
        public string MaSpmoi { get; set; }
        public string TenSpmoi { get; set; }
        public int Size { get; set; }
        public string Mau { get; set; }
        public decimal DonGia { get; set; }
        public int SoLuong { get; set; }
        public decimal? ThanhTien { get; set; }

        public virtual Hoadonban SoHdNavigation { get; set; }
    }
}
