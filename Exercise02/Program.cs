using Exercise01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            Int64 million = 18000007;
            Console.WriteLine(million.Towards());

            Int64 billion = 100000000;
            Console.WriteLine(billion.Towards());

            Int64 trillion = 100000000000;
            Console.WriteLine(trillion.Towards());

            Int64 quadrillion = 100000000000000;
            Console.WriteLine(quadrillion.Towards());

            Int64 quintillion = 100000000000000000;
            Console.WriteLine(quintillion.Towards());

            Int64 example = 1845600203201100007;
            Console.WriteLine(example.Towards());


            Console.ReadLine();
        }
    }
}
