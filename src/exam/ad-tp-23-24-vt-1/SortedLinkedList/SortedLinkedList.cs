namespace AD
{
    public partial class SortedLinkedList : ISortedLinkedList
    {
        public SortedLinkedListNode first;
        public SortedLinkedListNode firstSorted;

        public SortedLinkedList()
        {
            first = firstSorted = null;
        }

        public SortedLinkedListNode GetFirst()
        {
            return first;
        }

        public SortedLinkedListNode GetFirstSorted()
        {
            return firstSorted;
        }

        public void AddFirst(int value)
        {
            throw new System.NotImplementedException();
        }

        public override string ToString()
        {
            throw new System.NotImplementedException();
        }

        public string ToStringSorted()
        {
            throw new System.NotImplementedException();
        }

        public SortedLinkedListNode Find(int data)
        {
            throw new System.NotImplementedException();
        }
    }
}
