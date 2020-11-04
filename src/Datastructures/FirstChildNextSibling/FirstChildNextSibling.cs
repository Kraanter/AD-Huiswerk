namespace AD
{
    public partial class FirstChildNextSibling<T> : IFirstChildNextSibling<T>
    {
        public FCNSNode<T> root;

        public IFCNSNode<T> GetRoot()
        {
            return root;
        }

        public int Size()
        {
               throw new System.NotImplementedException();
        }

        public void PrintPreOrder()
        {
            throw new System.NotImplementedException();
        }

    }
}