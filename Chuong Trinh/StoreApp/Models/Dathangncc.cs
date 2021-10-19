using System;
using System.Collections.Generic;

#nullable disable

namespace StoreApp.Models
{
    public partial class Dathangncc
    {
        public Dathangncc()
        {
            Chitietdathangs = new HashSet<Chitietdathang>();
        }

        public int MaHddatHang { get; set; }
        public string MaNcc { get; set; }
        public DateTime NgayThang { get; set; }
        public string NguoiLap { get; set; }
        public int TinhTrang { get; set; }

        public virtual Nhacungcap MaNccNavigation { get; set; }
        public virtual ICollection<Chitietdathang> Chitietdathangs { get; set; }
    }
}
