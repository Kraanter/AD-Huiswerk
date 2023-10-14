using System;


namespace AD
{
    public partial class PriorityQueue<T> : IPriorityQueue<T>
        where T : IComparable<T>
    {
        public static int DEFAULT_CAPACITY = 100;
        public int size;   // Number of elements in heap
        public T[] array;  // The heap array

        //----------------------------------------------------------------------
        // Constructor
        //----------------------------------------------------------------------
        public PriorityQueue()
        {
            array = new T[DEFAULT_CAPACITY + 1];
            size = 0;
        }

        //----------------------------------------------------------------------
        // Interface methods that have to be implemented for exam
        //----------------------------------------------------------------------
        public int Size()
        {
            return size;
        }

        public void Clear()
        {
            array = new T[DEFAULT_CAPACITY + 1];
            size = 0;
        }

        public void Add(T x)
        {
            if (array.Length == ++size)
            {
                T[] newArray = new T[size * 2];
                Array.Copy(array, newArray, size);
                array = newArray;
            }
                
            array[size] = x;
            PercolateUp(size);
        }

        private void PercolateUp(int index)
        {
            if (index < 2)
                return;
            
            if (array[index / 2].CompareTo(array[index]) > 0)
            {
                Swap(index, index/2);
                PercolateUp(index/2);
            }
        }

        private void PercolateDown(int index)
        {
            int lowestNrIndex = index;
        
            if (index * 2 <= size)
                if (array[index * 2].CompareTo(array[lowestNrIndex]) < 0)
                    lowestNrIndex = index * 2;
            
            if (index * 2 + 1 <= size)
                if (array[index * 2 + 1].CompareTo(array[lowestNrIndex]) < 0)
                    lowestNrIndex = index * 2 + 1;

            if (lowestNrIndex == index)
                return;
            
            Swap(index, lowestNrIndex);
            PercolateDown(lowestNrIndex);
        }

        private void Swap(int index1, int index2)
        {
            if (index1 < 1 || index2 < 1)
                return;
            (array[index1], array[index2]) = (array[index2], array[index1]);
        }

        // Removes the smallest item in the priority queue
        public T Remove()
        {
            if (size < 1)
                throw new PriorityQueueEmptyException();

            T returnItem = array[1];
            array[1] = array[size];
            array[size--] = default(T);
            
            PercolateDown(1);
            
            return returnItem;
        }


        //----------------------------------------------------------------------
        // Interface methods that have to be implemented for homework
        //----------------------------------------------------------------------

        public void AddFreely(T x)
        {
            array[++size] = x;
        }

        public void BuildHeap()
        {
            for (int i = size/2; i >= 1; i--)
            {
                PercolateDown(i);
            }
        }

        public override string ToString()
        {
            if (size < 1)
                return "";
            
            string retString = array[1].ToString();

            for (int i = 2; i <= size; i++)
            {
                retString += " " + array[i].ToString();
            }

            return retString;
        }
    }
}
