using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Fibonacci_IEnumerable
{
    class Program
    {
        static void Main(string[] args)
        {
            var sequence = Fibonacci(8);
            foreach (var item in sequence)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            var subsequence = from c in sequence
                              where c % 2 == 0
                              select c;
            foreach (var item in subsequence)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            var seqsub = sequence.Select((i, index) => $"{sequence.ElementAt(index)} \t {index}");
            foreach (var item in seqsub)
            {
                Console.WriteLine(item);
            }

        }

        static IEnumerable<int> Fibonacci(int n)
        {
            int a = 0;  //0 1
            int b = 1;  //1 2
            int c = 1;  //1 3

            while (n > 0)
            {
                yield return c;

                c = a + b;  //2
                a = b;      //1
                b = c;      //2
                             
                n--;
            }
        }
    }
}
