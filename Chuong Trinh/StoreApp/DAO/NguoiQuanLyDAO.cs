using StoreApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.DAO
{
    class NguoiQuanLyDAO
    {
        private QuanLyBanGiayContext quanLyBanGiayContext;
        public NguoiQuanLyDAO()
        {
            quanLyBanGiayContext = new QuanLyBanGiayContext();
        }
        public List<Nguoiquanly> getAll()
        {
            return quanLyBanGiayContext.Nguoiquanlies.ToList();
        }
        public Nguoiquanly getByID(string id)
        {
            return quanLyBanGiayContext.Nguoiquanlies.FirstOrDefault(n => n.MaNql.Equals(id));
        }
    }
}
