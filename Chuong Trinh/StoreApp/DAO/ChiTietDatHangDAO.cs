using StoreApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.DAO
{
    class ChiTietDatHangDAO
    {
        private QuanLyBanGiayContext quanLyBanGiayContext;
        public ChiTietDatHangDAO()
        {
            quanLyBanGiayContext = new QuanLyBanGiayContext();
        }
        public List<Chitietdathang> getAll()
        {
            return quanLyBanGiayContext.Chitietdathangs.ToList();
        }
        public List<Chitietdathang> getById(int id)
        {
            return quanLyBanGiayContext.Chitietdathangs.Where(e => e.MaHddatHang == id).ToList();
        }
        public void update(Chitietdathang c)
        {
            Chitietdathang old = quanLyBanGiayContext.Chitietdathangs.FirstOrDefault(s => s.MaHddatHang == c.MaHddatHang&&s.MaSp.Equals(c.MaSp)&&s.Mau.Equals(c.Mau)&&s.Size==c.Size);
            old.SoLuongDat = old.SoLuongDat- c.SoLuongDat;
            Sync();
        }
        public void Sync()
        {
            quanLyBanGiayContext.SaveChanges();
        }
    }
}
