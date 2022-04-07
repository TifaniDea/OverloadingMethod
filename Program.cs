using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanOverloadingMethod2
{
    class Program
    {
        static void Main(string[] args)
        {
            Numbers number = new Numbers();

            Console.WriteLine("Minimum #1 : {0}", number.FindMinimum(3, 1));
            Console.WriteLine("Minimum #2 : {0}", number.FindMinimum(3, 2, 4));
            Console.WriteLine(); // tambahkan baris kosong
            Console.WriteLine("Maximum #3 : {0}", number.FindMaximum(3, 1));
            Console.WriteLine("Maximum #4 : {0}", number.FindMaximum(3, 2, 4));

            Console.ReadKey();
        }
    }
}
