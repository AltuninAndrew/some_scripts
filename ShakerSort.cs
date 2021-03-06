using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arrayFirst = { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
            //int[] arraySecond = { 4, 7, 9, 2, 5, 0, 1, 3, 6, 8 };
            int[] randArray = new int[1000];

            Random rand = new Random();
            for (int i = 0; i < 1000; i++)
            {
                randArray[i] = rand.Next();
            }

            //Sort(arrayFirst);
            //Sort(arraySecond);
            Sort(randArray);
        }

        static void Sort(int[] array)
        {

            WriteArray(array);
            ShakerSort(array);
            WriteArray(array);

            Console.WriteLine("Press any key");
            Console.ReadKey();
        }

        static void ShakerSort(int[] myint)
        {
            int left = 0,
                right = myint.Length - 1,
                count = 0,
                swapCount = 0;


            while (left <= right)
            {
                for (int i = left; i < right; i++)
                {
                    count++;
                    if (myint[i] > myint[i + 1])
                    {
                        Swap(myint, i, i + 1);
                        swapCount++;
                    }
                        
                }
                right--;

                for (int i = right; i > left; i--)
                {
                    count++;
                    if (myint[i - 1] > myint[i])
                    {
                        Swap(myint, i - 1, i);
                        swapCount++;
                    }
                        
                }
                left++;
            }
            Console.WriteLine("\nNumber of comparisons = {0}", count.ToString());
            Console.WriteLine("\nNumber of swaps = {0}", swapCount.ToString());
        }

        static void Swap(int[] myint, int i, int j)
        {
            int glass = myint[i];
            myint[i] = myint[j];
            myint[j] = glass;
        }

        /*Вывести массив*/
        static void WriteArray(int[] a)
        {
            foreach (int i in a)
            Console.Write("{0}|", i.ToString());
            Console.WriteLine("\n");
        }


    }
}
