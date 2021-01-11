using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLon
{
    public class SANPHAM
    {
        public string MASANPHAM { get; set; }
        public string TENSANPHAM { get; set; }
        public string QUYCACH { get; set; }
        public int GIABAN { get; set; }
        public int SOLUONGTON { get; set; }
        public string NUOCSX { get; set; }
        public NHOMSANPHAM nhomsanpham { get; set; }

        public SANPHAM(string MASANPHAM,string TENSANPHAM,string QUYCACH, int GIABAN , int SOLUONGTON, string NUOCSX,NHOMSANPHAM x)
        {
            this.MASANPHAM = MASANPHAM;
            this.TENSANPHAM = TENSANPHAM;
            this.QUYCACH = QUYCACH;
            this.GIABAN = GIABAN;
            this.SOLUONGTON = SOLUONGTON;
            this.NUOCSX = NUOCSX;
            this.nhomsanpham = x;
        }
        public SANPHAM(SANPHAM x)
        {
            this.MASANPHAM = x.MASANPHAM;
            this.TENSANPHAM = x.TENSANPHAM;
            this.QUYCACH = x.QUYCACH;
            this.GIABAN = x.GIABAN;
            this.SOLUONGTON = x.SOLUONGTON;
            this.NUOCSX = NUOCSX;
            this.nhomsanpham = x.nhomsanpham;

        }
        
    }
}
