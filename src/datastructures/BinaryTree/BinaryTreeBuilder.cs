namespace AD
{
    //
    // This class offers static methods to create datastructures.
    // It is called by unit tests.
    //
    public partial class DSBuilder
    {
        public static IBinaryTree<int> CreateBinaryTreeEmpty()
        {
            BinaryTree<int> tree = new BinaryTree<int>();
            return tree;
        }

        //
        //         5
        //       /   \
        //     2       6
        //    / \
        //   8   7
        //      /
        //     1
        //
        public static IBinaryTree<int> CreateBinaryTreeInt()
        {
            BinaryTree<int> t1 = new(1);
            BinaryTree<int> t8 = new(8);
            BinaryTree<int> t6 = new(6);
            BinaryTree<int> t7 = new();
            BinaryTree<int> t2 = new();
            BinaryTree<int> t5 = new();
            
            t7.Merge(7, t1, null);
            t2.Merge(2, t8, t7);
            t5.Merge(5, t2, t6);

            return t5;
        }

        //
        //         t
        //       /   \
        //     w       a
        //    / \     / \
        //   q   g   o   p
        public static IBinaryTree<string> CreateBinaryTreeString()
        {
            BinaryTree<string> tq = new BinaryTree<string>("q");
            BinaryTree<string> tg = new BinaryTree<string>("g");
            BinaryTree<string> to = new BinaryTree<string>("o");
            BinaryTree<string> tp = new BinaryTree<string>("p");
            BinaryTree<string> tw = new BinaryTree<string>();
            BinaryTree<string> tt = new BinaryTree<string>();
            BinaryTree<string> ta = new BinaryTree<string>();

            tw.Merge("w", tq, tg);
            ta.Merge("a", to, tp);
            tt.Merge("t", tw, ta);

            return tt;
        }
    }
}