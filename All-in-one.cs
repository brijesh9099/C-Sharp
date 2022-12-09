using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
namespace hello_world
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello World");
            Console.Read();
        }
    }
}
*/

/*
namespace Boxing_unboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            object obj;

            obj = a;
            Console.Write("Boxing value :");
            Console.WriteLine(obj);
            int b = (int)obj;
            Console.Write("Unboxing value :");
            Console.Write(b);

            Console.ReadKey();
        }
    }
}


/*
namespace Changebgcolor
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.BackgroundColor=ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.Write("enter a name");
            String name=Console.ReadLine();
            Console.Write("enter a age");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your name is "+name+" ans age is "+age);
            Console.ReadKey();

        }
    }
}
*/

/*  Operators
namespace Arrithmetic
{
    class Arithmatic
    {
        static void Main(string [] args)
        {
            int a=50;
            int b=100;

            // arithmatic 
            /*Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
            Console.WriteLine(a % b);
            Console.ReadKey();*/

            //logical
            /*
            Console.WriteLine(a!=0 && b!=0);
            Console.WriteLine(a!=0 || b!=0);
            Console.WriteLine(a != b);
            */

            //relational 
            /*
            if(a  <= b )
            {
                Console.WriteLine("a is bigger or same as b");
            }
            else if(b >= a)
            {
                Console.WriteLine("b is bigger or same as a");
            }
            else if(a!=b)
            {
               Console.WriteLine("a and b has diffrent value");
            }
            else if(a==b)
            {
                Console.WriteLine("a and b are same");
            }
            */

            //bitwise 
            /*
            Console.WriteLine(a & b);
            Console.WriteLine(a | b);
            Console.WriteLine(a << b);
            Console.WriteLine(a >> b);
            Console.WriteLine(~a);
            Console.WriteLine(a ^ b);
             */


            //switch case

              /*
             int renk=Convert.ToInt32(Console.ReadLine());

             switch (renk)
             {

                 case 1:

                     Console.WriteLine("you achive 1st renk");
                     break;


                 case 2:

                     Console.WriteLine("you achive 2nd renk");
                     break;


             } 
*/
/* loop's
            //for loop
            /*
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);

            }

            int j = 1;
            while (j != 10)
            {
                Console.WriteLine(j);
                j++;

            }

            int k = 1;

            do
            {
                Console.WriteLine(k);
                k++;
            } while (k != 10);

//Foreach
            namespace Foreach
            {
              class Program
              {
                static void Main(string[] args)
                {
                  string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
                  foreach (string i in cars) 
                  {
                    Console.WriteLine(i);
                  }
                  */
*/ 
    
/*
namespace Jagged_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] jagged_arr = new int[4][];
            
            jagged_arr[0] = new int[] {1, 2, 3, 4};
            jagged_arr[1] = new int[] {11, 34, 67};
            jagged_arr[2] = new int[] {89, 23};
            jagged_arr[3] = new int[] {0, 45, 78, 53, 99};
            
            for (int n = 0; n < jagged_arr.Length; n++)
            {               
                Console.Write("Row({0}): ", n);

                for (int k = 0; k < jagged_arr[n].Length; k++)
                {                  
                    Console.Write("{0} ", jagged_arr[n][k]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
*/
            Console.ReadKey();

        }
    }

}
