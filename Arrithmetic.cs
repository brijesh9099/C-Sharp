using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace operator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,b;
            Console.Write("Enter the first value  :");
            a = int.Parse(Console.ReadLine());
            Console.Write("Enter the second value :");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine();
         
            Console.WriteLine("A + B : " + (a + b));
            Console.WriteLine("A - B : " + (a - b));
            Console.WriteLine("A * B : " + (a * b));
            Console.WriteLine("A / B : " + (a / b));
            Console.WriteLine("A % B : " + (a % b));
            Console.Read();
        }
    }
}
