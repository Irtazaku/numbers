using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Numerics;

namespace numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("input.txt");
            int C = int.Parse(sr.ReadLine());
            for (int i = 0; i < C; i++)
            {
                int N = int.Parse(sr.ReadLine());
                double val = Math.Pow(2.23606797749979+3, (double)N);
                long intval = (int)val;
                
                if (intval % 1000 > 99)
                    Console.WriteLine(intval % 1000 + "\t " + val + "\t " + intval);
                else if (intval % 1000 > 9)
                    Console.WriteLine("0" + intval % 1000 + "\t " + val + "\t " + intval);
                else if (intval % 1000 > 0)
                    Console.WriteLine("00" + intval % 1000 + "\t " + val + "\t " + intval);
                else if (intval % 1000 <= 0)
                    Console.WriteLine("000" + "\t " + val + "\t " + intval);
            }
                sr.Close();

        }
    }
}
