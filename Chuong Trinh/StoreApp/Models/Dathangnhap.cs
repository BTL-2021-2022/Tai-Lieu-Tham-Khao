using System;
using System.Collections.Generic;

#nullable disable

namespace StoreApp.Models
{
    public partial class Dathangnhap
    {
        public string MaSp { get; set; }
        public string TenSp { get; set; }
        public string Size { get; set; }
        public int? SoLuongNhap { get; set; }
        public decimal? DonGiaNhap { get; set; }
        public decimal? TienCoc { get; set; }
        public decimal? ThanhTien { get; set; }
    }
}
