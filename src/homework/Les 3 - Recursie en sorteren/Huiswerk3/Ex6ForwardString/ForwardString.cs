﻿using System.Collections.Generic;

namespace AD
{
    public class Opgave6
    {
        public static string ForwardString(List<int> list, int from_index)
        {
            if (list.Count < from_index + 1)
                return "";
            
            int lastNum = list[list.Count - 1];
            list.RemoveAt(list.Count - 1);
            
            return ForwardString(list, from_index) + " " + lastNum;
        }
        
        public static string BackwardString(List<int> list, int from_index)
        {
            if (list.Count < from_index + 1)
                return "";
            
            int lastNum = list[list.Count - 1];
            list.RemoveAt(list.Count - 1);
            
            return lastNum + " " + BackwardString(list, from_index);
        }

        public static void Run()
        {
            List<int> list = new List<int>(new int[] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11});

            System.Console.WriteLine(ForwardString(list, 3));
            System.Console.WriteLine(ForwardString(list, 7));
            System.Console.WriteLine(BackwardString(list, 3));
            System.Console.WriteLine(BackwardString(list, 7));
        }
    }
}
