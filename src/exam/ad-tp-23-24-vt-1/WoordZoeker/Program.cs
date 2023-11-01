using System;

namespace AD
{
    public class WoordZoeker
    {
        const int max_row = 5;
        const int max_col = 5;

        public static bool WoordBestaat(string woord, char[,] grid, int row, int col)
        {
            if (woord is null || woord.Length == 0)
                return true;

            if (row > grid.GetLength(0)-1 || col > grid.GetLength(1)-1 || col < 0 || row < 0)
                return false;

            var letter = woord.Substring(0, 1);
            var woordZonderBegin = woord.Substring(1);

            if (letter == grid[row, col].ToString())
            {
               bool left = WoordBestaat(woordZonderBegin, grid, row, col - 1);
               bool right = WoordBestaat(woordZonderBegin, grid, row, col + 1);
               bool above = WoordBestaat(woordZonderBegin, grid, row - 1, col);
               bool below =  WoordBestaat(woordZonderBegin, grid, row + 1, col);

               return left || right || below || above;
            }
            
            return false;
        }

        public static bool WoordBestaatUniek(string woord, char[,] grid, int row, int col)
        {
            if (woord is null || woord.Length == 0)
                return true;

            if (row > grid.GetLength(0)-1 || col > grid.GetLength(1)-1 || col < 0 || row < 0)
                return false;

            var letter = woord.Substring(0, 1);
            var woordZonderBegin = woord.Substring(1);

            if (letter == grid[row, col].ToString())
            {
                char[,] gridState = new char[grid.GetLength(0), grid.GetLength(1)];
                
                for (int x = 0; x < grid.GetLength(0); x++)
                    for (int y = 0; y < grid.GetLength(1); y++)
                        gridState[x, y] = grid[x, y];

                gridState[row, col] = ' ';
                
                bool left = WoordBestaat(woordZonderBegin, gridState, row, col - 1);
                bool right = WoordBestaat(woordZonderBegin, gridState, row, col + 1);
                bool above = WoordBestaat(woordZonderBegin, gridState, row - 1, col);
                bool below =  WoordBestaat(woordZonderBegin, gridState, row + 1, col);

                return left || right || below || above;
            }
            
            return false;
        }

        static void Main(string[] args)
        {
            char[,] arr =
{
                {'A', 'A', 'A', 'N', 'D' },
                {'B', 'C', 'A', 'A', 'A' },
                {'C', 'E', 'H', 'A', 'C' },
                {'D', 'F', 'G', 'T', 'H' },
                {'E', 'F', 'E', 'C', 'X' },
            };

            string[] word = { "AANDACHT", "AANDACHT", "AANDACHT", "AANDACHT", "EFFECT" };
            int[] row = { 0, 1, 2, 0, 2 };
            int[] col = { 1, 4, 3, 0, 1 };

            for (int i = 0; i < word.Length; i++)
            {
                System.Console.WriteLine($"WoordBestaat(\"{word[i]}\", {row[i]}, {col[i]}) = {WoordBestaat(word[i], arr, row[i], col[i])}");

            }
            System.Console.WriteLine();

            for (int i = 0; i < word.Length; i++)
            {
                System.Console.WriteLine($"WoordBestaatUniek(\"{word[i]}\", {row[i]}, {col[i]}) = {WoordBestaatUniek(word[i], arr, row[i], col[i])}");

            }
        }
    }
}
