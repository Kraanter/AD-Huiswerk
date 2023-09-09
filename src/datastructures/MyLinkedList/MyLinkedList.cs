using System.Diagnostics.CodeAnalysis;

namespace AD
{
    public partial class MyLinkedList<T> : IMyLinkedList<T>
    {
        public MyLinkedListNode<T> first;
        public MyLinkedListNode<T> last;
        private int size;

        public MyLinkedList()
        {
            size = 0;
        }

        public void AddFirst(T data)
        {
            MyLinkedListNode<T> nodeToAdd = new()
            {
                data = data,
                next = first
            };
            first = nodeToAdd;
            if (size == 0)
                last = nodeToAdd;
            size++;
        }

        public void AddLast(T data)
        {
            MyLinkedListNode<T> nodeToAdd = new()
            {
                data = data,
            };
            if (size != 0)
                last.next = nodeToAdd;
            else
                first = nodeToAdd;
            last = nodeToAdd;
            size++;
        }

        public T GetFirst()
        {
            if (size == 0)
                throw new MyLinkedListEmptyException();
            
            return first.data;
        }

        public T GetLast()
        {
            if (size == 0)
                throw new MyLinkedListEmptyException();

            return last.data;
        }

        public void RemoveFirst()
        {
            if (size == 0)
                throw new MyLinkedListEmptyException();
            if (first.next != null)
            {
                first = first.next;
                size--;
            } 
            else
            {
                first = null;
                size = 0;
            }
        }

        public int Size()
        {
            return size;
        }

        public void Clear()
        {
            while (first != null)
            {
                first = first.next;
            }

            size = 0;
        }

        public void Insert(int index, T data)
        {
            if (index < 0 || size < index)
                throw new MyLinkedListIndexOutOfRangeException();

            if (index == 0)
            {
                AddFirst(data);
                return;
            }

            var node = first;
            for (int i = 0; i < index - 1; i++)
                node = node.next;
            
            MyLinkedListNode<T> insert = new()
            {
                data = data,
                next = node.next
            };
            node.next = insert;
            size++;
        }

        public override string ToString()
        {
            if (size == 0)
                return "NIL";

            string dataString = "";
            var node = first;
            while (node.next != null)
            {
                dataString += node.data + ",";
                node = node.next;
            }

            dataString += node.data;
            return $"[{dataString}]";
        }
    }
}