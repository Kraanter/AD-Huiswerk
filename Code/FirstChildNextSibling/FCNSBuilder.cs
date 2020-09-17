namespace AD
{
    //
    // This class offers static methods to create datastructures.
    // It is called by unit tests.
    //
    public partial class DSBuilder
    {
        public static IFirstChildNextSibling<string> CreateFirstChildNextSibling_Empty ()
        {
            FirstChildNextSibling<string> tree = new FirstChildNextSibling<string> ();
            return tree;
        }

        public static IFirstChildNextSibling<string> CreateFirstChildNextSibling_Small ()
        {
            FirstChildNextSibling<string> tree = new FirstChildNextSibling<string> ();

            FCNSNode<string> d = new FCNSNode<string> ("d");
            FCNSNode<string> c = new FCNSNode<string> ("c");
            FCNSNode<string> b = new FCNSNode<string> ("b", d, c);
            FCNSNode<string> a = new FCNSNode<string> ("a", b, null);

            tree.root = a;

            return tree;
        }

        public static IFirstChildNextSibling<string> CreateFirstChildNextSibling_18_3 ()
        {
            throw new System.NotImplementedException();
        }
    }
}