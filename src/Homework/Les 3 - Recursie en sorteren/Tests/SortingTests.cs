using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace AD
{
    [TestFixture]
    public partial class SortingTests
    {
        [Test, Combinatorial]
        public void Sort(
                    [Values("InsertionSort", "MergeSort", "ShellSort")] string sorterName,
                    [Values(0, 1, 2, 10, 3000)] int n)
        {
            List<int> list = new List<int>();
            List<int> listCopy;
            Sorter sorter;
            System.Random random = new System.Random();

            // Arrange
            sorter = DSBuilder.CreateSorter(sorterName);
            Assert.IsNotNull(sorter != null);

            // Arrange
            for (int i = 0; i < n; i++)
                list.Add(random.Next(0, 100000));
            listCopy = new List<int>(list);
            listCopy.Sort();

            // Act
            sorter.Sort(list);

            // Assert
            bool equal = list.SequenceEqual(listCopy);
            Assert.IsTrue(equal);
        }
    }
}