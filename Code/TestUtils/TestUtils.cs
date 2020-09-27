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
	}
}