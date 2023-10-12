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
    public class KhachHang_BUS
    {
        KetNoiDatabase c = new KetNoiDatabase();
        KhachHang_DAL bus = new KhachHang_DAL();
        DataTable da = new DataTable();
        //  LẤY DỮ LIỆU
        public DataTable GetData(string Condition)
        {
            return bus.GetData(Condition);
        }
        public DataTable PhatSinhMa(string condition)
        {
            return bus.PhatSinhMa(condition);
        }
        public DataTable KiemTraDuLieu(string condtion)
        {
            return bus.KiemTraDuLieu(condtion);
        }
        public DataTable GetSearch(string condition)
        {
            return bus.GetSearch(condition);
        }
        // THEM DATA
        public void AddData(KhachHang ex)
        {
            bus.AddData(ex);
        }
        public void EditData(KhachHang ex)
        {
            bus.EditData(ex);
        }
        public void DeleteData(KhachHang ex)
        {
            bus.DeleteData(ex);
        }
    }
}
