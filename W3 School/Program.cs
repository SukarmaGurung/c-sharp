﻿


//It is an object-oriented programming language created by Microsoft that runs on the .NET Framework.
//C# has roots from the C family, and the language is close to other popular languages like C++ and Java.


using System; //using System means that we can use classes from the System namespace.

namespace HelloWorld // namespace is used to organize your code, and it is a container for classes and other namespaces.
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("I am Learning C#");
            Console.WriteLine("It is awesome!");
            Console.WriteLine(3 + 3);
            Console.Write("I will print on the same line.\n");

            string name = "John";
            Console.WriteLine(name ,"\n");

            int myNum = 15;
            Console.WriteLine(myNum );

            int myNum1;
            myNum1 = 7;
            Console.WriteLine(myNum1);

            int myNum2 = 15;
            myNum2 = 20; // myNum is now 20
            Console.WriteLine(myNum2);

            int myNum3 = 5;
            Console.WriteLine(myNum3);

            double myDoubleNum = 5.99D;
            Console.WriteLine(myDoubleNum);

            char myLetter = 'D';
            Console.WriteLine(myLetter);

            bool myBool = true;
            Console.WriteLine(myBool);

            string myText = "Hello";
            Console.WriteLine(myText);






            string name2 = "Sukarma";
            Console.WriteLine("Hello " + name2);


            string firstName = "Sukarma ";
            string lastName = "Gurung Ghale";
            string fullName = firstName + lastName;
            Console.WriteLine(fullName);

            int x = 5;
            int y = 6;
            Console.WriteLine(x + y); // Print the value of x + y

            int a = 5, b = 6, c = 50;
            Console.WriteLine(a + b + c);

            int d, e, f;
            d = e = f = 50;
            Console.WriteLine(d + e + f);

            int myNum4 = 100000;
            Console.WriteLine(myNum4);

            long myNum5 = 15000000000L;
            Console.WriteLine(myNum5);

            float myNum6 = 5.75F;
            Console.WriteLine(myNum6);

            double myNum7 = 19.99D;
            Console.WriteLine(myNum7);


        }
    }
}
