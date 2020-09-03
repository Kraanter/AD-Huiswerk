namespace AD
{
    //
    // This class offers static methods to create datastructures.
    // It is called by unit tests.
    //
    public partial class DSBuilder
    {
        public static IMyLinkedList<string> CreateMyLinkedList()
        {
            return new MyLinkedList<string>();
        }
    }
}
