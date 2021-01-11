using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLon
{
    public class CHITIET_PGH
    {
        public PHIEUGIAOHANG phieugiaohang { get; set; }
        public SANPHAM sanpham { get; set; }
        public string NGAYGIAO { get; set; }
        public CHITIET_PGH(PHIEUGIAOHANG phieugiaohang, SANPHAM sanpham,string NGAYGIAO)
        {
            this.phieugiaohang = phieugiaohang;
            this.sanpham = sanpham;
            this.NGAYGIAO = NGAYGIAO;
        }
        public CHITIET_PGH(CHITIET_PGH x)
        {
            this.phieugiaohang = x.phieugiaohang;
            this.sanpham = x.sanpham;
            this.NGAYGIAO = x.NGAYGIAO;
        }
    }
}
