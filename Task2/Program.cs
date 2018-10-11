using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("input.txt");
            string inputNum = sr.ReadLine();
            sr.Close();

            StreamWriter sw = new StreamWriter("output.txt");
            sw.WriteLine(Int64.Parse(inputNum.Split(' ')[0]) + Int64.Parse(inputNum.Split(' ')[1]) * Int64.Parse(inputNum.Split(' ')[1]));

            sw.Close();
        }
    }
}
