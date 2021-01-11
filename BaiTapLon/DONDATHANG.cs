using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLon
{
    public class DONDATHANG
    {
        public string MADDH { get; set; }
        public string GHICHU { get; set; }
        public KHACHHANG khachhang { get; set; }
        public DONDATHANG(string MADDH,string GHICHU,KHACHHANG x)
        {
            this.MADDH = MADDH;
            this.GHICHU = GHICHU;
            this.khachhang = x;
        }
        public DONDATHANG(DONDATHANG x)
        {
            this.MADDH = x.MADDH;
            this.GHICHU = x.GHICHU;
            this.khachhang = x.khachhang;
        }
    }
}
