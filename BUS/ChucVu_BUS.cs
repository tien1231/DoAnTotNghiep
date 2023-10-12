using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class ChucVu_BUS
    {
         ChucVu_DAL bus = new ChucVu_DAL();

        public DataTable GetChucVu(string condition)
        {
            return bus.GetChucVu(condition);
        }

        public void AddChucVu(ChucVu ex)
        {
            bus.AddChucVu(ex);
        }
        public void EditCV(ChucVu ex)
        {
            bus.EditChuCVu(ex);
        }

        public void DeleteChucVu(ChucVu ex)
        {
            bus.DeleteChucVu(ex);
        }
    }
}
