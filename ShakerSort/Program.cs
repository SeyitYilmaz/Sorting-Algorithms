using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShakerSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = { 1, 5, 84, 12, 52, 47, 25 };

            ShakerSort(dizi);

            for (int i = 0; i < dizi.Length; i++)
            {
                Console.Write(" " + dizi[i]);
            }
            Console.ReadKey();

        }

        public static void ShakerSort(int[] dizi)
        {
            bool isSwapped = true;
            int start = 0;
            int end = dizi.Length;

            while (isSwapped == true)
            {


                isSwapped = false;

                for (int i = start; i < end - 1; ++i)
                {
                    if (dizi[i] > dizi[i + 1])
                    {
                        int temp = dizi[i];
                        dizi[i] = dizi[i + 1];
                        dizi[i + 1] = temp;
                        isSwapped = true;
                    }
                }

                if (isSwapped == false)
                    break;

                isSwapped = false;

                end = end - 1;

                for (int i = end - 1; i >= start; i--)
                {
                    if (dizi[i] > dizi[i + 1])
                    {
                        int temp = dizi[i];
                        dizi[i] = dizi[i + 1];
                        dizi[i + 1] = temp;
                        isSwapped = true;
                    }
                }

                start = start + 1;
            }
        }
    }
}
