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
            SortedLinkedListNode previous = null;
            var searchNode = firstSorted;
            while (value > searchNode?.GetData())
            {
                previous = searchNode; // 3
                searchNode = searchNode.nextSorted; // 7
            }
            
            SortedLinkedListNode nodeToAdd = new(value);
            nodeToAdd.next = first;
            first = nodeToAdd;

            nodeToAdd.nextSorted = searchNode;
            
            if (previous is not null)
                previous.nextSorted = nodeToAdd;
            else
                firstSorted = nodeToAdd;
        }

        public override string ToString()
        {
            if (first is null)
                return "NULL";

            string dataString = "";
            var node = first;
            while (node.next != null)
            {
                dataString += node.data + " -> ";
                node = node.next;
            }

            dataString += node.data;
            return dataString;
        }

        public string ToStringSorted()
        {
            if (firstSorted is null)
                return "[]";

            string dataString = "";
            var node = firstSorted;
            while (node.nextSorted != null)
            {
                dataString += node.data + ",";
                node = node.nextSorted;
            }

            dataString += node.data;
            return $"[{dataString}]";
        }

        public SortedLinkedListNode Find(int data)
        {
            var node = firstSorted;

            while (node is not null && node.GetData() < data)
                node = node.GetNextSorted();
                
            return data == node?.GetData() ? node : null;
        }
    }
}
