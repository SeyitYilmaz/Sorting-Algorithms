using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermutationSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = { 1, 5, 8, 3, 4, 12, 26 };
            PermSort(dizi, dizi.Length);

            for (int i = 0; i < dizi.Length; i++)
            {
                Console.Write(" " + dizi[i]);
            }
            Console.ReadKey();
        }

        static void Swap<T>(ref T lhs, ref T rhs)
        {
            T temp;
            temp = lhs;
            lhs = rhs;
            rhs = temp;
        }

        // To check if array is sorted or not  
        public static bool IsSorted(int[] a, int n)
        {
            int i = 0;
            while (i < n - 1)
            {
                if (a[i] > a[i + 1])
                    return false;
                i++;
            }
            return true;
        }
 
        public static void Shuffle(int[] a, int n)
        {
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
                Swap(ref a[i], ref a[rnd.Next(0, n)]);
        }

        public static void PermSort(int[] a, int n)
        {
            while (!IsSorted(a, n))
                Shuffle(a, n);
        }
       
    }
}
