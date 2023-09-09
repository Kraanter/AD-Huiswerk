using System.Runtime.CompilerServices;

namespace AD
{
    public partial class MyQueue<T> : IMyQueue<T>
    {
        private MyLinkedList<T> list;
        
        public MyQueue()
        {
            list = new ();
        }
        
        public bool IsEmpty()
        {
            return list.Size() == 0;
        }

        public void Enqueue(T data)
        {
            list.AddLast(data);
        }

        public T GetFront()
        {
            if (IsEmpty())
                throw new MyQueueEmptyException();
            return list.GetFirst();
        }

        public T Dequeue()
        {
            if (IsEmpty())
                throw new MyQueueEmptyException();
            T data = list.GetFirst();
            list.RemoveFirst();
            return data;
        }

        public void Clear()
        {
            list.Clear();
        }
        
    }
}