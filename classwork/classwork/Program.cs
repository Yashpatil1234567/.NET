//generics allows us dtodegine classes , methods and collections with a place holder for a datatype 
// so they were with any type while maintaining typesept

//using System.Collections;
//using System.Numerics;

//ArryList List = new ArrayList();
//List.add(10);
//List.add("shivani");

//// no type safety. need to convert it into type casting

//List<int> number = new List<int>();
//number.Add(10);
//number.Add(20);
//number.Add("shivani");// error 

//// generics :complile time  type checking . no type casting is required . also for writing the clean code
//// why we use generics in C# 
//class myClass<T> {
//    public T data;
//    public void fun()
//    {
//        Console.WriteLine(data);
//    }
//}

//class myClass2
//{

//    public static void Main()
//    {

//        myClass<int> obj1 = new myClass<int>();
//        obj1.data = 10;

//        myClass<string> obj2 = new myClass<string>();
//        obj2.data = "pradip";


//    }
//}

// write a code with 2 examples in generics
// where we generics in company level

// lambda expression in C#(imp)
// it is a shorter way to write anonomous methods using the arrow operater(=>)
// syntax : (parameters)=>expression
// example : my delegate  del =(a,b)=> a+b ;
// lambda expression with list .

    












using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> number = new List<int>() { 1, 2, 3, 4 };

            var even = number.Where(n => n % 2 == 0);
            foreach (var item in even)
            {
                Console.WriteLine(item);



            }
        }
    }
}

// activity : where we use lambda in company level . write 2 examples of (=>)
// create a generic class to store a values 
// what is a generics and why it is better than arrayList 
// what is a constraint in generics 
// difference between delegats and lambda expression
// generics :
// lambda : short form of methods.

// async and await in c # 
// there are two types programming in c sharp 
// synchronous and asynchronus 
// synchronus - task executes line by line , blocking behaviour 





//Generics ACTIVITY :
//---------------------------------------------------------------------------------------

// 1.	Write 2 examples of generics

// /class Box<T> {
//     T value;

//     void setValue(T value) {
//         this.value = value;
//     }

//     T getValue() {
//         return value;
//     }
// }

// public class Main {
//     public static void main(String[] args) {
//         Box<Integer> intBox = new Box<>();
//         intBox.setValue(10);

//         Box<String> strBox = new Box<>();
//         strBox.setValue("Hello");

//         System.out.println(intBox.getValue());
//         System.out.println(strBox.getValue());
//     }
// }

// 2.	Real time use of generics 
// Real-time use of Generics (Simple):**
// Generics are used in real projects to store and manage data safely,
// like in lists, APIs, and databases.
// For example, in Java, `ArrayList<String>` ensures only strings are stored,
// which helps avoid errors and makes code reusable.


// // 3.	Why companies use generics
// 1. Type Safety
// Errors are caught at compile time
// Avoids runtime crashes

// 👉 Example:
// Without generics → wrong data type may crash app
// With generics → error shown immediately

// 🚀 2. Code Reusability
// One code works for multiple types
// Reduces duplicate code

// 👉 Instead of writing:

// intBox, stringBox, floatBox
// 👉 One Box<T> handles all
// 🚀 3. Better Readability & Maintainability
// Clean and structured code
// Easy for teams to understand
// 🚀 4. Performance Improvement
// No need for type casting
// Faster execution




