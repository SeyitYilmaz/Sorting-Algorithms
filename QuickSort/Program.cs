using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = { 5, 4, 25, 85, 12, 10, 3, 9, 71 };
            QuickSort(dizi, 0, dizi.Length - 1);

            for (int i = 0; i < dizi.Length; i++)
            {
                Console.Write(" " + dizi[i]);
            }
            Console.ReadKey();
        }
        private static void QuickSort(int[] dizi, int baslangic, int bitis)
        {
            int i;
            if (baslangic < bitis)
            {
                i = Partition(dizi, baslangic, bitis);

                QuickSort(dizi, baslangic, i - 1);
                QuickSort(dizi, i + 1, bitis);
            }
        }

        private static int Partition(int[] dizi, int baslangic, int bitis)
        {
            int temp;
            int p = dizi[bitis];
            int i = baslangic - 1;

            for (int j = baslangic; j <= bitis - 1; j++)
            {
                if (dizi[j] <= p)
                {
                    i++;
                    temp = dizi[i];
                    dizi[i] = dizi[j];
                    dizi[j] = temp;
                }
            }

            temp = dizi[i + 1];
            dizi[i + 1] = dizi[bitis];
            dizi[bitis] = temp;
            return i + 1;
        }
    }
}
