using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CT_HoaDonNhapHang
    {
        public string MaHDNH { get; set; }
        public string MaLK { get; set;}
        public int? SoLuong { get; set; }
        public decimal DonGia { get; set; }
        public decimal ThanhTien{get;set;}
        public decimal KhuyenMai{get;set;}
        public string TrangThai { get; set; }
    }
}
