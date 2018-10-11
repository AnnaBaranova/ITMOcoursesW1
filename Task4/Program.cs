using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Task4
{
    public class MyArray
    {
        public double value;
        public int index;

        public MyArray(double Val, int Ind)
        {
            value = Val;
            index = Ind;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("input.txt");
            int N = Int32.Parse(sr.ReadLine());
            MyArray[] array = new MyArray[N];

            double[] TempArr = sr.ReadLine().Split(' ').Select(n => Convert.ToDouble(n)).ToArray(); // string to array <int>
            sr.Close();

            for (int i = 0; i < array.Length; i++)
                array[i] = new MyArray(TempArr[i], i);
            
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j].value > array[j + 1].value)
                    {
                        MyArray temp = new MyArray(array[j].value, array[j].index);
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            StreamWriter sw = new StreamWriter("output.txt");

            int maxInd = array[N - 1].index + 1;
            int minInd = array[0].index + 1;
            int avInd = array[N / 2].index + 1;
            sw.Write(minInd + " " + avInd + " " + maxInd);
            sw.Close();
        }
    }
}
