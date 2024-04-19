using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Basicprogram
    {
        public void assign1()
        {
            Console.WriteLine("This is first C# program");
        }
        public void assign2()
        {
            int a=10;
            float b = 20f;
            char c= 'a';
            long d = 123344;
            Console.WriteLine("integer=" + a + "float=" + b + "character=" + c + "long=" + d);
                }
        public void assign3()
        {
            int a,b,result;
            Console.WriteLine("enter two number ");
            a=Convert.ToInt32(Console.ReadLine());
            b=Convert.ToInt32(Console.ReadLine());
            result = a + b;
            Console.WriteLine("result=" + result);

           
        }
        public void assign4()
        {
            int a, b, add,mul,sub,div;
            Console.WriteLine("enter two number ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            add = a + b;
            mul = a * b;
            sub = b - a;
            div = a / b;
            Console.WriteLine("addition=" + add+"\n substraction="+sub+"\n multiplication="+mul+"\n division="+div);
        }
        public void assign5()
        {
            float length,bridth,perimeter;
            Console.WriteLine("enter length anf bridth number ");
            length=float.Parse(Console.ReadLine());
            bridth = float.Parse(Console.ReadLine());
            perimeter = length + bridth + length + bridth;
            Console.WriteLine("perimeter of circle is=" + perimeter);
        }
        public void assign6()
        {
            float length, bridth, area;
            Console.WriteLine("enter length anf bridth number ");
            length = float.Parse(Console.ReadLine());
            bridth = float.Parse(Console.ReadLine());
            area = length* bridth;
            Console.WriteLine("area of circle is=" +area);
        }
        public void assign7()
        {
            float rad,dm,cm,area,pi=3.14f;
            Console.WriteLine("enter Radius ");
            rad = float.Parse(Console.ReadLine());
            dm = 2 * rad;
            cm = 2 * pi * rad;
            area = pi*rad*rad;
            Console.WriteLine("diameter of circle is="+dm+"\ncircumference of circle is="+cm+"\narea of circle is=" + area);
        }
        public void assign8()
        {
            float cm, m, km;
            Console.WriteLine("enter centimeter");
            cm = float.Parse(Console.ReadLine());
            m = cm / 100;
            km = m / 1000;
            Console.WriteLine("meter is =" + m + "\nkilometer is=" + km);
        }
        public void assign9()
        {
            float cle, fah;
            Console.WriteLine("enter celcius =");
            cle=float.Parse(Console.ReadLine());
            fah = (cle * 9 / 5) + 32;
            Console.WriteLine(" Converted Fahrenheit is=" + fah);            
        }
        public void assign10()
        {
            int days, years, weeks;
            Console.Write("enter the days");
            days = Convert.ToInt32(Console.ReadLine());
            years = days / 365;
            weeks = (days % 365) / 7;
            Console.WriteLine("years=" + years + "weeks=" + weeks);
        }
        public void assign11()
        {
            //calculate power of number
            int x;
            int y;
            int pow;
            Console.WriteLine("Enter number x and y");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            pow = (int)Math.Pow(x, y);

            Console.WriteLine("Power of " + x + "^" + y + " =" + pow);

        }
        public void assign12()
        {
            //calculate power of number
            int x;
            int sqrt;
            Console.WriteLine("Enter number ");
            x = int.Parse(Console.ReadLine());
            sqrt = (int)Math.Sqrt(x);

            Console.WriteLine("Square of number is" + sqrt);

        }
        public void assign13()
        {
            int ang1, ang2;
            Console.WriteLine("enter angle 1 and angle 2");
            ang1 = int.Parse(Console.ReadLine());
            ang2 = int.Parse(Console.ReadLine());
            int ang3 = ang1 + ang2;
            Console.WriteLine("third angle is =" + ang3);
        }
        public void assign14()
        {
            float height, basee, area;
            Console.WriteLine("enter height and base");
            height = float.Parse(Console.ReadLine());
            basee = float.Parse(Console.ReadLine());
            area = (height * basee) / 2;
            Console.WriteLine("area is=" + area);

        }
        public void assign15()
        {
            float side, area;
            Console.WriteLine("enter side");
            side = float.Parse(Console.ReadLine());
            area = (1.73f * side * side) / 4;
            Console.WriteLine("area is=" + area);
        }
        public void assign16()
        {
            int a, b, c, d, e,total,avg;
            float per;
            Console.WriteLine("enter the marks of five subject");
            a= int.Parse(Console.ReadLine());  
            b= int.Parse(Console.ReadLine());
            c= int.Parse(Console.ReadLine());
            d= int.Parse(Console.ReadLine());
            e= int.Parse(Console.ReadLine());
            total=a+b+c+d+e;
            per = (float)total * 100 / 500;
            avg = (a + b + c + d + e) / 5;
            Console.WriteLine("total marks is=" + total + "\n average marks is =" + avg + "\npercentage is=" + per);
        }
        public void assign17()
        {
            float P, R, T, SI;
            Console.WriteLine("enter principle rate and time");
            P = float.Parse(Console.ReadLine());
            R = float.Parse(Console.ReadLine());
            T = float.Parse(Console.ReadLine());
            SI = P* R * T;
            Console.WriteLine("Simple intrest is =" + SI);
        }

        public void assign18()
        {
            float cle, fah;
            Console.WriteLine("enter Fahrenhit =");
            fah = float.Parse(Console.ReadLine());
            cle = (fah - 32) * 5 / 9;
            Console.WriteLine(" Converted Celcious is=" + cle);
        }
        public void assign19()
        {
            int a = 2;
            char ch = 'A';
            float f = 3.14f;
            double d = 2.34647;
            long b = 1234545;
            Console.WriteLine("a=" + a + "\nch=" + ch + "\nf=" + f + "\nd=" + d + "\nb=" + b);

            
        }
        public void assign20()
        {
            int a, b, add, mul, sub, div;
            Console.WriteLine("enter two number ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            add = a + b;
            mul = a * b;
            sub = b - a;
            div = a / b;
            Console.WriteLine("addition=" + add + "\n substraction=" + sub + "\n multiplication=" + mul + "\n division=" + div);
        }
        public void assign21()
        {
            int side, area;
            Console.WriteLine("enter side of square");
            side = Convert.ToInt32(Console.ReadLine());
            area = side * side;
            Console.WriteLine("area is=" + area);
        }
    }
}
