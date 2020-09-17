namespace AD
{
    public class BinaryNode<T>
    {
        public T data;
        public BinaryNode<T> left;
        public BinaryNode<T> right;

        public BinaryNode() : this(default(T), default(BinaryNode<T>), default(BinaryNode<T>)) { }

        public BinaryNode(T data, BinaryNode<T> left, BinaryNode<T> right)
        {
            this.data = data;
            this.left = left;
            this.right = right;
        }
    }
}