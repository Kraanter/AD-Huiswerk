using System.Text.RegularExpressions;

namespace AD
{
    public class TestUtils
    {
        public static string TrimmedStringWithSingleSpaces(string s)
        {
            return Regex.Replace(s, @"\s+", " ").Trim();
        }

    }
}
