using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace AD
{
    public partial class TestUtils
    {
        public static string TrimmedStringWithSingleSpaces(string s)
        {
            return Regex.Replace(s, @"\s+", " ").Trim();
        }
        public static string TrimmedStringWithoutSpaces(string s)
        {
            return Regex.Replace(s, @"\s+", "").Trim();
        }
        public static string ListToString<T>(IEnumerable<T> lst)
        {
            if (lst.Count() == 0)
                return "NIL";
            return "[" + string.Join(",", lst) + "]";
        }
        public static string ListToOrderedString<T>(IEnumerable<T> lst)
        {
            if (lst.Count() == 0)
                return "NIL";
            return "[" + string.Join(",", lst.OrderBy(x => x)) + "]";
        }
    }
}