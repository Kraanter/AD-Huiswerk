using NUnit.Framework;
using System.Collections.Generic;
using System;

namespace AD
{
    [TestFixture]
    public partial class FCNSSorterTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void FCNSSorter_Test_FOUT()
        {
            int[] nums = { 5, 3, 4, 2 };
            string expected = "2 3 4 5";

            FirstChildNextSiblingSorter sorter = new FirstChildNextSiblingSorter();
            List<int> nums_list = new List<int>(nums);
            sorter.Sorteer(ref nums_list);

            Assert.AreEqual(expected, String.Join(" ", nums_list));
        }
        
        [Test]
        public void FCNSSorter_Test()
        {
            int[] nums = { 7, 13, 24, 24, 31, 10, 12, 24, 42, 26, 24 };
            string expected = "7 10 12 13 24 24 24 24 26 31 42";

            FirstChildNextSiblingSorter sorter = new FirstChildNextSiblingSorter();
            List<int> nums_list = new List<int>(nums);
            sorter.Sorteer(ref nums_list);

            Assert.AreEqual(expected, String.Join(" ", nums_list));
        }
    }
}
