using System.Collections.Generic;


namespace AD
{
    public partial class InsertionSort : Sorter
    {
        public override void Sort(List<int> list)
        {
            Sort(list, 0, list.Count - 1);
        }

        public void Sort(List<int> list, int lo, int hi)
        {
            if (lo > hi)
                return;
            
            int i = lo;
            int sortNum = list[i];
            while (i > 0 && sortNum < list[i - 1])
            {
                list[i] = list[i - 1];
                i--;
            }

            list[i] = sortNum;
            Sort(list, lo + 1, hi);
        }
    }
}
