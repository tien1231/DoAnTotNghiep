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
    public class NhapKho_BUS
    {
        NhapKho_DAL bus = new NhapKho_DAL();

        public DataTable GetData(string Condition)
        {
            return bus.GetData(Condition);
        }

        public void AddHoaDon(HoaDonNhapHang ex)
        {
            bus.AddHoaDon(ex);
        }
        public void AddCTHD(CT_HoaDonNhapHang exx)
        {
            bus.AddCTHD(exx);
        }

        public DataTable GetNhanVien(string Condition)
        {
            return bus.GetNhanVien(Condition);
        }

        public DataTable GetNCC(string condition)
        {
            return bus.GetNCC(condition);
        }

        public DataTable HienThiHDN(string condition)
        {
            return bus.HienThiHDN(condition);
        }
        public DataTable PhatSinhMa(string condition)
        {
            return bus.PhatSinhMa(condition);
        }
        public DataTable LoadNCC(string codition)
        {
            return bus.LoadNCC(codition);
        }
        public DataTable HienThiCTHDNH(string condition)
        {
            return bus.HienThiCTHDNH(condition);
        }

        public void DeleteHoaDonNhap(HoaDonNhapHang ex)
        {
            bus.DeleteHoaDonNhap(ex);
        }
        public void DeleteCT_HoaDonNhap(CT_HoaDonNhapHang ex)
        {
            bus.DeleteCT_HoaDonNhap(ex);
        }
        public void XoaCTHoaDonNhap(CT_HoaDonNhapHang ex)
        {
            bus.XoaCTHoaDonNhap(ex);
        }
        public void UpdateCTHDN(CT_HoaDonNhapHang ex)
        {
            bus.UpdateCTHDN(ex);
        }

        public void UpdateHDN(HoaDonNhapHang ex)
        {
            bus.UpdateHDN(ex);
        }

        public void CapNhatSLKho(LinhKien ex)
        {
            bus.CapNhatSLKho(ex);
        }
        public void CapNhatSLKho1(LinhKien ex)
        {
            bus.CapNhatSLKho1(ex);
        }
        public DataTable LayDSSP(string condition)
        {
            return bus.LayDSSP(condition);
        }
    }
}
