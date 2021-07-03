//Programm1
/*
//Programm 1
using System;
namespace Homework2
{
    class Program
    {
        public static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Two numbers: ");
            Console.WriteLine("Sum is:  " + AddTwoNumbers(a, b));
        }
        public static int AddTwoNumbers(int a, int b)
        {
            int sum;
            sum = a + b;
            return sum;
        }

    }
}
*/
//programm2
/*
 * //Programm2
using System;

namespace Homework2
{
    class Program
    {
        public static void Main(string[] args)
        {
            int a, b, c;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                if (a > c)
                {
                    Console.WriteLine("The Largest number is " + a);
                }
                else
                {
                    Console.WriteLine("The Largest number is " + c);

                }

            }
            else
            {
                if (b > c)
                {
                    Console.WriteLine("The Largest number is " + b);
                }
                else
                {
                    Console.WriteLine("The Largest number is " + c);
                }
            }
        }
    }
}
*/
//programm3
/*
 * //program3

using System;
namespace homework2
{
    class program
    {
        public static void Main(string[] args)
        {
            int a, b, c;
            double D, x1, x2,rp,ip;
            Console.WriteLine("Calculating root of Quadratic equation: ax*2+bx+c=0\n ");
            Console.Write("Enter Value for a :");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the value for b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the value for c: ");
            c = Convert.ToInt32(Console.ReadLine());

            D = b * b - 4 * a * c;

            if (D >= 0)
            {
                x1 = (-b + Math.Sqrt(D)) / 2 * a;
                x2 = (-b - Math.Sqrt(D)) / 2 * a;
                Console.WriteLine("The x1 is: " + x1 + "\n The x2 is: " + x2);
            }
            else
            {
                rp = -b / 2 * a;
                ip = (Math.Sqrt(-D)) / 2 * a;

                Console.WriteLine("The x1 is: " + (rp+j(ip)) + "\n The x2 is: " + x2);
            }



        }
    }
}
*/
//programm4
/*
 * //Programm 4
using System;

namespace homework2
{
    class Programm
    {
        public static void Main(string[] args)
        {
          int  n = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Factorial of "+n+" is: "+Factorial(n));
          
        }
        public static int Factorial(int n)
        {
            int f = 1;
   
            for(int i = 1; i <= n; i++)
            {
                f = f * i;
            }
            return f;
        }
    }
}
*/
//programm5
/*
 * using System;
namespace exercise2
{
    class Programm
    {
        static void Main(string[] args)
        {
            int n, i, flag;
            flag = 0;
          
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 2; i <= n;i++)
            {
                if (n % i == 0)
                {
                    flag ++;
                }
            }
            if (flag == 1)
            {
                Console.WriteLine($"{n} is prime number");
            }
            else
            {
                Console.WriteLine($"{n} is not prime number");
            }
        }
    }
}
*/
//programm6
/*
 * using System;
namespace exercie2
{
    class Programm
    {
        static void Main(string[] args)
        {
            int first_term,temp,second_term;
            first_term = 0;
            for (second_term = 1; second_term <= 1000; second_term++)
            {
                temp = second_term;
                second_term = first_term + second_term;
                first_term = temp;
            }
            Console.WriteLine(second_term);         
        }
    }
}*/




