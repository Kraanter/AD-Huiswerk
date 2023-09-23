using System;
using System.Collections.Generic;


namespace AD
{
    public partial class QuickSort : Sorter
    {
        private static int CUTOFF = 3;
        private static InsertionSort _insertionSort = new();

        public override void Sort(List<int> list)
        {
            Sort(list, 0, list.Count - 1);
        }

        private void Sort(List<int> list, int lo, int hi)
        {
            if (hi - lo <= CUTOFF)
            {
                _insertionSort.Sort(list, lo, hi);
                return;
            }
            
            int pivotIndex = GetPivotIndex(list, lo, hi);
            int pivotNumber = list[pivotIndex];
            // Swap the pivot with the end of the list
            Swap(list, new (pivotIndex, hi));

            int i = lo;
            int j = hi - 1;

            do
            {
                while (list[++i] < pivotNumber) ;
                while (list[--j] > pivotNumber) ;
                
                Swap(list, new(i, j));
                
            } while (i <= j);
            
            // Sort everything less than pivot
            Sort(list, lo, pivotIndex - 1);
            // Sort everything more than pivot
            Sort(list, pivotIndex + 1, hi);
        }

        private int GetPivotIndex(List<int> list, int lo, int hi)
        {
            int first = list[lo];
            int middle = list[lo + (hi - lo) / 2];
            int last = list[hi];

            if ((first > middle && first < last) || (first > last && first < middle))
                return lo;

            if ((middle > first && middle < last) || (middle > last && middle < first))
                return lo + (hi - lo) / 2;

            return hi;
        }

        private void Swap(List<int> list, Tuple<int, int> positions)
        {
            int val1 = list[positions.Item1];
            int val2 = list[positions.Item2];

            list[positions.Item1] = val2;
            list[positions.Item2] = val1;
        }
    }
}
