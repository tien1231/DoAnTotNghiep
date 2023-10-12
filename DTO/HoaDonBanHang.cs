using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDonBanHang
    {
        public string MaHDBH { get; set; }
        public string MaKH { get; set; }
        public string MaNV { get; set; }
        public DateTime ? NgayLapHDBH { get; set; }
        public decimal TongTien { get; set; }
        public string TrangThai { get; set; }

    }
}
