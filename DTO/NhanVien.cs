using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVien
    {
        public string MaNV { get; set; }
        public string MaCV { get; set; }
        public string TenNV { get; set; }
        public string GioiTinh { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string Email { get; set; }
        public string DienThoai { get; set; }
        public string CMND { get; set; }
        public string DiaChi { get; set; }
        public string HinhAnh { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public string TrangThai { get; set; }

        public NhanVien() { }

        public NhanVien(DataRow row)
        {
            this.MaNV = row["MaNV"].ToString();
            this.TenNV = row["TenNV"].ToString();
            this.GioiTinh = row["GioiTinh"].ToString();
            this.NgaySinh = (DateTime)row["NgaySinh"];
            this.Email = row["Email"].ToString();
            this.DienThoai = row["DienThoai"].ToString();
            this.CMND = row["CMND"].ToString();
            this.DiaChi = row["DiaChi"].ToString();
            this.HinhAnh = row["HinhAnh"].ToString();
            this.UserName = row["UserName"].ToString();
            this.PassWord = row["PassWord"].ToString();
        }
    }
}
