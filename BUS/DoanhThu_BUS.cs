using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using DTO;
namespace BUS
{
    public class DoanhThu_BUS
    {
        DoanhThu_DAL bus = new DoanhThu_DAL();

        public DataTable DoanhThuTatCa(string condition)
        {
            return bus.DoanhThuTatCa(condition);
        }

        public DataTable DoanThuTheoNam(string condition)
        {
            return bus.DoanhThuTheoNam(condition);
        }

        public DataTable DoanhThuTheoThang(string condition, string condition1)
        {
            return bus.DoanhThuTheoThang(condition, condition1);
        }

        public DataTable DoanhThuTheoNgay(string condition)
        {
            return bus.DoanhThuTheoNgay(condition);
        }

        public DataTable SPBanChayTheoThang(string condition, string condition2)
        {
            return bus.SPBanChayTheoThang(condition, condition2);
        }

        public DataTable Top3SanPhamBanTrongNam(string condition)
        {
            return bus.Top3SanPhamBanTrongNam(condition);
        }
        public DataTable Top3MuaMonth(string condition, string condition1)
        {
            return bus.Top3SPMuaNhieuTrongThang(condition, condition1);
        }
        public DataTable Top3SPMuaYear(string condition)
        {
            return bus.Top3SPMuaNhieuTrongName(condition);
        }
        public DataTable Top3HDMuaNhieu(string condition)
        {
            return bus.Top3HDMuaNhieu(condition);
        }
        public DataTable LoadDoanhThuChart(string condition)
        {
            return bus.LoadDoanhThuLenChart(condition);
        }

        public DataTable DoanhThuCacThang()
        {
            return bus.DoanhThuCacThang();
        }

        public DataTable KhachhangMuaNhieu(string condition, string condition1)
        {
            return bus.KhachHangMuaNhieu(condition, condition1);
        }
        public DataTable KhachHangMuaNhieuTrongNam(string condition)
        {
            return bus.KhachHangMuaNhieuTrongNam(condition);
        }
        public DataTable KhoanChiTheoThang(string condition)
        {
            return bus.KhoanChiTheoThang(condition);
        }
        public DataTable ThuChiTheoNam(string condition)
        {
            return bus.ThuChiTheoNam(condition);
        }

        public DataTable SanPhamTonKho(string condition)
        {
            return bus.SanPhamTonKho(condition);
        }
        public DataTable SanPhamHetHang(string condition)
        {
            return bus.SanPhamHetHang(condition);
        }
    }
}
