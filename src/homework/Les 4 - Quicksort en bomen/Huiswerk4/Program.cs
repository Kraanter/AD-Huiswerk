namespace AD
{
    class Program
    {
        static void Opgave1()
        {
            System.Console.WriteLine("\n=====   Opgave 1 : QuickSort   =====\n");
            Sorter isort = new InsertionSort();
            Sorter msort = new MergeSort();
            Sorter ssort = new ShellSort();
            Sorter qsort = new QuickSort();
            isort.Run();
            msort.Run();
            ssort.Run();
            qsort.Run();
            int[] numbers = { 100, 1000, 10000 };
            foreach (int num in numbers)
            {
                isort.RunWithTimer(num);
                msort.RunWithTimer(num);
                ssort.RunWithTimer(num);
                qsort.RunWithTimer(num);
            }
        }

        static void Opgave2()
        {
            System.Console.WriteLine("\n=====   Opgave 2 : FirstChildNextSibling   =====\n");

            IFirstChildNextSibling<string> tree;

            // Empty tree
            tree = DSBuilder.CreateFirstChildNextSibling_Empty();
            tree.PrintPreOrder();
            System.Console.WriteLine("Size: {0}", tree.Size());
            System.Console.WriteLine(tree);

            // Small tree
            tree = DSBuilder.CreateFirstChildNextSibling_Small();
            tree.PrintPreOrder();
            System.Console.WriteLine("Size: {0}", tree.Size());
            System.Console.WriteLine(tree);

            // Tree from figure 18.3
            tree = DSBuilder.CreateFirstChildNextSibling_18_3();
            tree.PrintPreOrder();
            System.Console.WriteLine("Size: {0}", tree.Size());
            System.Console.WriteLine(tree);
        }

        static void Opgave3()
        {
            System.Console.WriteLine("\n=====   Opgave 3 : BinaryTree   =====\n");

            IBinaryTree<int> intTree;
            IBinaryTree<string> stringTree;

            // Empty tree
            intTree = DSBuilder.CreateBinaryTreeEmpty();
            System.Console.WriteLine(intTree.Size());
            System.Console.WriteLine(intTree.Height());
            System.Console.WriteLine(intTree.ToPrefixString());
            System.Console.WriteLine(intTree.ToInfixString());
            System.Console.WriteLine(intTree.ToPostfixString());

            // Int tree
            intTree = DSBuilder.CreateBinaryTreeInt();
            System.Console.WriteLine(intTree.Size());
            System.Console.WriteLine(intTree.Height());
            System.Console.WriteLine(intTree.ToPrefixString());
            System.Console.WriteLine(intTree.ToInfixString());
            System.Console.WriteLine(intTree.ToPostfixString());
            System.Console.WriteLine(intTree.NumberOfNodesWithOneChild());

            // String tree
            stringTree = DSBuilder.CreateBinaryTreeString();
            System.Console.WriteLine(stringTree.Size());
            System.Console.WriteLine(stringTree.Height());
            System.Console.WriteLine(stringTree.ToPrefixString());
            System.Console.WriteLine(stringTree.ToInfixString());
            System.Console.WriteLine(stringTree.ToPostfixString());
        }

        static void Opgave4()
        {
            System.Console.WriteLine("\n=====   Opgave 4 : NumberOfNodes   =====\n");

            IBinaryTree<int> intTree;
            IBinaryTree<string> stringTree;

            // Empty tree
            intTree = DSBuilder.CreateBinaryTreeEmpty();
            System.Console.WriteLine(intTree.NumberOfLeaves());
            System.Console.WriteLine(intTree.NumberOfNodesWithOneChild());
            System.Console.WriteLine(intTree.NumberOfNodesWithTwoChildren());

            // Int tree
            intTree = DSBuilder.CreateBinaryTreeInt();
            System.Console.WriteLine(intTree.NumberOfLeaves());
            System.Console.WriteLine(intTree.NumberOfNodesWithOneChild());
            System.Console.WriteLine(intTree.NumberOfNodesWithTwoChildren());

            // String tree
            stringTree = DSBuilder.CreateBinaryTreeString();
            System.Console.WriteLine(stringTree.NumberOfLeaves());
            System.Console.WriteLine(stringTree.NumberOfNodesWithOneChild());
            System.Console.WriteLine(stringTree.NumberOfNodesWithTwoChildren());
        }

        static void Main(string[] args)
        {
            Opgave1();
            Opgave2();
            Opgave3();
            Opgave4();
        }
    }
}
