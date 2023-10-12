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
    public class NhaSanXuat_DAL
    {
        KetNoiDatabase KetNoi = new KetNoiDatabase();
        //  LẤY DỮ LIỆU
        public DataTable GetData(string Condition)
        {
            return KetNoi.GetDataTable("Select * from NhaSanXuat" + Condition);
        }

        //Hien Thị Tìm Kiếm
        public DataTable GetTimKiem(string Condition)
        {
            return KetNoi.GetDataTable(""+Condition);
        }

        // THÊM DỮ LIỆU
        public void AddData(NhaSanXuat ex)
        {
            KetNoi.ExecuteReader(@"INSERT INTO NhaSanXuat(MaNSX,TenNSX,DiaChi,TrangThai)      
                                   VALUES(N'" + ex.MaNSX + "',N'" + ex.TenNSX + "',N'"+ex.DiaChi+"',N'" + ex.TrangThai + "')");
        }
        //  SỬA DỮ LIỆU
        public void EditData(NhaSanXuat ex)
        {
            KetNoi.ExecuteReader(@"update NhaSanXuat SET TenNSX=N'"+ex.TenNSX+"',DiaChi=N'"+ex.DiaChi+"',TrangThai=N'"+ex.TrangThai+"' Where MaNSX='"+ex.MaNSX+"'");

        }
        //  XÓA DỮ LIỆU
        public void DeleteData(NhaSanXuat ex)
        {
            KetNoi.ExecuteReader(@"DELETE FROM NhaSanXuat Where MaNSX=N'" + ex.MaNSX + "' ");
        }

        // Search
        public void TimKiem(NhaSanXuat ex)
        {
            KetNoi.ExecuteReader(@"Select * From NhaSanXuat Where TenNSX Like N'%" + ex.TenNSX + "'");
        }
       
    }
}
