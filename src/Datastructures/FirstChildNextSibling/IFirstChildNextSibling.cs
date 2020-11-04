namespace AD
{
    public partial interface IFirstChildNextSibling<T>
    {
        IFCNSNode<T> GetRoot();
        int Size();
        void PrintPreOrder();
    }
}
