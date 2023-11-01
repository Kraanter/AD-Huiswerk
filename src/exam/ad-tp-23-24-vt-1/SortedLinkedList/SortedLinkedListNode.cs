namespace AD
{
    public partial class SortedLinkedListNode
    {
        public int data;
        public SortedLinkedListNode next;
        public SortedLinkedListNode nextSorted;

        public SortedLinkedListNode(int d)
        {
            data = d;
            next = nextSorted = null;
        }

        public int GetData()
        {
            return data;
        }
        public SortedLinkedListNode GetNext()
        {
            return next;
        }
        public SortedLinkedListNode GetNextSorted()
        {
            return nextSorted;
        }
    }
}
