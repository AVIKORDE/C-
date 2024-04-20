using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Decision_makingProgram
    {
        public void program1()
        {
            int no;
            Console.WriteLine("Enter number");
            no=Convert.ToInt32(Console.ReadLine());
            if(no%2==0)
            {
                Console.WriteLine("even Number");
            }
            else
            { 
                Console.WriteLine("odd number");
               
            }
        }
        public void program2()
        {
            int a, b, c;
            Console.WriteLine("enter the value of a");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the value of b");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the value of c");
            c = Convert.ToInt32(Console.ReadLine());
            if(a>b&&a>c)
            {
                Console.WriteLine("A is greater");
            }
            else if(b>c&&b>a)
            {
                Console.WriteLine("b is greater");
            }
            else 
            {
                Console.WriteLine("c is greter");
            }
        }
        public void program3()
        {
            int year;
            Console.WriteLine("enter year");
            year = Convert.ToInt32(Console.ReadLine());
            if(year%400==0)
            {
                Console.WriteLine("Leap Year");
            }
            else if(year%100==0)
            {
                Console.WriteLine("not leap year");

            }
            else if( year%4==0)
            {
                Console.WriteLine("Leap Year");
               
            }
            else
            {
                Console.WriteLine("Not leap Year");
            }
        }
       
    }
}
