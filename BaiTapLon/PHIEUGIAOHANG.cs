using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLon
{
    public class PHIEUGIAOHANG
    {
        public string MAPHIEUGIAOHANG { get; set; }
        public string GHICHU { get; set; }
        public DONDATHANG dondathang { get; set; }
        public PHIEUGIAOHANG(string MAPHIEUGIAOHANG, string GHICHU , DONDATHANG x)
        {
            this.MAPHIEUGIAOHANG = MAPHIEUGIAOHANG;
            this.GHICHU = GHICHU;
            this.dondathang = x;
        }
        public PHIEUGIAOHANG(PHIEUGIAOHANG x)
        {
            this.MAPHIEUGIAOHANG = x.MAPHIEUGIAOHANG;
            this.GHICHU = x.GHICHU;
            this.dondathang = x.dondathang;
        }
    }
}
