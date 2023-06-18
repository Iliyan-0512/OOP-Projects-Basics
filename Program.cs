using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            int sum = 0;
            do
            {
                number = int.Parse(Console.ReadLine());
                sum += number;

            } while (number!=0);
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
