using System;
using System.Collections.Generic;

#nullable disable

namespace StoreApp.Models
{
    public partial class SoLuongCon
    {
        public int Size { get; set; }
        public int Slcon { get; set; }
        public string MaSp { get; set; }
        public string Mau { get; set; }
        public int? OrderLevel { get; set; }

        public virtual Sanpham MaSpNavigation { get; set; }
    }
}
