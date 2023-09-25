namespace AD
{
    public partial class BinaryTree<T> : IBinaryTree<T>
    {
        public BinaryNode<T> root;

        //----------------------------------------------------------------------
        // Constructors
        //----------------------------------------------------------------------

        public BinaryTree()
        {
            root = null;
        }

        public BinaryTree(T rootItem)
        {
            root = new BinaryNode<T>(rootItem, null, null);
        }


        //----------------------------------------------------------------------
        // Interface methods that have to be implemented for exam
        //----------------------------------------------------------------------

        public BinaryNode<T> GetRoot()
        {
            return root;
        }

        public int Size()
        {
            if (root is null)
                return 0;
            
            return 1 + root.Size();
        }

        public int Height()
        {
            return root?.Height() ?? -1;
        }

        public void MakeEmpty()
        {
            root = null;
        }

        public bool IsEmpty()
        {
            return root is null;
        }

        public void Merge(T rootItem, BinaryTree<T> t1, BinaryTree<T> t2)
        {
            root = new BinaryNode<T>(rootItem, t1?.GetRoot(), t2?.GetRoot());
        }

        public string ToPrefixString()
        {
            return root?.ToPrefixString() ?? "NIL";
        }

        public string ToInfixString()
        {
            return root?.ToInfixString() ?? "NIL";
        }

        public string ToPostfixString()
        {
            return root?.ToPostfixString() ?? "NIL";
        }


        //----------------------------------------------------------------------
        // Interface methods : methods that have to be implemented for homework
        //----------------------------------------------------------------------

        public int NumberOfLeaves()
        {
            return root?.NumberOfLeaves() ?? 0;
        }

        public int NumberOfNodesWithOneChild()
        {
            return root?.NumberOfNodesWithOneChild() ?? 0;
        }

        public int NumberOfNodesWithTwoChildren()
        {
            return root?.NumberOfNodesWithTwoChildren() ?? 0;
        }
    }
}