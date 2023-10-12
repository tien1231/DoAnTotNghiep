using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;
namespace BUS
{
   public  class HoaDon_BUS
    {
        HoaDon_DAL bus = new HoaDon_DAL();
        public DataTable GetHoaDon(string Condition)
        {
            return bus.GetHoaDon(Condition);
        } 
        public DataTable GetCtHoaDon(string Condition)
        {
            return bus.GetCtHoaDon(Condition);
        }
        public DataTable LayDsCTHoaDon(string conditon)
        {
            return bus.LayDsCTHoaDon(conditon);
        }
        public DataTable HienThiCTHDTheoMa(string condition)
        {
            return bus.HienThiHDTheoMa(condition);
        }
        public DataTable GetNhanVien(string condition)
        {
            return bus.GetNhanVien(condition);
        }
        public DataTable GetKhachHang(string condition)
        {
            return bus.GetKhachHang(condition);
        }
        public DataTable GetLinhKien(string condition)
        {
            return bus.GetLinhKien(condition);
        }
        public DataTable GetLinhKienT(string condition)
        {
            return bus.GetLinhKienT(condition);
        }

        public void UpdateHoaDon(HoaDonBanHang ex)
        {
            bus.UpdateHoaDon(ex);
        }

        public void UpdateCTHoaDon(CT_HoaDonBanHang exx)
        {
            bus.UpdateCTHoaDon(exx);
        }
        public void UpdateSoLuongKho(LinhKien ex)
        {
            bus.UpdateSoLuongKho(ex);
        }
        public void ThemCTHD(CT_HoaDonBanHang ex)
        {
            bus.ThemCTHD(ex);
        }
        public void DeleteCTHd(CT_HoaDonBanHang ex)
        {
            bus.DeleteCTHd(ex);
        }

        public void DeleteHoaDon(HoaDonBanHang ex)
        {
            bus.DeleteHoaDon(ex);
        }
        public DataTable GetSearch(string condition)
        {
            return bus.GetSearch(condition);
        }

        public DataTable LayDSSP(string condition)
        {
            return bus.LayDSSP(condition);
        }

        public DataTable LayTTKH(string condition)
        {
            return bus.LayTTKH(condition);
        }
    }
}
