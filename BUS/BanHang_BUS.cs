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
    public class BanHang_BUS
    {
        BanHang_DAL bus = new BanHang_DAL();
        //  LẤY DỮ LIỆU
        public DataTable GetData(string Condition)
        {
            return bus.GetData(Condition);
        }
        public DataTable PhatSinhMaHDBH(string condition)
        {
            return bus.PhatSinhMaHD(condition);
        }
        public DataTable GetDSSP(string Condition)
        {
            return bus.GetDSSP(Condition);
        }

        public void AddHoaDon(HoaDonBanHang ex)
        {
            bus.AddHoaDon(ex);
        }
        public void AddCTHD(CT_HoaDonBanHang exx)
        {
            bus.AddCTHD(exx);
        }

        public void AddKH(KhachHang ex)
        {
            bus.AddKH(ex);
        }
        public DataTable GetDSkH(string Condition)
        {
            return bus.GetDSkH(Condition);
        }

        public DataTable GetNhanVien(string Condition)
        {
            return bus.GetNhanVien(Condition);
        }

        public DataTable GetTimKiem(string Condition)
        {
            return bus.GetTimKiem(Condition);
        }

        public DataTable GetHienThiDSSpTheoMa(string condition)
        {
            return bus.GetHienThiDSSPTheoMa(condition);
        }

        public void UpdateSL(LinhKien lk)
        {
            bus.UpdateSL(lk);
        }

        public void CapNhatSLTon(LinhKien lk)
        {
            bus.CapNhatSLTon(lk);
        }

        public DataTable LaySP(string condition)
        {
            return bus.LaySP(condition);
        }
    }
}
