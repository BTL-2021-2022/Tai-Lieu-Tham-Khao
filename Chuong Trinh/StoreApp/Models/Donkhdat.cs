using System;
using System.Collections.Generic;

#nullable disable

namespace StoreApp.Models
{
    public partial class Donkhdat
    {
        public Donkhdat()
        {
            Chitietkhdats = new HashSet<Chitietkhdat>();
        }

        public int SoHd { get; set; }
        public string TenKh { get; set; }
        public string Sdt { get; set; }
        public string DiaChiKh { get; set; }
        public decimal TienCoc { get; set; }
        public string TinhTrang { get; set; }
        public DateTime NgayDat { get; set; }

        public virtual ICollection<Chitietkhdat> Chitietkhdats { get; set; }
    }
}
