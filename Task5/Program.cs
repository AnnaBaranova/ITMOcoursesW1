using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task5
{
    class Program
    {
        private static void QuickRecursiveSort(int[] arr, int low, int high, StreamWriter sw)
        {
            if (low < high)
            {
                int p = Partition(arr, low, high, sw);
                QuickRecursiveSort(arr, low, p, sw);
                QuickRecursiveSort(arr, p + 1, high, sw);
            }
        }
        private static int Partition(int[] arr, int low, int high, StreamWriter sw)
        //разбиение массива
        {
            int x = arr[(low + high) / 2];
            int i = low - 1;
            int j = high + 1;
            while (true)
            {
                do
                {
                    i++;
                } while (arr[i] < x);
                do
                {
                    j--;
                } while (arr[j] > x);

                if (i >= j)
                    return j;
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
                sw.WriteLine("Swap elements at indices {0} and {1}.", i + 1, j + 1);
            }
        }

        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("input.txt");
            int N = Int32.Parse(sr.ReadLine());
            int[] array = new int[N];

            array = sr.ReadLine().Split(' ').Select(n => Convert.ToInt32(n)).ToArray(); // string to array <int>
            sr.Close();

            StreamWriter sw = new StreamWriter("output.txt");
            QuickRecursiveSort(array, 0, array.Length - 1, sw);
            sw.WriteLine("No more swaps needed.");
            foreach (int elem in array)
                sw.Write(elem + " ");
            sw.Close();
        }
    }
}
