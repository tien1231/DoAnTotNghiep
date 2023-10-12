using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
namespace DAL
{
    public class HoaDon_DAL
    {
        KetNoiDatabase KetNoi = new KetNoiDatabase();

        public DataTable GetHoaDon(string Condition)
        {
            return KetNoi.GetDataTable("Select HoaDonBanHang.MaHDBH,TenKH,TennV,HoaDonBanHang.NgayLapHDBH,TongTien From HoaDonBanHang,NhanVien,KhachHang Where NhanVien.MaNV=HoaDonBanHang.MaNV and KhachHang.MaKH=HoaDonBanHang.MaKH and HoaDonBanHang.TrangThai=N'1'" + Condition);
        }
        public DataTable LayDSHD(string condition)
        {
            return KetNoi.GetDataTable("Select HoaDonBanHang.MaHDBH,TenKH,TennV,HoaDonBanHang.NgayLapHDBH,TongTien From HoaDonBanHang,NhanVien,KhachHang Where NhanVien.MaNV=HoaDonBanHang.MaNV and KhachHang.MaKH=HoaDonBanHang.MaKH and HoaDonBanHang.TrangThai=N'1'" + condition);
        }

        public DataTable HienThiHDTheoMa(string condition)
        {
            return KetNoi.GetDataTable("" + condition);
        }
        public DataTable GetCtHoaDon(string Condition)
        {
            return KetNoi.GetDataTable("" + Condition);

        }
        public DataTable LayDsCTHoaDon(string condition)
        {
            return KetNoi.GetDataTable("" + condition);
        }
        public DataTable GetNhanVien(string conditon)
        {
            return KetNoi.GetDataTable("Select MaNV,TenNV From NhanVien" + conditon);
        }

        public DataTable GetKhachHang(string conditon)
        {
            return KetNoi.GetDataTable("select MaKH,TenKH From KhachHang" + conditon);
        }

        public DataTable GetLinhKien(string condition)
        {
            return KetNoi.GetDataTable("Select MaLK,TenLK From LinhKien" + condition);
        }

        public DataTable GetLinhKienT(string condition)
        {
            return KetNoi.GetDataTable("" + condition);
        }
        public void UpdateHoaDon(HoaDonBanHang ex)
        {
            KetNoi.ExecuteReader(@"update HoaDonBanHang Set MaNV=N'" + ex.MaNV + "', NgayLapHDBH=N'" + ex.NgayLapHDBH + "',TongTien=" + ex.TongTien + " Where MaHDBH=N'" + ex.MaHDBH + "'");
        }

        public void UpdateCTHoaDon(CT_HoaDonBanHang exx)
        {
            KetNoi.ExecuteReader(@"Update CT_HoaDonBanHang Set SoLuong=" + exx.SoLuong + ",DonGia=" + exx.DonGia + ",KhuyenMai=" + exx.KhuyenMai + ",ThanhTien=" + exx.ThanhTien + " Where MaLK=N'" + exx.MaLK + "'");
        }

        public void UpdateSoLuongKho(LinhKien ex)
        {
            KetNoi.ExecuteReader(@"Update LinhKien Set SoLuongTon=" + ex.SoLuongTon + " Where MaLK=N'" + ex.MaLK + "'");
        }
        public void ThemCTHD(CT_HoaDonBanHang ex)
        {
            KetNoi.ExecuteReader(@"Insert Into CT_HoaDonBanHang(MaHDBH,MaLK,SoLuong,DonGia,KhuyenMai,ThanhTien,TrangThai) Values(N'" + ex.MaHDBH + "',N'" + ex.MaLK + "'," + ex.SoLuong + "," + ex.DonGia + "," + ex.KhuyenMai + "," + ex.ThanhTien + ",N'" + ex.TrangThai + "')");
        }

        public void DeleteCTHd(CT_HoaDonBanHang ex)
        {
            KetNoi.ExecuteReader(@"Update CT_HoaDonBanhang Set TrangThai=N'0' Where MaHDBH=N'" + ex.MaHDBH + "'");
        }
        public void DeleteHoaDon(HoaDonBanHang ex)
        {
            KetNoi.ExecuteReader(@"Update HoaDonBanHang Set TrangThai=N'0' Where MaHDBH=N'" + ex.MaHDBH + "'");
        }

        public DataTable GetSearch(string Condition)
        {
            return KetNoi.GetDataTable("" + Condition);
        }

        public DataTable LayDSSP(string condition)
        {
            return KetNoi.GetDataTable("" + condition);
        }

        public DataTable LayTTKH(string condition)
        {
            return KetNoi.GetDataTable("" + condition);
        }
    }
}
