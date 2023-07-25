using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quicksort
{
    internal class Program
    {
        public static void quicksort(int[] array)
        {
            quicksort(array,0,array.Length-1);  
        }
        private static void quicksort(int[] array, int left, int right)
        {
           if(left<right)
            {
                int pivotIndex = Partition(array, left, right);
                quicksort(array, left, pivotIndex - 1);
                quicksort(array,pivotIndex + 1, right);
             }
        }

        private static int Partition(int[] array, int left, int right)
        {
            int pivot = array[right];
            int i = left - 1;
            for(int j=left; j<right; j++)
            {
                if (array[j] < pivot)
                {
                    i++;
                    Swap(array, i, j);
                }
            }
            Swap(array, i + 1, right);
            return i+1;
        }
        private static void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;    
        }

        public static void Print(int[] arr)
        {
            foreach(var item in arr)
            {
                Console.Write(item +" ");
            }
            Console.WriteLine("\n");
        }
        
        static void Main(string[] args)
        {
            int[] array = {9,1,4,-5,7,3,-2,8,10,13,-11};
            Console.WriteLine("Original array'");
            Print(array);
            Stopwatch stopwatch = new Stopwatch();  
            stopwatch.Start();
            quicksort(array);
            stopwatch.Stop();
            Console.WriteLine("After quick sort");
            Print(array);
            Console.WriteLine($"Arraysize {array.Length} time taken {stopwatch.Elapsed.TotalMilliseconds} milliseconds ");
            Console.ReadKey();

        }
    }
}
