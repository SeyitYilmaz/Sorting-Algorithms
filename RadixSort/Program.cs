using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadixSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = { 100,50,28,630,24,54,65 };

            int max = dizi.Max();
            for (int exp = 1; max / exp > 0; exp *= 10)
            {
                Siralama(dizi,dizi.Length, exp);
            }

            for (int i = 0; i < dizi.Length; i++)
            {
                Console.Write(" " + dizi[i]);
            }

            Console.ReadKey();
        }

        static void Siralama(int[] dizi,int diziUzunlugu,int sayiUssu)
        {
            
            int[] output = new int[diziUzunlugu];
            int i;
            int[] count = new int[10];

            for (i = 0; i < 10; i++)
            {
                count[i] = 0;
            }
            for (i = 0; i < diziUzunlugu; i++)
            {
                count[(dizi[i] / sayiUssu) % 10]++;
            }

            for (i = 1; i < 10; i++)
            {
                count[i] += count[i - 1];
            }

            for (i = diziUzunlugu - 1; i >= 0; i--)
            {
                output[count[(dizi[i] / sayiUssu) % 10] - 1] = dizi[i];
                count[(dizi[i] / sayiUssu) % 10]--;
            }

            for (i = 0; i < diziUzunlugu; i++)
            {
                dizi[i] = output[i];
            }
        }
    }
    
}
