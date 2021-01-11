using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLon
{
    public class CHITIET_HDCCAP
    {
        public HOPDONGCUNGCAP hopdongcungcap { get; set; }
        public SANPHAM sanpham { get; set; }
        public int SOLUONG { get; set; }
        public int THANHTIEN { get; set; }
        public CHITIET_HDCCAP(HOPDONGCUNGCAP hopdongcungcap , SANPHAM sanpham , int SOLUONG , int THANHTIEN)
        {
            this.hopdongcungcap = hopdongcungcap;
            this.sanpham = sanpham;
            this.SOLUONG = SOLUONG;
            this.THANHTIEN = THANHTIEN;
        }
        public CHITIET_HDCCAP(CHITIET_HDCCAP x)
        {
            this.hopdongcungcap = x.hopdongcungcap;
            this.sanpham = x.sanpham;
            this.SOLUONG = x.SOLUONG;
            this.THANHTIEN = x.THANHTIEN;
        }
    }
}
