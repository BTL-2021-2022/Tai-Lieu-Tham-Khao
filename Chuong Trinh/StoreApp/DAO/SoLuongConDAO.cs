using StoreApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.DAO
{
    class SoLuongConDAO
    {
        private QuanLyBanGiayContext quanLyBanGiayContext;
        public SoLuongConDAO()
        {
            quanLyBanGiayContext = new QuanLyBanGiayContext();
        }
        public void update(string ma, string mau, int size, int soluong)
        {
            SoLuongCon old = quanLyBanGiayContext.SoLuongCons.FirstOrDefault(s => s.MaSp.Equals(ma) && s.Mau
              .Equals(mau) && s.Size == size);
            if (old == null)
            {
                SoLuongCon sl = new SoLuongCon();
                sl.MaSp = ma;
                sl.Mau = mau;
                sl.Size = size;
                sl.OrderLevel = 0;
                sl.Slcon = soluong;
                quanLyBanGiayContext.SoLuongCons.Add(sl);
            }
            else
            {
                old.Slcon = old.Slcon + soluong;
            }
            Sync();
        }
        public void Sync()
        {
            quanLyBanGiayContext.SaveChanges();
        }
    }
}
