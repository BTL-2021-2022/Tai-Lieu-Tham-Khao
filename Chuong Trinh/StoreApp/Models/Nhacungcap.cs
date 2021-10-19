using System;
using System.Collections.Generic;

#nullable disable

namespace StoreApp.Models
{
    public partial class Nhacungcap
    {
        public Nhacungcap()
        {
            Dathangnccs = new HashSet<Dathangncc>();
            Hoadonnhaps = new HashSet<Hoadonnhap>();
        }

        public string MaNcc { get; set; }
        public string TenNcc { get; set; }
        public string DiaChiNcc { get; set; }
        public string Sdtncc { get; set; }
        public string TinhTrang { get; set; }

        public virtual ICollection<Dathangncc> Dathangnccs { get; set; }
        public virtual ICollection<Hoadonnhap> Hoadonnhaps { get; set; }
    }
}
