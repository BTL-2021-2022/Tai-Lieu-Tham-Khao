using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreApp.Models;
namespace StoreApp.DAO
{
    class HoaDonNhapDao
    {
        private QuanLyBanGiayContext quanLyBanGiayContext;
        public HoaDonNhapDao()
        {
            quanLyBanGiayContext = new QuanLyBanGiayContext();
        }
        public List<Hoadonnhap> getAll()
        {
            return quanLyBanGiayContext.Hoadonnhaps.ToList();
        }
        public Hoadonnhap getById(int id)
        {
            return quanLyBanGiayContext.Hoadonnhaps.FirstOrDefault(h => h.SoHdn==id);
        }
        public void add(Hoadonnhap h)
        {
            quanLyBanGiayContext.Hoadonnhaps.Add(h);
            Sync();
        }
        public void Sync()
        {
            quanLyBanGiayContext.SaveChanges();
        }
    }
}
