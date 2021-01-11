using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLon
{
    public class NHACUNGCAP
    {
        public string MANCC { get; set; }
        public string TENNCC { get; set; }
        public string DIACHI { get; set; }
        public string DIENTHOAI { get; set; }
        public string EMAIL { get; set; }
        public NHACUNGCAP(string MANCC,string TENNCC,string DIACHI, string DIENTHOAI, string EMAIL)
        {
            this.MANCC = MANCC;
            this.TENNCC = TENNCC;
            this.DIACHI = DIACHI;
            this.DIENTHOAI = DIENTHOAI;
            this.EMAIL = EMAIL;
        }
        public NHACUNGCAP(NHACUNGCAP x)
        {
            this.MANCC = x.MANCC;
            this.TENNCC = x.TENNCC;
            this.DIACHI = x.DIACHI;
            this.DIENTHOAI = x.DIENTHOAI;
            this.EMAIL = x.EMAIL;
        }
    }
}
