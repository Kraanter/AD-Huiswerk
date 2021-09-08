namespace AD
{
    public partial interface IFCNSNode<T>
    {
        T GetData();
        FCNSNode<T> GetFirstChild();
        FCNSNode<T> GetNextSibling();
    }
}