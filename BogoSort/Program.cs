using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BogoSort
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 2, 52, 21, 3,5,4 };

            BogoSort(list);

            Console.ReadKey();
        }

        static void BogoSort(List<int> list)
        {
            int iteration = 0;
            while (!IsSorted(list))
            {
                PrintIteration(list, iteration);
                list = Shuffle(list);
                iteration++;
            }

            PrintIteration(list, iteration);

        }

        static void PrintIteration(List<int> list, int iteration)
        {

            foreach (var value in list)
            {
                Console.Write($"{value} ");
            }
            Console.WriteLine();
        }
        static bool IsSorted(List<int> list)
        {
            for (int i = 0; i < list.Count - 1; i++)
            {
                if (list[i] > list[i + 1])
                {
                    return false;
                }
            }

            return true;
        }

        static List<int> Shuffle(List<int> numbers)
        {
            Random r = new Random();
           
            for (int n = numbers.Count - 1; n > 0; --n)
            {  
                int k = r.Next(n + 1);  
                int temp = numbers[n];

                numbers[n] = numbers[k];
                numbers[k] = temp;
            }
            return numbers;
        }
    }
}
