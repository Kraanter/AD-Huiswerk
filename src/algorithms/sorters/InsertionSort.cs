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
            for (int n = 0; n < hi + 1; n++)
            {
                int i = n;
                int sortNum = list[n];
                while (i > 0 && sortNum < list[i - 1])
                {
                    list[i] = list[i - 1];
                    i--;
                }

                list[i] = sortNum;
            }
        }
    }
}
