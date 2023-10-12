using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAL
{
    public class DoanhThu_DAL
    {
        KetNoiDatabase KetNoi = new KetNoiDatabase();

        public DataTable DoanhThuTatCa(string Condition)
        {
            return KetNoi.GetDataTable("Select SUM(TongTien) AS DoanhThu from HoaDonBanHang" + Condition);
        }

        public DataTable DoanhThuTheoNam(string condition)
        {
            return KetNoi.GetDataTable("Select format(sum([TongTien]),'N0') as TT" +
                " From HoaDonBanHang Where YEAR(NgayLapHDBH) =" + condition + "");
        }

        public DataTable DoanhThuTheoThang(string condition, string condition1)
        {
            return KetNoi.GetDataTable("SELECT   format(sum([TongTien]),'N0') AS TT" +
              " FROM HoaDonBanHang hd WHERE Month(hd.NgayLapHDBH)=" + condition + " and Year(hd.NgayLapHDBH)=" + condition1 + " ");
        }
        public DataTable KhoanChiTheoThang(string condition)
        {
            return KetNoi.GetDataTable("SELECT   format(sum([TongTien]),'N0') AS TT" +
              " FROM HoaDonNhapHang hd WHERE Month(hd.NgayLapHDNH)=" + condition + "");
        }
        public DataTable DoanhThuTheoNgay(string condiiton)
        {
            return KetNoi.GetDataTable("" + condiiton);
        }

        public DataTable SPBanChayTheoThang(string condiiton, string condition2)
        {
            return KetNoi.GetDataTable("SELECT TOP(3) lk.TenLK As'Tên Sản Phẩm', SUM(ct.SoLuong) AS 'Số Lượng'  " +
                "FROM CT_HoaDonBanHang ct, HoaDonBanHang hd, LinhKien lk " +
                "where ct.MaHDBH = hd.MaHDBH and lk.MaLK = ct.MaLK  and MONTH(hd.NgayLapHDBH) =" + condiiton + " and Year(hd.NgayLapHDBH)=" + condition2 + "" +
                " GROUP BY lk.TenLK ORDER BY SUM(ct.SoLuong) DESC ");
        }

        public DataTable Top3SanPhamBanTrongNam(string condiiton)
        {
            return KetNoi.GetDataTable("SELECT TOP(3) lk.TenLK As'Tên Sản Phẩm', SUM(ct.SoLuong) AS 'Số Lượng'" +
                " FROM CT_HoaDonBanHang ct, HoaDonBanHang hd, LinhKien lk" +
                " where ct.MaHDBH = hd.MaHDBH and lk.MaLK = ct.MaLK  and Year(hd.NgayLapHDBH) =" + condiiton + " " +
                "GROUP BY lk.TenLK ORDER BY SUM(ct.SoLuong) DESC");
        }
        public DataTable Top3SPMuaNhieuTrongThang(string condition, string condition1)
        {
            return KetNoi.GetDataTable("SELECT TOP(3) lk.TenLK As'Tên Sản Phẩm', SUM(ct.SoLuong) AS 'Số Lượng'" +
                " FROM CT_HoaDonNhapHang ct, HoaDonNhapHang hd, LinhKien lk " +
                "where ct.MaHDNH = hd.MaHDNH and lk.MaLK = ct.MaLK  and Month(hd.NgayLapHDNH) =" + condition + "and Year(hd.NgayLapHDNH)=" + condition1 + " " +
                "GROUP BY lk.TenLK ORDER BY SUM(ct.SoLuong) DESC");
        }
        public DataTable Top3SPMuaNhieuTrongName(string condition)
        {
            return KetNoi.GetDataTable("SELECT TOP(3) lk.TenLK As'Tên Sản Phẩm', SUM(ct.SoLuong) AS 'Số Lượng' " +
                "FROM CT_HoaDonNhapHang ct, HoaDonNhapHang hd, LinhKien lk " +
                "where ct.MaHDNH = hd.MaHDNH and lk.MaLK = ct.MaLK  and Year(hd.NgayLapHDNH) =" + condition + " " +
                "GROUP BY lk.TenLK ORDER BY SUM(ct.SoLuong) DESC");
        }
        public DataTable Top3HDMuaNhieu(string condition)
        {
            return KetNoi.GetDataTable("SELECT TOP(3) hd.MaHDBH As'Mã Hóa Đơn', count(ct.MaHDBH) AS 'Số Lượng'" +
                " FROM CT_HoaDonBanHang ct, HoaDonBanHang hd" +
                " where ct.MaHDBH = hd.MaHDBH  and Month(hd.NgayLapHDBH) =" + condition + " " +
                " GROUP BY hd.MaHDBH ORDER BY count(hd.MaHDBH) DESC ");
        }
        public DataTable LoadDoanhThuLenChart(string condition)
        {
            return KetNoi.GetDataTable("select MONTH(NgayLapHDBH) AS Thang, Sum(TongTien)From HoaDonBanHang Group by MONTH(NgayLapHDBH)" + condition);
        }

        public DataTable DoanhThuCacThang()
        {
            return KetNoi.GetDataTable("SELECT Month(hd.NgayLapHDBH) as Thang, sum(hd.TongTien) as TongTien " +
            " FROM HoaDonBanHang hd WHERE hd.TrangThai=N'1' and Month(hd.NgayLapHDBH)>0 and MONTH(hd.NgayLapHDBH)<13  Group By Month(hd.NgayLapHDBH) ");
        }

        public DataTable KhachHangMuaNhieu(string condition, string condition1)
        {
            return KetNoi.GetDataTable("SELECT TOP(1) kh.TenKH As'Tên Khách Hàng', count(hd.MaHDBH) AS 'Số Lần' FROM  HoaDonBanHang hd,KhachHang kh where kh.MaKH=hd.MaKH and month(hd.NgayLapHDBH) =" + condition + " and Year(hd.NgayLapHDBH)=" + condition1 + " GROUP BY kh.TenKH ORDER BY count(hd.MaHDBH) DESC");
        }

        public DataTable KhachHangMuaNhieuTrongNam(string condition)
        {
            return KetNoi.GetDataTable("SELECT TOP(1) kh.TenKH As'Tên Khách Hàng', count(hd.MaHDBH) AS 'Số Lần' FROM  HoaDonBanHang hd,KhachHang kh where kh.MaKH=hd.MaKH and year(hd.NgayLapHDBH) =" + condition + " GROUP BY kh.TenKH ORDER BY count(hd.MaHDBH) DESC");
        }

        public DataTable ThuChiTheoNam(string condition)
        {
            return KetNoi.GetDataTable("SELECT   format(sum([TongTien]),'N0') AS TT" +
              " FROM HoaDonNhapHang hd WHERE Year(hd.NgayLapHDNH)=" + condition + "");
        }

        public DataTable SanPhamTonKho(string condition)
        {
            return KetNoi.GetDataTable("Select TenLK as 'Tên Linh Kiện',SoLuongTon as 'Số Lượng Tồn' From LinhKien Where TrangThai=N'1' and SoLuongTon>5" + condition);
        }
        public DataTable SanPhamHetHang(string condition)
        {
            return KetNoi.GetDataTable("Select MaLK,TenLK,SoLuongTon From LinhKien Where SoLuongTon<5" + condition);
        }
    }
}
