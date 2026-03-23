//  activity 1 : calculate using deligates 
//  we have to declare one deligates and use multiple methods call(add,substraction) //
/*
using System;

class Program
{
    // delegate declaration
    public delegate int Calc(int a, int b);

    static int Add(int a, int b)
    {
        return a + b;
    }

    static int Sub(int a, int b)
    {
        return a - b;
    }

    static void Main()
    {
        Calc obj;

        obj = Add;
        Console.WriteLine("Addition: " + obj(10, 5));

        obj = Sub;
        Console.WriteLine("Subtraction: " + obj(10, 5));
    }
}
*/

// 2) activity 2 :mutiple deligate example 
/*
using System;

class Program
{
    // delegate declaration
    public delegate int Calc(int a, int b);
    public delegate int Calc2(int a, int b);


    static int Add(int a, int b)
    {
        return a + b;
    }

    static int Sub(int a, int b)
    {
        return a - b;
    }

    static void Main()
    {
        Calc obj;
        Calc2 obj2;

        obj = Add;
        Console.WriteLine("Addition of del1: " + obj(10, 5));

        obj2 = Add;
        Console.WriteLine("Addition of del2: " + obj2(10, 10));

        obj2 = Sub;
        Console.WriteLine("Subtraction of del2: " + obj2(10, 10));

        obj = Sub;
        Console.WriteLine("Subtraction of del2: " + obj(10, 5));
    }
}
*/

// 3) activity 3 : repace method with lambda expression 

class Program
{
    // delegate declaration
    public delegate int Calc(int a, int b);
    

    static void Main()
    {
        Calc obj;

        // lambda function for addition 
        obj=(a,b) => a + b;
        Console.WriteLine("Addition: " + obj(10, 5));

        //lambda function for substraction
        obj = (a, b) => a - b;
        Console.WriteLine("sunstraction :" + obj(40, 20));

        obj = (a, b) => a * b;
        Console.WriteLine("multiplication :" + obj(40, 20));


        obj = (a, b) => a / b;
        Console.WriteLine("division :" + obj(40, 20));

    }
}

// 4):solve list using lambda expression 






// 5)where we use lambda and deligate used in company level and why 
//6)what is LINQ queries