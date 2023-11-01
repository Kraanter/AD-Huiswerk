using System;
using System.Collections.Generic;
using System.Linq;

namespace AD
{
    public class FCNSSorter
    {

        static void Main(string[] args)
        {
            int[] nums = { 7, 13, 24, 24, 31, 10, 12, 24, 42, 26, 24 };

            FirstChildNextSiblingSorter sorter = new FirstChildNextSiblingSorter();
            Console.WriteLine("=== Init : PrintPreOrder ===");
            sorter.tree.PrintPreOrder();

            foreach (int num in nums)
            {
                sorter.VoegToe(num);
            }
            Console.WriteLine("=== VoegToe : PrintPreOrder ===");
            sorter.tree.PrintPreOrder();

            Console.WriteLine("=== Sorteer ===");
            List<int> nums_list = new List<int>(nums);
            sorter.Sorteer(ref nums_list);
            Console.WriteLine(String.Join(" ", nums_list));
        }
    }
}
