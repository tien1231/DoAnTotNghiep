using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class LoaiLinhKien_DAL
    {
        KetNoiDatabase KetNoi = new KetNoiDatabase();
        //  LẤY DỮ LIỆU
        public DataTable GetData(string Condition)
        {
            return KetNoi.GetDataTable("Select * from LoaiLinhKien Where TrangThai=N'1' Order By TenLLK ASC" + Condition);
        }
        public DataTable LayDuLieu(string condition)
        {
            return KetNoi.GetDataTable("Select * From LoaiLinhKien" + condition);
        }
        //Tim Kiem
        public DataTable GetSearch(string condition)
        {
            return KetNoi.GetDataTable("Select * from LoaiLinhKien Where TenLLK Like N'%" + condition + "%'");
        }
        // THÊM DỮ LIỆU
        public void AddData(LoaiLinhKien ex)
        {
            KetNoi.ExecuteReader(@"INSERT INTO LoaiLinhKien(MaLLK,TenLLK,TrangThai)      
                                   VALUES(N'" + ex.MaLLK + "',N'" + ex.TenLLK + "',N'" + ex.TrangThai + "')");
        }
        //  SỬA DỮ LIỆU
        public void EditData(LoaiLinhKien ex)
        {
            KetNoi.ExecuteReader(@"UPDATE LoaiLinhKien SET TenLLK=N'" + ex.TenLLK + "',TrangThai='" + ex.TrangThai + "' Where MaLLK='" + ex.MaLLK + "'");

        }
        //  XÓA DỮ LIỆU
        public void DeleteData(LoaiLinhKien ex)
        {
            KetNoi.ExecuteReader(@"Update LoaiLinhKien Set TrangThai=N'0' Where MaLLK=N'" + ex.MaLLK + "'");
        }
    }
}
