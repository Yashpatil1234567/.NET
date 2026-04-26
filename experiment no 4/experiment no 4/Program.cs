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
/*
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
*/

// 4):solve list using lambda expression 

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> list = new List<int> { 5, 2, 8, 1, 3 };

        // Sort using lambda (ascending)
        list.Sort((a, b) => a.CompareTo(b));

        Console.WriteLine(string.Join(", ", list));
        // Sort using lambda (descending)
        list.Sort((a, b) => b.CompareTo(a));
        Console.WriteLine(string.Join(", ", list));
    }
}

// 5)where we use lambda and deligate used in company level and why 

//Lambdas and delegates are used in corporate software development (primarily C#/.NET) to write concise,
//functional-style code, specifically for filtering data (LINQ).
//handling events (e.g., UI button clicks), defining asynchronous callbacks .
// executing inline logic without needing a separate named method
//6)what is LINQ queries




//23-03-2026

//what is MVC : model view control

// mvc is design pattern used to develop scalable web appplication
// it seprates application into three different responsibilities
//they are Model View control(http request ) - it is brain of mvc  

// model - it is a data layer and it represents application data and buisness logic . 
//view - UI layer and it is responsible for displaying data to user and also for user interaction
//controller - handles user request and application flow . and it connect model and view.








