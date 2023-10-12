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
   public class NhaSanXuat_BUS
    {
        NhaSanXuat_DAL bus = new NhaSanXuat_DAL();
        //  LẤY DỮ LIỆU
        public DataTable GetData(string Condition)
        {
            return bus.GetData(Condition);
        }
        // THEM DATA
        public void AddData(NhaSanXuat ex)
        {
            bus.AddData(ex);
        }
        public void EditData(NhaSanXuat ex)
        {
            bus.EditData(ex);
        }
        public void DeleteData(NhaSanXuat ex)
        {
            bus.DeleteData(ex);
        }
        public DataTable GetTimKiem(string Condition)
        {
           return bus.GetTimKiem(Condition);
        }
       public void TimKiem(NhaSanXuat ex)
        {
            bus.TimKiem(ex);
        }
    }
}
