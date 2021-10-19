using System;
using System.Collections.Generic;

#nullable disable

namespace StoreApp.Models
{
    public partial class DonhangmuaNhap
    {
        public string MaSp { get; set; }
        public int Size { get; set; }
        public string Mau { get; set; }
        public string TenSp { get; set; }
        public int SoLuongMua { get; set; }
        public decimal DonGiaMua { get; set; }
    }
}
