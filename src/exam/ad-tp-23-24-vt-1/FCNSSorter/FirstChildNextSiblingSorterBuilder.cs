namespace AD
{
    public partial class DSBuilder
    {
        public static IFirstChildNextSibling<int> CreateFCNSSorterIntTree()
        {
            FirstChildNextSibling<int> tree = new FirstChildNextSibling<int>();
            tree.root = new FirstChildNextSiblingNode<int>(System.Int32.MaxValue);

            tree.root.firstChild = new FirstChildNextSiblingNode<int>(7);
            tree.root.firstChild.nextSibling = new FirstChildNextSiblingNode<int>(13);
            tree.root.firstChild.nextSibling.nextSibling = new FirstChildNextSiblingNode<int>(24);
            tree.root.firstChild.nextSibling.nextSibling.nextSibling = new FirstChildNextSiblingNode<int>(24);
            tree.root.firstChild.nextSibling.nextSibling.nextSibling.nextSibling = new FirstChildNextSiblingNode<int>(31);
            tree.root.firstChild.nextSibling.nextSibling.nextSibling.nextSibling.nextSibling = new FirstChildNextSiblingNode<int>(42);

            tree.root.firstChild.nextSibling.firstChild = new FirstChildNextSiblingNode<int>(10);
            tree.root.firstChild.nextSibling.firstChild.nextSibling = new FirstChildNextSiblingNode<int>(12);

            tree.root.firstChild.nextSibling.nextSibling.nextSibling.nextSibling.firstChild = new FirstChildNextSiblingNode<int>(24);
            tree.root.firstChild.nextSibling.nextSibling.nextSibling.nextSibling.firstChild.nextSibling = new FirstChildNextSiblingNode<int>(26);
            tree.root.firstChild.nextSibling.nextSibling.nextSibling.nextSibling.firstChild.nextSibling.firstChild = new FirstChildNextSiblingNode<int>(24);

            return tree;
        }
    }
}
