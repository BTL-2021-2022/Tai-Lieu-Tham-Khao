using StoreApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.DAO
{
    class ChiTietHoaDonNhapDAO
    {
        private QuanLyBanGiayContext quanLyBanGiayContext;
        public ChiTietHoaDonNhapDAO()
        {
            quanLyBanGiayContext = new QuanLyBanGiayContext();
        }
        public Chitiethoadonnhap layBangMaSanPham(string id)
        {
            try
            {
                return quanLyBanGiayContext.Chitiethoadonnhaps.FirstOrDefault(x => x.MaSp.Equals(id));
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public List<Chitiethoadonnhap> layBangSoHoaDon(int id)
        {
            try
            {
                return quanLyBanGiayContext.Chitiethoadonnhaps.Where(x => x.SoHdn==id).ToList();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public List<Chitiethoadonnhap> getAll()
        {
            return quanLyBanGiayContext.Chitiethoadonnhaps.ToList();
        }
        public void add(Chitiethoadonnhap c)
        {
            quanLyBanGiayContext.Chitiethoadonnhaps.Add(c);
            Sync();
        }
        public void Sync()
        {
            quanLyBanGiayContext.SaveChanges();
        }
        
    }
}
