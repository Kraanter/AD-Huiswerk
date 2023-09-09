namespace AD
{
    public partial class MyArrayList : IMyArrayList
    {
        private int[] data;
        private int size;

        public MyArrayList(int capacity)
        {
            if (capacity < 0)
                throw new MyArrayListIndexOutOfRangeException();
            
            data = new int[capacity];
            size = 0;
        }

        public void Add(int n)
        {
            if (data.Length == size)
                throw new MyArrayListFullException();

            data[size] = n;
            size++;
        }

        public int Get(int index)
        {
            if (index < 0 || size - 1 < index)
                throw new MyArrayListIndexOutOfRangeException();

            return data[index];
        }

        public void Set(int index, int n)
        {
            if (index < 0 || size - 1 < index)
                throw new MyArrayListIndexOutOfRangeException();

            data[index] = n;
        }

        public int Capacity()
        {
            return data.Length;
        }

        public int Size()
        {
            return size;
        }

        public void Clear()
        {
            data = new int[data.Length];
            size = 0;
        }

        public int CountOccurences(int n)
        {
            int count = 0;
            for (int i = 0; i < size; i++)
            {
                if (data[i] == n)
                    count++;
            }
            return count;
        }

        public override string ToString()
        {
            if (size == 0)
                return "NIL";
            
            string dataString = "";
            for (int i = 0; i < size - 1; i++)
            {
                dataString += data[i] + ",";
            }

            dataString += data[size - 1];
            return $"[{dataString}]";
        }
    }
}
