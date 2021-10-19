using System;
using System.Collections.Generic;

#nullable disable

namespace StoreApp.Models
{
    public partial class Hoadonban
    {
        public Hoadonban()
        {
            Chitiethoadons = new HashSet<Chitiethoadon>();
            Phieudoitras = new HashSet<Phieudoitra>();
        }

        public int SoHd { get; set; }
        public string Sdt { get; set; }
        public string MaNql { get; set; }
        public DateTime NgayBan { get; set; }
        public double? ChietKhau { get; set; }
        public string TinhTrangDoiTra { get; set; }

        public virtual Nguoiquanly MaNqlNavigation { get; set; }
        public virtual Khachhang SdtNavigation { get; set; }
        public virtual ICollection<Chitiethoadon> Chitiethoadons { get; set; }
        public virtual ICollection<Phieudoitra> Phieudoitras { get; set; }
    }
}
