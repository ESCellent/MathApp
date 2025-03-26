using System;

namespace Math 
{
    class Fibonacci 
    {
        static void Main(string[] args)
        {
            Console.Write("Insert N: ");
            int N = int.Parse(Console.ReadLine());
            List<int> FibonacciNumbers = GetFibonacciNumbers(N);

            Console.WriteLine("Here is the fibonacci till " + N + ":");
            foreach(var num in FibonacciNumbers)
            {
                Console.Write(num + " ");
            }
        }
        static List<int> GetFibonacciNumbers(int N)
        {
            List<int> FibonacciNumbers = new List<int>();
            int a = 0, b = 1;
            if (a <= N) FibonacciNumbers.Add(a);
            if (b <= N) FibonacciNumbers.Add(b);

            while (true)
            {
                int next = a + b;
                if (next > N) break;
                FibonacciNumbers.Add(next);
                a = b;
                b = next;
            }
            return FibonacciNumbers;
        }
    }
}
