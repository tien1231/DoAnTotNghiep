using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
   public class ChucVu_DAL
    {
        KetNoiDatabase KetNoi = new KetNoiDatabase();
        // lay du lieu 
        public DataTable GetChucVu(string condition)
        {
            //return KetNoi.GetDataTable("select * from NhanVien where NhanVien.MaCV = ChucVu.MaCV" + condition);
            return KetNoi.GetDataTable("select * from ChucVu" + condition);
        }

        public void AddChucVu(ChucVu ex)
        {
            KetNoi.ExecuteReader(@"Insert into ChucVu Values(N'" + ex.MaCV + "',N'" + ex.TenCV + "','" + ex.NhanVien + "','" + ex.KhachHang + "','" + ex.LinhKien + "','" + ex.BanHang + "','" + ex.NhaCungCap + "','" + ex.LoaiLK +"','"+ex.NhapKho+"','"+ex.BaoHanh+"','"+ex.PhanQuyen+"','"+ex.ThongKe+"','"+ex.HoaDon+"','"+ex.Setting+"', N'"+ex.TrangThai+"')");
        }
        
        public void EditChuCVu(ChucVu ex)
        {
            KetNoi.ExecuteReader(@"update ChucVu Set TenCV=N'"+ex.TenCV+"',NhanVien='"+ex.NhanVien+"',KhachHang='"+ex.KhachHang+"',LinhKien='"+ex.LinhKien+"',BanHang='"+ex.BanHang+"',NhaCungCap='"+ex.NhaCungCap+"',LoaiLK='"+ex.LoaiLK+"',NhapKho='"+ex.NhapKho+"',BaoHanh='"+ex.BaoHanh+"',PhanQuyen='"+ex.PhanQuyen+"',ThongKe='"+ex.ThongKe+"',HoaDon='"+ex.HoaDon+"',Setting='"+ex.Setting+"',TrangThai=N'"+ex.TrangThai+"' Where MacV=N'"+ex.MaCV+"'");
        }

        public void DeleteChucVu(ChucVu ex)
        {
            KetNoi.ExecuteReader(@"Delete From ChucVu Where MaCV=N'" + ex.MaCV + "'");
        }
    }
}
