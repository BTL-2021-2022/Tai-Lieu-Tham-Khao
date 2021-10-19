using StoreApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.DAO
{
    class DatHangNCCDAO
    {
        private QuanLyBanGiayContext quanLyBanGiayContext;
        public DatHangNCCDAO()
        {
            quanLyBanGiayContext = new QuanLyBanGiayContext();
        }
        public List<Dathangncc> getAll()
        {
            return quanLyBanGiayContext.Dathangnccs.ToList();
        }
        
    }
}
