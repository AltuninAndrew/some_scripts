using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static int[] Merge_Sort(Int32[] massive)
        {
            if (massive.Length == 1)
                return massive;
            int mid_point = massive.Length / 2;
            return Merge(Merge_Sort(massive.Take(mid_point).ToArray()), Merge_Sort(massive.Skip(mid_point).ToArray()));
        }

        static int[] Merge(Int32[] mass1, Int32[] mass2)
        {
            int a = 0, b = 0;
            int[] merged = new int[mass1.Length + mass2.Length];
            for (int i = 0; i < mass1.Length + mass2.Length; i++)
            {
                if (b < mass2.Length && a < mass1.Length)
                {
                    if (mass1[a] > mass2[b])
                    {
                        merged[i] = mass2[b++];
                    }                        
                    else
                    {
                        merged[i] = mass1[a++];
                    }
                }
                else if(b < mass2.Length)
                {
                    merged[i] = mass2[b++];
                }
                else
                {
                    merged[i] = mass1[a++];
                }
                   
            }
            return merged;
            
        }

        static void Main(string[] args)
        {
            int[] arr = new Int32[1000];
            //заполняем массив случайными числами
            Random rd = new Random();
            for (Int32 i = 0; i < arr.Length; ++i)
            {
                arr[i] = rd.Next(1, 101);
            }
            Console.WriteLine("The array before sorting:");
            foreach (int x in arr)
            {
                Console.Write(x + " ");
            }


            arr = Merge_Sort(arr);
            Console.WriteLine("\n\nThe array after sorting:");
            foreach (Int32 x in arr)
            {
                System.Console.Write(x + " ");
            }
            Console.WriteLine("\n\nPress any key");
            System.Console.ReadKey();
        }
    }
}
