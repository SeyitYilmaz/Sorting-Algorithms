using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = { 25, 83, 27, 15, 68, 45 };
            int size = x.Length;
            for (int i = 1; i < size; ++i)
            {
                int oncekiSayi = x[i];
                int j = i - 1;
 
                while (j >= 0 && x[j] > oncekiSayi)
                {
                    x[j + 1] = x[j];
                    j = j - 1;
                }
                x[j + 1] = oncekiSayi;
            }
    

            for (int i = 0; i < x.Length; i++)
            {
                Console.Write(" " + x[i]);
            }

            Console.ReadKey();

        }
    }
}
