using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swapping_numbers
{
    class Program
    {
        // This program will swap the numbers 5 and 6
        static void Main(string[] args)
        {


            int number5, number6, temp;
            Console.Write("\n Put number 5 : ");
            number5 = int.Parse(Console.ReadLine());
            Console.Write("\n Put  number 6 : ");
            number6 = int.Parse(Console.ReadLine());
            temp = number5;
            number5 = number6;
            number6 = temp;
            Console.Write("\nAfter Swapping : ");
            Console.Write("\nFirst Number : " + number5);
            Console.Write("\nSecond Number : " + number6);
            Console.Read();
        }

    }
}
