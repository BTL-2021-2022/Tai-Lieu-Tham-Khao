using System;
using System.Collections.Generic;

#nullable disable

namespace StoreApp.Models
{
    public partial class Khachhang
    {
        public Khachhang()
        {
            Hoadonbans = new HashSet<Hoadonban>();
        }

        public string Sdt { get; set; }
        public string TenKh { get; set; }
        public string DiaChiKh { get; set; }
        public decimal TongTien { get; set; }

        public virtual ICollection<Hoadonban> Hoadonbans { get; set; }
    }
}
