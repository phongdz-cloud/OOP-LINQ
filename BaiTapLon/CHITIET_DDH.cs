using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLon
{
    public class CHITIET_DDH
    {
        public DONDATHANG dondathang { get; set; }
        public SANPHAM sanpham { get; set; }
        public string NGAYDATHANG { get; set; }
        public int SOLUONG { get; set; }
        public CHITIET_DDH(DONDATHANG dondathang,SANPHAM sanpham,string NGAYDATHANG ,int SOLUONG )
        {
            this.dondathang = dondathang;
            this.sanpham = sanpham;
            this.NGAYDATHANG = NGAYDATHANG;
            this.SOLUONG = SOLUONG;
        }
        public CHITIET_DDH(CHITIET_DDH x)
        {
            this.dondathang = x.dondathang;
            this.sanpham = x.sanpham;
            this.NGAYDATHANG = x.NGAYDATHANG;
            this.SOLUONG = x.SOLUONG;
        }
    }
}
