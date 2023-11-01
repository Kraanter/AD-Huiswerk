using NUnit.Framework;

namespace AD
{
    [TestFixture]
    public partial class SortedLinkedListTests
    {
        static SortedLinkedList GetList()
        {
            SortedLinkedList list = new SortedLinkedList();

            list.AddFirst(3);
            list.AddFirst(7);
            list.AddFirst(1);
            list.AddFirst(4);

            return list;
        }

        static string NodeText(SortedLinkedListNode node)
        {
            if (node == null)
                return "NULL";

            string text = node.data.ToString() + " (next=";
            if (node.next == null)
                text += "NULL";
            else
                text += node.next.data;
            text += ",nextSorted=";
            if (node.nextSorted == null)
                text += "NULL)";
            else
                text += node.nextSorted.data + ")";
            return text;
        }

        [Test]
        public void SortedLinkedList_1_ToString_1_Empty()
        {
            SortedLinkedList list = new SortedLinkedList();

            string actual = TestUtils.TrimmedStringWithoutSpaces(list.ToString());
            Assert.AreEqual("NULL", actual);
        }

        [Test]
        public void SortedLinkedList_1_ToString_2_NonEmpty()
        {
            SortedLinkedList list = GetList();

            string actual = TestUtils.TrimmedStringWithoutSpaces(list.ToString());
            Assert.AreEqual("4->1->7->3", actual);
        }

        [Test]
        public void SortedLinkedList_2_ToStringSorted_1_Empty()
        {
            SortedLinkedList list = new SortedLinkedList();

            string actual = TestUtils.TrimmedStringWithoutSpaces(list.ToStringSorted());
            Assert.AreEqual("[]", actual);
        }

        [Test]
        public void SortedLinkedList_2_ToStringSorted_2_NonEmpty()
        {
            SortedLinkedList list = GetList();

            string actual = TestUtils.TrimmedStringWithoutSpaces(list.ToStringSorted());
            Assert.AreEqual("[1,3,4,7]", actual);
        }

        [TestCase(-1, "NULL")]
        [TestCase(1, "1 (next=7,nextSorted=3)")]
        [TestCase(3, "3 (next=NULL,nextSorted=4)")]
        [TestCase(5, "NULL")]
        [TestCase(7, "7 (next=3,nextSorted=NULL)")]
        [TestCase(9, "NULL")]
        public void SortedLinkedList_3_Find(int value, string expected)
        {
            SortedLinkedList list = GetList();

            SortedLinkedListNode node = list.Find(value);
            string actual = NodeText(node);

            Assert.AreEqual(expected, actual);
        }
    }
}