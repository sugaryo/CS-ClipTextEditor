using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClipTextEditor
{
    public static class _extensions
    {
        public static string[] lines(this string s)
        {
            return s.Split(new[] { "\r\n" }, StringSplitOptions.None);
        }

        public static IEnumerable<string> sequential(this IEnumerable<string> itor, string by = "\t")
        {
            foreach (var s in itor)
            {
                var token = s.Split(new[] { by }, StringSplitOptions.None);
                foreach (var t in token)
                {
                    yield return t;
                }
            }
        }

        public static IEnumerable<string> distinct(this IEnumerable<string> itor)
        {
            HashSet<string> hashset = new HashSet<string>();
            foreach (var s in itor)
            {
                if (hashset.Add(s))
                {
                    yield return s;
                }
            }
        }
    }
}
