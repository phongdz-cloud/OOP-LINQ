using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLon
{
    public class NHOMSANPHAM
    {
        public string MANHOMSP { get; set; }
        public string TENNHOMSP { get; set; }
        public NHOMSANPHAM(string MANHOMSP, string TENNHOMSP)
        {
            this.MANHOMSP = MANHOMSP;
            this.TENNHOMSP = TENNHOMSP;
        }
        public NHOMSANPHAM(NHOMSANPHAM x)
        {
            this.MANHOMSP = x.MANHOMSP;
            this.TENNHOMSP = x.TENNHOMSP;
        }
    }
}
