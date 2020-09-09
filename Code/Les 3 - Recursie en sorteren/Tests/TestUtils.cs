using System.Text.RegularExpressions;

namespace AD
{
    public partial class TestUtils
    {
        public string TrimmedStringWithSingleSpaces(string s)
        {
            return Regex.Replace(s, @"\s+", " ").Trim();
        }

    }
}
