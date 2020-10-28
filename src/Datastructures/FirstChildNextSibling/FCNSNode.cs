namespace AD
{
    public partial class FCNSNode<T> : IFCNSNode<T>
    {
        public FCNSNode<T> firstChild;
        public FCNSNode<T> nextSibling;
        public T data;

        public FCNSNode(T data, FCNSNode<T> firstChild, FCNSNode<T> nextSibling)
        {
            throw new System.NotImplementedException();
        }

        public FCNSNode(T data)
        {
            throw new System.NotImplementedException();
        }

        public T GetData()
        {
            throw new System.NotImplementedException();
        }

        public FCNSNode<T> GetFirstChild()
        {
            throw new System.NotImplementedException();
        }

        public FCNSNode<T> GetNextSibling()
        {
            throw new System.NotImplementedException();
        }
    }
}