namespace AD
{
    public class Opgave2
    {
        static long calls = 0;

        public static long FibonacciRecursive(int n)
        {
            calls = 0;
            throw new System.NotImplementedException();
        }

        public static long FibonacciIterative(int n)
        {
            calls = 0;
            throw new System.NotImplementedException();
        }

        public static void Run()
        {
            int MAX = 35;

            System.Console.WriteLine("Recursief:");
            for (int n = 1; n <= MAX; n++)
            {
                System.Console.WriteLine("          Fibonacci({0,2}) = {1,8} ({2,9} calls)", n, FibonacciRecursive(n), calls);
            }
            System.Console.WriteLine("Iteratief:");
            for (int n = 1; n <= MAX; n++)
            {
                System.Console.WriteLine("          Fibonacci({0,2}) = {1,8} ({2,9} loops)", n, FibonacciIterative(n), calls);
            }
        }
    }
}
