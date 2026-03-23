using System;

namespace Helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int a = 5;
            int b = 6;

            Console.WriteLine("addition is :" + (a + b));
            Console.WriteLine("substraction  is :" + (a - b));
            Console.WriteLine("multiplication is :" + (a * b));
            Console.WriteLine("division is :" + (a / b));
            Console.WriteLine("modulus is : " + (a % b));
            Console.WriteLine("increment is " + (a++));
            Console.WriteLine("decrement is " + (b--));



            //print number using loop

            for(int i = 0; i < a; i++)
            {
                Console.WriteLine(i); 
            }


            //  2 .if - else statement 
            if (a > b)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }

            // 3 .type casting 

            int myNum = 10;
            Console.WriteLine(Convert.ToBoolean(myNum));
            Console.WriteLine(Convert.ToString(myNum));
            Console.WriteLine(Convert.ToDouble(myNum));


            // 4 . comparision operaters 

            Console.WriteLine("a>b :" + (a > b));
            Console.WriteLine("a>b :" + (a > b));
            Console.WriteLine("a>b :" + (a > b));




            // Arrays

            int[] mynum = { 10, 20, 40, 50 };
            Console.WriteLine(mynum[0]);
           







        }
    }
}

// we have to declare one deligates and use multiple methods call(add,substraction)
//activity 1 : calculate using deligates

//2)mutiple deligate example
// 3)activity 3 : repace method with lambda expression 
//  4):solve list usomg lambda expression
// 5)where we use lambda and deligate used in company level and why 
//6)what is LINQ queries