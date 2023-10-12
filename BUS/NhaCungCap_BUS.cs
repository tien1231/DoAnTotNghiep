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
    public class NhaCungCap_BUS
    {
        NhaCungCap_DAL bus = new NhaCungCap_DAL();
        //  LẤY DỮ LIỆU
        public DataTable GetData(string Condition)
        {
            return bus.GetData(Condition);
        }
        public DataTable PhatSinhMa(string condition)
        {
            return bus.PhatSinhMa(condition);
        }
        public DataTable KiemTraDuLieu(string condition)
        {
            return bus.KiemTraDuLieu(condition);
        }
        // Tim Kiem
        public DataTable GetSearch(string condition)
        {
            return bus.GetSearch(condition);
        }
        // THEM DATA
        public void AddData(NhaCungCap ex)
        {
            bus.AddData(ex);
        }
        public void EditData(NhaCungCap ex)
        {
            bus.EditData(ex);
        }
        public void DeleteData(NhaCungCap ex)
        {
            bus.DeleteData(ex);
        }


    }
}
