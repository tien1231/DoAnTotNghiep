using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;

namespace BUS
{
   public class LoaiLinhKien_BUS
    {
        LoaiLinhKien_DAL bus = new LoaiLinhKien_DAL();
        //  LẤY DỮ LIỆU
        public DataTable GetData(string Condition)
        {
            return bus.GetData(Condition);
        }
        public DataTable LayDuLieu(string condition)
        {
            return bus.LayDuLieu(condition);
        }
        // Tim kiem
        public DataTable GetSearch(string condition)
        {
            return bus.GetSearch(condition);
        }
        // THEM DATA
        public void AddData(LoaiLinhKien ex)
        {
            bus.AddData(ex);
        }
        public void EditData(LoaiLinhKien ex)
        {
            bus.EditData(ex);
        }
        public void DeleteData(LoaiLinhKien ex)
        {
            bus.DeleteData(ex);
        }
    }
}
