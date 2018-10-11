using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {

            StreamReader sr = new StreamReader("input.txt");
            string inputNum = sr.ReadLine();
            sr.Close();
          
            int numOne = Int32.Parse(inputNum.Split(' ')[0]);
            int numTwo = Int32.Parse(inputNum.Split(' ')[1]);

            StreamWriter sw = new StreamWriter("output.txt");
            sw.WriteLine(numOne + numTwo);

            sw.Close();
        }

    }
}
