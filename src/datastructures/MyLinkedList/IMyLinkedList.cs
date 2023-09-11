namespace AD
{
    public partial interface IMyLinkedList<T>
    {
        // Add an item to the start of the list
        void AddFirst(T data);
        
        // Add an item to the end of the list
        void AddLast(T data);

        // Returns the first item of the list
        T GetFirst();

        // Returns the last item of the list
        T GetLast();

        // Remove the first item of the list
        void RemoveFirst();

        // Obtain the size of the list
        int Size();

        // Clear the list
        void Clear();

        // Insert an item on a specific index (insert, not overwrite!)
        // It is possible to insert data directly at end of list
        void Insert(int index, T data);
    }

    public class MyLinkedListEmptyException : System.Exception
    {
    }

    public class MyLinkedListIndexOutOfRangeException : System.Exception
    {
    }
}
