using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreApp.Models;
namespace StoreApp.DAO
{
    class NhaCungCapDAO
    {
        private QuanLyBanGiayContext quanLyBanGiayContext;
        public NhaCungCapDAO()
        {
            quanLyBanGiayContext = new QuanLyBanGiayContext();
        }
        public List<Nhacungcap> getAll()
        {
            return quanLyBanGiayContext.Nhacungcaps.ToList();
        }
        public Nhacungcap getByID(string id)
        {
            return quanLyBanGiayContext.Nhacungcaps.FirstOrDefault(n=>n.MaNcc.Equals(id));
        }
        public void Add(Nhacungcap n)
        {
            quanLyBanGiayContext.Nhacungcaps.Add(n);
            Sync();
        }
        public void Update(string id, Nhacungcap n)
        {
            Nhacungcap old = quanLyBanGiayContext.Nhacungcaps.FirstOrDefault(s => s.MaNcc == id);
            old.TenNcc = n.TenNcc;
            old.Sdtncc = n.Sdtncc;
            old.TinhTrang = n.TinhTrang;
            old.DiaChiNcc = n.DiaChiNcc;
            Sync();
        }
        public List<Nhacungcap> FindByName(string name)
        {
            return quanLyBanGiayContext.Nhacungcaps.Where(s => s.TenNcc.Contains(name)).ToList();
        }
        public void Sync()
        {
            quanLyBanGiayContext.SaveChanges();
        }
    }
}
