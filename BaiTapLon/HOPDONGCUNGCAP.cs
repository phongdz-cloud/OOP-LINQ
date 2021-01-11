using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLon
{
    public class HOPDONGCUNGCAP
    {
        public string MAHD { get; set; }
        public NHACUNGCAP nhacungcap { get; set; }
        public HOPDONGCUNGCAP(string MAHD , NHACUNGCAP x)
        {
            this.MAHD = MAHD;
            this.nhacungcap = x;
        }
        public HOPDONGCUNGCAP(HOPDONGCUNGCAP x)
        {
            this.MAHD = x.MAHD;
            this.nhacungcap = x.nhacungcap;
        }

    }
}
