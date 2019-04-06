using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQs
{
    class Program
    {
        static void Main(string[] args)
        {
            var collection = Enumerable.Range(0, 100);

            //foreach (var item in collection)
            //{
            //    Console.Write(item + " ");
            //}

            //Console.WriteLine();

            //var myCollection = MyEnumerable.MyRange(0, 100);

            //foreach (var item in myCollection)
            //{
            //    Console.Write(item + " ");
            //}

            //int i = 0;


            //int givensize = int.Parse(Console.ReadLine());

            //while (true)
            //{
            //    var withgivensize = myCollection.Skip(i * givensize).Take(givensize);

            //    if (withgivensize.Count() == 0)
            //    {
            //        break;
            //    }

            //    foreach (var item in withgivensize)
            //    {
            //        Console.Write(item + "\t");
            //    }
            //    Console.ReadKey();
            //    Console.WriteLine();
            //    i++;
            //}

            Console.WriteLine();

            var argumentvalues = collection.Select(i => i * (2 * Math.PI) / (collection.Count() - 1));
            var functionvalues = argumentvalues.Select(i => ( Math.Sin(i)));

            //foreach (var item in argumentvalues)
            //{
            //    Console.Write(Math.Round(item,2) + " ");
            //}

            IEnumerable<string> xyValues = collection
               .Select((i, index) => $"{Math.Round(argumentvalues.ElementAt(index), 2)} \t {Math.Round(functionvalues.ElementAt(index), 2)}");

            foreach (var item in xyValues)
            {
                Console.WriteLine(item);
            }

            Console.SetCursorPosition(60,60);
        }
    }
}
