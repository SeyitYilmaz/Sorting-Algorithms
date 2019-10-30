using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Algorithims
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int eleman = 0;
            int[] x = { 3, 8, 4, 9, 4 ,1};
            int size = x.Length;


            for (int i = 0; i < size; i++)
            {
                eleman = x[i];
                for (int y = i + 1; y < size; y++)
                {
                    if (x[y] < x[i])
                    {
                        x[i] = x[y];
                        x[y] = eleman;
                    }

                }

            }

            for (int i = 0; i < size; i++)
            {
                Console.Write(" " + x[i]);
            }

            Console.ReadKey();


        }
    }
}
