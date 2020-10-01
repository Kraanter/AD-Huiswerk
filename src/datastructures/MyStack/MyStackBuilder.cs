namespace AD
{
    //
    // This class offers static methods to create datastructures.
    // It is called by unit tests.
    //
    public partial class DSBuilder
    {
        public static IMyStack<string> CreateMyStack()
        {
            return new MyStack<string>();
        }
    }
}
