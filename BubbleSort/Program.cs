using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] dizi = { 2, 5, 7, 2, 3, 9 };
            int sanalDepo;

            for (int i = 0; i < dizi.Length; i++)
            {
                bool siralimi = true;
                for (int j = dizi.Length-1; j> i; j--)
                {

                    if (dizi[j-1]>dizi[j])
                    {
                        siralimi = false;
                        sanalDepo = dizi[j - 1];
                        dizi[j - 1] = dizi[j];
                        dizi[j] = sanalDepo;
                    }

                }

                if (siralimi)
                {
                    break;
                }

            }


            for (int i = 0; i < dizi.Length; i++)
            {
                Console.Write(" " + dizi[i]);
            }


            Console.ReadKey();

        }
    }
}
