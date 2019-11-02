using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeapAndHeapSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = { 65, 1, 28, 7, 88, 41, 47, 10, 75, 2, 27 };
           
            Sort(dizi);

            for (int i = 0; i < dizi.Length; i++)
            {
                Console.Write(" " + dizi[i]);
            }

            Console.ReadKey();
        }

        static void Sort(int[] dizi)
        {
            var uzunluk = dizi.Length;
            for (int i = uzunluk / 2 - 1; i >= 0; i--)
            {
                Heapify(dizi, uzunluk, i);
            }
            for (int i = uzunluk - 1; i >= 0; i--)
            {
                int temp = dizi[0];
                dizi[0] = dizi[i];
                dizi[i] = temp;
                Heapify(dizi, i, 0);
            }
        }

        static void Heapify(int[] dizi, int uzunluk, int i)
        {
            int enBuyuk = i;
            int sol = 2 * i + 1;
            int sag = 2 * i + 2;
            if (sol < uzunluk && dizi[sol] > dizi[enBuyuk])
            {
                enBuyuk = sol;
            }
            if (sag < uzunluk && dizi[sag] > dizi[enBuyuk])
            {
                enBuyuk = sag;
            }
            if (enBuyuk != i)
            {
                int swap = dizi[i];
                dizi[i] = dizi[enBuyuk];
                dizi[enBuyuk] = swap;
                Heapify(dizi, uzunluk, enBuyuk);
            }
        }

    }


}
