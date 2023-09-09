namespace AD
{
    public partial class MyStack<T> : IMyStack<T>
    {
        public MyLinkedList<T> list = new MyLinkedList<T>();
        public bool IsEmpty()
        {
            return list.Size() == 0;
        }

        public T Pop()
        {
            if (IsEmpty())
                throw new MyStackEmptyException();
            
            var data = list.GetFirst();
            list.RemoveFirst();
            return data;
        }

        public void Push(T data)
        {
            list.AddFirst(data);
        }

        public T Top()
        {
            if (IsEmpty())
                throw new MyStackEmptyException();
            
            return list.GetFirst();
        }
    }
}
