using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLon
{
    public static class ExtentionMethod
    {
        public static IEnumerable<TSource> DistinctBy<TSource, TKey>
            (this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
        {
            HashSet<TKey> seenKeys = new HashSet<TKey>();
            foreach (TSource element in source)
            {
                if (seenKeys.Add(keySelector(element)))
                {
                    yield return element;
                }
            }
        }
        public static string TachNgay(this string s)
        {
            string s1 = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != '/') s1 += s[i];
                else break;
            }
            return s1;
        }
        public static string TachThangNam(this string s)
        {
            string s1 = "";
            int count_s = 0;
            for(int i =0; i<s.Length;i++)
            {
                if(count_s!=1 && s[i]=='/')
                {
                    count_s++;
                }
                else if(count_s==1)
                {
                    s1 += s[i];
                }
            }
            return s1;
        }
        public static string TachThang(this string s)
        {
            string s1 = "";
            int count_s = 0;
            for (int i = 0; i < s.Length; i++)
            {

                if (count_s == 2) break;
                if (s[i] == '/')
                {
                    count_s++;
                }
                else if (count_s == 1)
                {
                    s1 += s[i];
                }
            }
            return s1;
        }
        public static string TachNam(this string s)
        {
            string s1 = "";
            int count_s = 0;
            for (int i = 0; i <s.Length; i++)
            {
                if (count_s == 2)
                {
                    s1 += s[i];
                }
                if (s[i]=='/' && count_s<2)
                {
                    count_s++;
                }
               
            }
            return s1;
        }
       
    }
}
