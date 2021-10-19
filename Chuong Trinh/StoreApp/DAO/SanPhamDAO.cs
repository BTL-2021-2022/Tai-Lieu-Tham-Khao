using StoreApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.DAO
{
    class SanPhamDAO
    {
        private QuanLyBanGiayContext quanLyBanGiayContext;
        public SanPhamDAO()
        {
            quanLyBanGiayContext = new QuanLyBanGiayContext();
        }
        public List<Sanpham> getAll()
        {
            return quanLyBanGiayContext.Sanphams.ToList();
        }
        public Sanpham getByID(string id)
        {
            return quanLyBanGiayContext.Sanphams.FirstOrDefault(s=>s.MaSp.Equals(id));
        }
    }
}
