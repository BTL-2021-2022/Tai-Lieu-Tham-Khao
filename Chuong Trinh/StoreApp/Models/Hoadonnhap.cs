using System;
using System.Collections.Generic;

#nullable disable

namespace StoreApp.Models
{
    public partial class Hoadonnhap
    {
        public Hoadonnhap()
        {
            Chitiethoadonnhaps = new HashSet<Chitiethoadonnhap>();
        }

        public int SoHdn { get; set; }
        public string MaNcc { get; set; }
        public string MaNql { get; set; }
        public DateTime NgayNhap { get; set; }

        public virtual Nhacungcap MaNccNavigation { get; set; }
        public virtual Nguoiquanly MaNqlNavigation { get; set; }
        public virtual ICollection<Chitiethoadonnhap> Chitiethoadonnhaps { get; set; }
    }
}
