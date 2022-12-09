using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
            */
           
            int [][] arr=new int [3][];

            arr[0]=new int[3];
            arr[1] = new int[2];
            arr[2] = new int[1];

            

            
            Console.ReadKey();

        }
    }

}