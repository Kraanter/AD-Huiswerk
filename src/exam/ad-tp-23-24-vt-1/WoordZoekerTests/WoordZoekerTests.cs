using NUnit.Framework;

namespace AD
{
    [TestFixture]
    public partial class WoordZoekerTests
    {
        static char[,] GetGrid()
        {
            char[,] array = {
                {'A', 'A', 'A', 'N', 'D' },
                {'B', 'C', 'A', 'A', 'A' },
                {'C', 'E', 'H', 'A', 'C' },
                {'D', 'F', 'G', 'T', 'H' },
                {'E', 'F', 'E', 'C', 'X' },
            };
            return array;
        }

        [TestCase("AANDACHT", 0, 1, true)]
        [TestCase("AANDACHT", 1, 4, true)]
        [TestCase("AANDACHT", 2, 3, true)]
        [TestCase("AANDACHT", 0, 0, false)]
        [TestCase("EFFECT", 2, 1, true)]
        public void WoordZoekerTest(string woord, int row, int col, bool expected)
        {
            char[,] grid = GetGrid();

            bool actual = WoordZoeker.WoordBestaat(woord, grid, row, col);

            Assert.AreEqual(expected, actual);
        }

        [TestCase("AANDACHT", 0, 1, true)]
        [TestCase("AANDACHT", 1, 4, false)]
        [TestCase("AANDACHT", 2, 3, true)]
        [TestCase("AANDACHT", 0, 0, false)]
        [TestCase("EFFECT", 2, 1, true)]
        public void WoordZoekerUniekTest(string woord, int row, int col, bool expected)
        {
            char[,] grid = GetGrid();

            bool actual = WoordZoeker.WoordBestaatUniek(woord, grid, row, col);

            Assert.AreEqual(expected, actual);
        }
    }
}