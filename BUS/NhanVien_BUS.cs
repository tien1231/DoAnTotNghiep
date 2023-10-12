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
    public class NhanVien_BUS
    {
        NhanVien_DAL bus = new NhanVien_DAL();

        public DataTable GetData(string condition)
        {
            return bus.GetData(condition);
        }
        public DataTable PhatSinhMa(string condition)
        {
            return bus.PhatSinhMa(condition);
        }
        public DataTable KiemTraDuLieu(string condition)
        {
            return bus.KiemTraDuLieu(condition);
        }
        public DataTable GetTimKiem(string condition)
        {
            return bus.GetTimKiem(condition);
        }
        // THEM DATA
        public void AddData(NhanVien ex)
        {
            bus.AddData(ex);
        }
        public void EditData(NhanVien ex)
        {
            bus.EditData(ex);
        }
        public void DeleteData(NhanVien ex)
        {
            bus.DeleteData(ex);
        }

        public DataTable ThongTinNhanVien(string condition)
        {
            return bus.ThongTinNhanVien(condition);
        }

        public DataTable LoadThongTin(string username)
        {
            return bus.LoadThongTin(username);
        }

        public void UpateThongTinNV(NhanVien nv)
        {
            bus.UpateThongTin(nv);
        }
    }
}
