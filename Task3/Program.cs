using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("input.txt");
            int N = Int32.Parse(sr.ReadLine());
            int[] array = new int[N];

            array = sr.ReadLine().Split(' ').Select(n => Convert.ToInt32(n)).ToArray(); // string to array <int>
            sr.Close();

            StreamWriter sw = new StreamWriter("output.txt");

            for (int i = 0; i < array.Length; i++)
            {
                int cur = array[i];
                int j = i;
                while (j > 0 && cur < array[j - 1])
                {
                    array[j] = array[j - 1];
                    j--;
                }
                array[j] = cur;
                sw.Write(j + 1 + " ");
            }
            sw.WriteLine();

            foreach (int elem in array)
                sw.Write(elem + " ");
            sw.Close();
        }
    }
}
