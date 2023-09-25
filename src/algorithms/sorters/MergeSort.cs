using System;
using System.Collections.Generic;
using System.Diagnostics;


namespace AD
{
    public partial class MergeSort : Sorter
    {
        public override void Sort(List<int> list)
        {
            Sort(list, new (0, list.Count - 1));
        }

        private void Sort(List<int> list, Tuple<int, int> range)
        {
            if (range.Item1 >= range.Item2)
                return;

            Tuple<int, int> range1 = new(range.Item1, range.Item1 + ((range.Item2 - range.Item1) / 2));
            Tuple<int, int> range2 = new(range1.Item2 + 1, range.Item2);

            Sort(list, range1);
            Sort(list, range2);

            Merge(list, range1, range2);
        }

        private void Merge(List<int> list, Tuple<int, int> list1, Tuple<int, int> list2)
        {
            int curIndex1 = list1.Item1;
            int curIndex2 = list2.Item1;

            // This should not be needed but just to be safe
            int listStartIndex = Math.Min(curIndex1, curIndex2);

            // Make sure to copy the list because we need to get the values from the original list
            var listCopy = new List<int>(list);

            int curNumber1 = list[curIndex1];
            int curNumber2 = list[curIndex2];
            
            while (curIndex1 <= list1.Item2 || curIndex2 <= list2.Item2)
            {
                int itemToPlace;
                if (curNumber1 < curNumber2)
                {
                    itemToPlace = curNumber1;
                    if (++curIndex1 > list1.Item2)
                        curNumber1 = int.MaxValue;
                    else
                        curNumber1 = listCopy[curIndex1];
                }
                else
                {
                    itemToPlace = curNumber2;
                    if (++curIndex2 > list2.Item2)
                        curNumber2 = int.MaxValue;
                    else
                        curNumber2 = listCopy[curIndex2];
                }

                list[listStartIndex++] = itemToPlace;
            }
        }
    }
}
