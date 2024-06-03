using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    internal class Program
    {
        static void Greet()
        {
            Console.WriteLine("Good morning");
        }
        static float Average(int a, int b, int c)
        {
            float sum = a + b + c;
            return sum/3;
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World");
            //Console.Write("Hello Ishu");
            //Console.WriteLine("I love C#");


            // single line comment example- This is important for debugging

            /* 
             * multi line comment example
             * This is multiline comment 
             * spanning multiple lines
             */


            // int harry = 34;  //Integer variable
            /*Data types in C#:
             * Integer - int harry;  --> 4 bytes
             * long - long harry --> 8 bytes
             * Floating point number - float that;  --> 4 bytes
             * double- double harry; --> 8 bytes
             * Character - char a ='A'; --> 2 bytes
             * Boolean - bool isGreat = ture; --> 1 bit
             * String - string inp = "Harry";  -->2 bytes per character
             */

            //Data types Examples
            //int a = 34;
            //float b = 34.4F;
            //double c = 34.4D;
            //bool isGreat = true;
            //char d = 'r';
            //string e = "This is a string";

            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);
            //Console.WriteLine(isGreat);
            //Console.WriteLine(d);
            //Console.WriteLine(e);

            //Type Casting 
            //Convert value of Data type from one to another
            //There is Two type of type casting
            //1. Implicit casting
            // char to int to long to float to double
            //2. Explicit casting
            // We give insturction to compiler for type casting
            //int x = (int)3.5;
            //double x1 = (double) 3.5;
            //Console.WriteLine(x1);


            // int x = 3;
            //double y = 4;
            //float z = 'y';
            //float varr = Convert.ToInt32(3.55);
            //Convert.ToDouble
            //Convet .ToString
            //string sx = "Random string";
            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //Console.WriteLine(z);


            //Console.WriteLine("Enter your name");
            //string name = Console.ReadLine();
            //Console.WriteLine("Hey hello " + name);

            //Console.WriteLine("How many candies do you want?");
            //string can = Console.ReadLine();
            //Console.WriteLine("You will get 4 more candies: " + (Convert.ToInt32(can) + 4));


            /*Operator in C#
             * 1. Arithmatic operators
             * 2. Assignment operators
             * 3. Logical operators
             * 4. Comparison operators
             */
            // Arithmatic Operator
            //int a = 4;
            //int b = 2;

            //Console.WriteLine("The value of a+b is: " + (a + b));
            //Console.WriteLine("The value of a-b is: " + (a - b));
            //Console.WriteLine("The value of a*b is: " + (a * b));
            //Console.WriteLine("The value of a/b is: " + (a / b));

            //Assignment Operator
            //int a = 4;
            //int b = a;
            //b += 4;   ans=8
            //b -= 4;   ans=0
            //b *= 4;   ans=16
            //b /= 4;   ans=1
            //Console.WriteLine(b);


            //Logical Operator
            //Console.WriteLine(true && true);
            //Console.WriteLine(true && false);
            //Console.WriteLine(false && false);

            //Console.WriteLine(true || true);
            //Console.WriteLine(true || false);
            //Console.WriteLine(false || false);

            //Console.WriteLine(!true);
            //Console.WriteLine(!false);


            // Comparison Operator
            //Console.WriteLine(324 > 555);
            //Console.WriteLine(324 <= 555);
            //Console.WriteLine(324 >= 555);
            //Console.WriteLine(324 != 555);
            //Console.WriteLine(324 == 555);


            //Math class in C#
            //int a = Math.Max(34, 345);
            //int a = Math.Min(34, 345);
            //double a = Math.Sqrt(39);
            //int a = Math.Abs(-39);
            //Console.WriteLine(a);


            //string methods
            //string hello = "Hello world this is Harry ";
            //Console.WriteLine(hello.Length);
            //Console.WriteLine(hello.ToUpper());
            //Console.WriteLine(hello.ToLower());
            //Console.WriteLine(hello + "You are nice");
            //Console.WriteLine(string.Concat(hello, "You are nice"));

            //string name = Console.ReadLine();
            //string candies = Console.ReadLine();
            //Console.WriteLine($"Your name is {name}. You will get{candies} candies");


            //string hello = "Hello world this is Harry";
            //Console.WriteLine(hello[0]);
            //Console.WriteLine(hello.IndexOf("is"));
            //Console.WriteLine(hello.Substring(5));
            //Console.WriteLine(hello);



            /*Escape Sequence Character
             * \" - print double " in middle of string
             * \n - new line
             * \t - one tab insert in line
            */


            //if else statement
            //Console.WriteLine("Enter your age");
            //string ageStr = Console.ReadLine();
            //int age = Convert.ToInt32(ageStr);
            //bool isBanned = true;

            //if(age < 2 || isBanned)
            //{
            //    Console.WriteLine("You are just born or banned");
            //}
            //else if(age < 10 || isBanned)
            //{
            //    Console.WriteLine(" Please finish your high school");
            //}
            //else if( age < 18)
            //{
            //    Console.WriteLine("You are below 18");
            //}
            //else if (age < 75)
            //{
            //    Console.WriteLine("You can drive");
            //}
            //else
            //{
            //    Console.WriteLine("You cannot drive");
            //}


            //int age = 20;
            //switch (age)
            //{
            //    case 18:
            //        Console.WriteLine("Please wait for an year");
            //        break;

            //     case 20:
            //        Console.WriteLine("You are 20");
            //        break;

            //    default:
            //        Console.WriteLine("Enjoy!");
            //        break;
            //}




            //Loops in C#
            //while loop
            //int i = 0;
            //while (i < 5)
            //{
            //    Console.WriteLine(i+1);
            //    i++;
            //}


            //do-while loop
            //int i = 0;
            //do {
            //    Console.WriteLine(i+1);
            //    i++;
            //} while (i < 5) ;



            //for loop
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(i+1);
            //}


            //break and Continue
            //break : loop ko chodke hamesha ke liye chale jao
                      //leave this loop forever
            //continue: ek iteration chodke next iteration krna
                      // leave this particular iteration of the loop

            //Greet();
            //Console.WriteLine(Average(2, 6, 8));
            Console.ReadLine();


        }
    }
}  
