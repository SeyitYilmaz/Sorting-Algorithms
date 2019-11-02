using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = { 2, 52, 47, 7, 12, 55, 14 };

            MergeSort(dizi, 0, dizi.Length - 1);

            for (int i = 0; i < dizi.Length; i++)
            {
                Console.Write(" " + dizi[i]);
            }

            Console.ReadKey();

        }

        private static void Merge(int[] dizi, int sol, int orta, int sag)
        {
            int[] solDizi = new int[orta - sol + 1];
            int[] sagDizi = new int[sag - orta];

            Array.Copy(dizi, sol, solDizi, 0, orta - sol + 1);
            Array.Copy(dizi, orta + 1, sagDizi, 0, sag - orta);

            int i = 0;
            int j = 0;
            for (int k = sol; k < sag + 1; k++)
            {
                if (i == solDizi.Length)
                {
                    dizi[k] = sagDizi[j];
                    j++;
                }
                else if (j == sagDizi.Length)
                {
                    dizi[k] = solDizi[i];
                    i++;
                }
                else if (solDizi[i] <= sagDizi[j])
                {
                    dizi[k] = solDizi[i];
                    i++;
                }
                else
                {
                    dizi[k] = sagDizi[j];
                    j++;
                }
            }
        }

        private static void MergeSort(int[] dizi, int sol, int sag)
        {
            if (sol < sag)
            {
                int middle = (sol + sag) / 2;

                MergeSort(dizi, sol, middle);
                MergeSort(dizi, middle + 1, sag);

                Merge(dizi, sol, middle, sag);
            }
        }
    }
}
