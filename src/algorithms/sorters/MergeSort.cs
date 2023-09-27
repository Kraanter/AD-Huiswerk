using System;
using System.Collections.Generic;
using System.Diagnostics;


namespace AD
{
    public partial class MergeSort : Sorter
    {
        public override void Sort(List<int> list)
        {
            Sort(list, 0, list.Count - 1);
        }

        private void Sort(List<int> list, int lo, int hi)
        {
            if (lo >= hi)
                return;

            int min1 = lo;
            int max1 = lo + (hi - lo) / 2;

            int min2 = max1 + 1;
            int max2 = hi;

            Sort(list, min1, max1);
            Sort(list, min2, max2);

            Merge(list, min1, max1, min2, max2);
        }

        private void Merge(List<int> list, int lo1, int hi1, int lo2, int hi2)
        {
            int curIndex1 = lo1;
            int curIndex2 = lo2;

            // This should not be needed for speed it is skipped :)
            // int listStartIndex = Math.Min(curIndex1, curIndex2);
            int listStartIndex = curIndex1;

            // Make sure to copy the list because we need to get the values from the original list
            var listCopy = new List<int>(list);
            // var listCopy = list;
            
            int curNumber1 = list[curIndex1];
            int curNumber2 = list[curIndex2];
            
            while (curIndex1 <= hi1 || curIndex2 <= hi2)
            {
                int itemToPlace;
                if (curNumber1 < curNumber2)
                {
                    itemToPlace = curNumber1;
                    if (++curIndex1 > hi1)
                        curNumber1 = int.MaxValue;
                    else
                        curNumber1 = listCopy[curIndex1];
                }
                else
                {
                    itemToPlace = curNumber2;
                    if (++curIndex2 > hi2)
                        curNumber2 = int.MaxValue;
                    else
                        curNumber2 = listCopy[curIndex2];
                }

                list[listStartIndex++] = itemToPlace;
            }
        }
    }
}
