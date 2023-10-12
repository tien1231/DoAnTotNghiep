using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
using DTO;
namespace BUS
{
    public class PhieuBaoHanh_BUS
    {
        BaoHanh_DAL bus = new BaoHanh_DAL();
        public DataTable GetPBH(string condition)
        {
            return bus.GetPBH(condition);
        }
        public DataTable PhatSinhMa(string condition)
        {
            return bus.PhatSinhMa(condition);
        }
        public DataTable HienThiHhDBH(string condition)
        {
            return bus.HienThiHDBH(condition);
        }

        public DataTable HienThiCTPhieu(string condition)
        {
            return bus.HienThiCT_PhieuBaoHanh(condition);
        }
        public DataTable LoadCT_PhieuTheoMa(string condition)
       {
           return bus.HienThiCT_PhieuBaoHanhTheoMa(condition);
       }
        public void ThemPBH(PhieuBaoHanh ex)
        {
            bus.ThemPBH(ex);
        }

        public void ThemCTPhieuBH(CT_PhieuBaoHanh ex)
        {
            bus.ThemCTPhieuBaoHanh(ex);
        }
        public DataTable GetNhanVien(string Condition)
        {
            return bus.GetNhanVien(Condition);
        }

        public DataTable GetDSLK(string condition)
        {
            return bus.DSSP(condition);
        }

        public void XoaCTPhieuBaoHanh(CT_PhieuBaoHanh ex)
        {
            bus.XoaCTPhieuBaoHanh(ex);
        }
        public void XoaPhieuBaoHanh(PhieuBaoHanh ex)
        {
            bus.XoaPhieuBaoHanh(ex);
        }
        public void Update_CTPBH(CT_PhieuBaoHanh ex)
        {
            bus.Update_CTPBH(ex);
        }
        public void Update_PBH(PhieuBaoHanh ex)
        {
            bus.Update_PBH(ex);
        }
        public DataTable TimHD(string condition)
        {
            return bus.TimHD(condition);
        }

        public DataTable DanhSachKH(string condition)
        {
            return bus.DanhSachKH(condition);
        }

        public DataTable LayTTKH(string condition)
        {
            return bus.LayThongTinKH(condition);
        }
    }
}
