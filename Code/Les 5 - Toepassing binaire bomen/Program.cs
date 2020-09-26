namespace Huiswerk5
{
    class Program
    {

        static void Opgave1()
        {
            BinarySearchTree<int> bst;

            bst = new BinarySearchTree<int>();
            bst.Insert(3);
            bst.Insert(1);
            bst.Insert(4);
            bst.Insert(6);
            bst.Insert(9);
            bst.Insert(2);
            bst.Insert(5);
            bst.Insert(7);
            System.Console.WriteLine(bst.ToInfixString());
            System.Console.WriteLine(bst);
            bst.Remove(6);

            System.Console.WriteLine();

            bst = new BinarySearchTree<int>();
            System.Console.WriteLine(bst);
            bst.Insert(6);
            System.Console.WriteLine(bst.ToInfixString());
            bst.Insert(4);
            bst.Insert(7);
            bst.Insert(2);
            bst.Insert(5);
            System.Console.WriteLine(bst.ToInfixString());
            System.Console.WriteLine(bst);
        }
        static void Opgave2()
        {
            PriorityQueue<int> pq = new PriorityQueue<int>();

            // 4, 19, 3, 5, 12, 9, 2
            pq.Add(4);
            pq.Add(19);
            pq.Add(3);
            pq.Add(5);
            pq.Add(12);
            pq.Add(9);
            pq.Add(2);
            System.Console.WriteLine(pq);
            pq.Remove();
            System.Console.WriteLine(pq);  //3 5 4 19 12 9

            IPriorityQueue<int> q = DSBuilder.CreatePriorityQueueFull();
            q.Add(5);

        }

        static void Main(string[] args)
        {
            Opgave1();
            Opgave2();
        }
    }
}
