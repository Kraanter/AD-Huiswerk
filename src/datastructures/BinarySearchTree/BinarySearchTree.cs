namespace AD
{
    public partial class BinarySearchTree<T> : BinaryTree<T>, IBinarySearchTree<T>
        where T : System.IComparable<T>
    {

        //----------------------------------------------------------------------
        // Interface methods that have to be implemented for exam
        //----------------------------------------------------------------------

        public void Insert(T x)
        {
            root ??= new BinaryNode<T>(x, null, null);

            InsertInto(x, root);
        }

        private void InsertInto(T x, BinaryNode<T> node)
        {
            if (x.Equals(node.data) || node is null)
                return;
            
            if (x.CompareTo(node.data) < 0)
                if (node.left is not null)
                    InsertInto(x, node.left);
                else
                    node.left = new BinaryNode<T>(x, null, null);
            else
                if (node.right is not null)
                    InsertInto(x, node.right);
                else
                    node.right = new BinaryNode<T>(x, null, null);
        }

        public T FindMin()
        {
            var node = root ?? throw new BinarySearchTreeEmptyException();

            while (node.left is not null)
                node = node.left;

            return node.data;
        }

        public void RemoveMin()
        {
            var node = root ?? throw new BinarySearchTreeEmptyException();
            BinaryNode<T> parent = null;

            while (node.left is not null)
            {
                parent = node;
                node = node.left;
            }

            if (parent is null)
                root = null;
            else
            {
                parent.left = node.right;
            }
        }

        public void Remove(T x)
        {
            var node = root ?? throw new BinarySearchTreeElementNotFoundException();
            BinaryNode<T> parent = null;
            bool removeLeft = false;

            while (!x.Equals(node.data))
            {
                parent = node;
                if (x.CompareTo(node.data) < 0)
                {
                    // Left
                    node = node.left;
                    removeLeft = true;
                }
                else
                {
                    // Right
                    node = node.right;
                    removeLeft = false;
                }

                if (node is null)
                    throw new BinarySearchTreeElementNotFoundException();
            }

            // Zero or one node are null
            if (node.left is null || node.right is null)
            {
                if (parent is null)
                    root = removeLeft ? node.right : node.left;

                if (removeLeft)
                    parent.left = node.left ?? node.right;
                else
                    parent.right = node.left ?? node.right;
            }
            // Both nodes are filled
            else
            {
                var replacementNode = node.right;
                BinaryNode<T> replacementNodeParent = null;

                while (replacementNode.left is not null)
                {
                    replacementNodeParent = replacementNode;
                    replacementNode = replacementNode.left;
                }

                node.data = replacementNode.data;
                if (replacementNodeParent is null)
                    node.right = replacementNode.right;
                else
                    replacementNodeParent.left = replacementNode.right;
            }
        }

        public string InOrder()
        {
            return InOrder(root);
        }

        private string InOrder(BinaryNode<T> node)
        {
            if (node is null)
                return "";

            string left = InOrder(node.left);
            string middle = node.data.ToString();
            string right = InOrder(node.right);

            if (left != "")
                middle = " " + middle;
            if (right != "")
                middle = middle + " ";

            return left + middle + right;
        }

        public override string ToString()
        {
            return InOrder();
        }
    }
}
