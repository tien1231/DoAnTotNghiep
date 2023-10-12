using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace DAL
{
    public class KhachHang_DAL
    {
        KetNoiDatabase KetNoi = new KetNoiDatabase();
        //  LẤY DỮ LIỆU
        public DataTable GetData(string Condition)
        {
            return KetNoi.GetDataTable("Select MaKh,TenKH,GioiTinh,DienThoai,DiaChi from KhachHang Where TrangThai=N'1' Order By TenKH ASC" + Condition);
        }
        public DataTable PhatSinhMa(string condition)
        {
            return KetNoi.GetDataTable("Select * from KhachHang" + condition);
        }
        public DataTable KiemTraDuLieu(string condition)
        {
            return KetNoi.GetDataTable(condition);
        }
        public DataTable GetSearch(string Condition)
        {
            return KetNoi.GetDataTable("" + Condition);
        }
        // THÊM DỮ LIỆU
        public void AddData(KhachHang ex)
        {
            KetNoi.ExecuteReader(@"INSERT INTO KhachHang(MaKH,TenKH,GioiTinh,DienThoai,DiaChi,TrangThai)      
                                   VALUES(N'" + ex.MaKH + "',N'" + ex.TenKH + "',N'" + ex.GioiTinh +
                                    "',N'" + ex.DienThoai + "',N'" + ex.DiaChi + "',N'" + ex.TrangThai + "')");
        }
        //  SỬA DỮ LIỆU
        public void EditData(KhachHang ex)
        {
            KetNoi.ExecuteReader(@"UPDATE KhachHang SET TenKH =N'" + ex.TenKH + "', GioiTinh =N'" + ex.GioiTinh +
                  "', DienThoai =N'" + ex.DienThoai + "',DiaChi=N'" + ex.DiaChi + "',TrangThai=N'" + ex.TrangThai + "' Where MaKH=N'" + ex.MaKH + "'");

        }
        //  XÓA DỮ LIỆU
        public void DeleteData(KhachHang ex)
        {
            KetNoi.ExecuteReader(@"Update KhachHang Set TrangThai=N'0' Where MaKH=N'" + ex.MaKH + "'");
        }
        //Tìm Kiếm
        public void SearchData(KhachHang ex)
        {
            KetNoi.ExecuteReader(@"Select * FROM KhachHang Where TenKH LIKE N'%" + ex.TenKH + "%')");
        }
    }
}
