using System.Collections.Generic;

namespace AD
{
    class Program
    {
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
                text += "NULL,";  // <-- de versie volgens de output op tentamenblad
                //text += "NULL)";  // <-- een betere versie ;)
            else
                text += node.nextSorted.data + ")";
            return text;
        }

        static void Main(string[] args)
        {
            int[] values = { 3, 7, 1, 4 };

            System.Console.WriteLine("=== AddFirst / ToString / ToStringSorted ===");
            SortedLinkedList list = new SortedLinkedList();
            System.Console.WriteLine("ToString()       : {0}", list.ToString());
            System.Console.WriteLine("ToStringSorted() : {0}", list.ToStringSorted());

            foreach (int value in values)
            {
                list.AddFirst(value);
                System.Console.WriteLine($"AddFirst({value});");
            }
            System.Console.WriteLine("ToString()       : {0}", list.ToString());
            System.Console.WriteLine("ToStringSorted() : {0}", list.ToStringSorted());

            // System.Console.WriteLine();
            System.Console.WriteLine("=== Find ===");
            for (int value = -1; value < 10; value += 2)
            {
                SortedLinkedListNode node = list.Find(value);
                System.Console.WriteLine($"Find({value,2}) = {NodeText(node)}");
            }
        }
    }
}
