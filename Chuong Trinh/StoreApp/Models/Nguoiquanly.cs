using System;
using System.Collections.Generic;

#nullable disable

namespace StoreApp.Models
{
    public partial class Nguoiquanly
    {
        public Nguoiquanly()
        {
            Hoadonbans = new HashSet<Hoadonban>();
            Hoadonnhaps = new HashSet<Hoadonnhap>();
        }

        public string MaNql { get; set; }
        public string TenNql { get; set; }
        public string DiaChiNql { get; set; }
        public string MatKhau { get; set; }
        public string TinhTrang { get; set; }
        public string Sdtnql { get; set; }

        public virtual ICollection<Hoadonban> Hoadonbans { get; set; }
        public virtual ICollection<Hoadonnhap> Hoadonnhaps { get; set; }
    }
}
