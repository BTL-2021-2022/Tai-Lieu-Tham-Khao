﻿using System;
using System.Collections.Generic;

#nullable disable

namespace StoreApp.Models
{
    public partial class Chitietdathang
    {
        public int MaHddatHang { get; set; }
        public string MaSp { get; set; }
        public int Size { get; set; }
        public string Mau { get; set; }
        public int SoLuongDat { get; set; }
        public decimal TienCoc { get; set; }
        public decimal ThanhTien { get; set; }
        public string TenSp { get; set; }
        public decimal DonGiaDat { get; set; }

        public virtual Dathangncc MaHddatHangNavigation { get; set; }
        public virtual Sanpham MaSpNavigation { get; set; }
    }
}
