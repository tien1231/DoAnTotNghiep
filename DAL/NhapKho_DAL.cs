using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
namespace DAL
{
    public class NhapKho_DAL
    {
        KetNoiDatabase KetNoi = new KetNoiDatabase();

        public DataTable GetData(string Condition)
        {
            return KetNoi.GetDataTable("Select MaLK,TenLK from LinhKien where TrangThai=N'1' " + Condition);
        }
        public DataTable GetDSSP(string Condition)
        {
            return KetNoi.GetDataTable("" + Condition);
        }

        public DataTable GetNhanVien(string Condition)
        {
            return KetNoi.GetDataTable("" + Condition);
        }

        public DataTable GetNCC(string condition)
        {
            return KetNoi.GetDataTable("Select * From NhaCungCap" + condition);
        }

        public DataTable HienThiHDN(string condition)
        {
            return KetNoi.GetDataTable("select MaHDNH,NCC.TenNCC,NV.TenNV,NgayLapHDNH,TongTien,HD.TrangThai From HoaDonNhapHang HD,NhaCungCap NCC,NhanVien NV Where NV.MaNV=HD.MaNV and NCC.MaNCC=HD.MaNCC and HD.TrangThai=N'1'" + condition);
        }
        public DataTable PhatSinhMa(string condition)
        {
            return KetNoi.GetDataTable("Select * From HoaDonNhapHang" + condition);
        }

        public DataTable LoadNCC(string codition)
        {
            return KetNoi.GetDataTable("select ncc.TenNCC,ncc.MaNCC  from NhaCungCap ncc,LinhKien lk where lk.MaNCC=ncc.MaNCC and lk.MaLK=N'" + codition + "'");
        }
        public DataTable HienThiCTHDNH(string condition)
        {
            return KetNoi.GetDataTable("" + condition);
        }
        public void AddHoaDon(HoaDonNhapHang ex)
        {
            KetNoi.ExecuteReader(@"insert into HoaDonNhapHang(MaHDNH,MaNCC,MaNV,NgayLapHDNH,TongTien,TrangThai)
Values(N'" + ex.MaHDNH + "',N'" + ex.MaNCC + "',N'" + ex.MaNV + "','" + ex.NgayLapHDNH + "'," + ex.TongTien + ",N'" + ex.TrangThai + "')");
        }

        public void AddCTHD(CT_HoaDonNhapHang exx)
        {
            KetNoi.ExecuteReader(@"insert into CT_HoaDonNhapHang(MaHDNH,MaLK,SoLuong,DonGia,KhuyenMai,ThanhTien,TrangThai)
values(N'" + exx.MaHDNH + "',N'" + exx.MaLK + "'," + exx.SoLuong + "," + exx.DonGia + "," + exx.KhuyenMai + "," + exx.ThanhTien + ",N'" + exx.TrangThai + "')");
        }

        public void DeleteHoaDonNhap(HoaDonNhapHang ex)
        {
            KetNoi.ExecuteReader(@"Update HoaDonNhapHang Set TrangThai=N'0' Where MaHDNH=N'" + ex.MaHDNH + "'");
        }

        public void DeleteCT_HoaDonNhap(CT_HoaDonNhapHang ex)
        {
            KetNoi.ExecuteReader(@"Update CT_HoaDonNhapHang set TrangThai=N'0' Where MaHDNH=N'" + ex.MaHDNH + "' ");
        }

        public void XoaCTHoaDonNhap(CT_HoaDonNhapHang ex)
        {
            KetNoi.ExecuteReader(@"Delete From CT_HoaDonNhapHang Where MaHDNH=N'" + ex.MaHDNH + "' and MaLK=N'" + ex.MaLK + "'");
        }
        public void UpdateCTHDN(CT_HoaDonNhapHang ex)
        {
            KetNoi.ExecuteReader(@"update CT_HoaDonNhapHang Set SoLuong=" + ex.SoLuong + ",DonGia=" + ex.DonGia + ",KhuyenMai=" + ex.KhuyenMai + ",ThanhTien=" + ex.ThanhTien + " Where MaHDNH=N'" + ex.MaHDNH + "' and MaLK=N'" + ex.MaLK + "' ");
        }

        public void UpdateHDN(HoaDonNhapHang ex)
        {
            KetNoi.ExecuteReader(@" update HoaDonNhapHang Set NgayLapHDNH='" + ex.NgayLapHDNH + "',TongTien=" + ex.TongTien + " Where MaHDNH=N'" + ex.MaHDNH + "'");
        }

        public void CapNhatSLKho(LinhKien ex)
        {
            KetNoi.ExecuteReader(@"Update LinhKien Set SoLuongTon=" + ex.SoLuongTon + " Where MaLK=N'" + ex.MaLK + "'");
        }
        public void CapNhatSLKho1(LinhKien ex)
        {
            KetNoi.ExecuteReader(@"Update LinhKien Set SoLuongTon=" + ex.SoLuongTon + ",DonGia=" + ex.DonGia + " Where MaLK=N'" + ex.MaLK + "'");
        }
        public DataTable LayDSSP(string condition)
        {
            return KetNoi.GetDataTable("" + condition);
        }
    }
}
