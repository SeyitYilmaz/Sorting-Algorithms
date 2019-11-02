using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellSort
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] dizi = { 25, 65, 84, 12, 1, 52 };
            int n = dizi.Length;

            for (int gap = n / 2; gap > 0; gap /= 2)
            {
                for (int i = gap; i < n; i += 1)
                {
                    double temp = dizi[i];

                    int j;
                    for (j = i; j >= gap && dizi[j - gap] > temp; j -= gap)
                        dizi[j] = dizi[j - gap];

                    dizi[j] = temp;
                }
            }

            for (int i = 0; i <n; i++)
            {
                Console.Write(" " + dizi[i]);

            }

            Console.ReadKey();
        }
    }
}
