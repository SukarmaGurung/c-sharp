﻿


//It is an object-oriented programming language created by Microsoft that runs on the .NET Framework.
//C# has roots from the C family, and the language is close to other popular languages like C++ and Java.


using System; //using System means that we can use classes from the System namespace.
using static System.Reflection.Metadata.BlobBuilder;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Runtime.Intrinsics.X86;

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

            float f1 = 35e3F;
            Console.WriteLine(f1);

            double d1 = 12E4D;
            Console.WriteLine(d1); //A floating point number can also be a scientific number with an "e" to indicate the power of 10:

            bool isCSharpFun = true;
            Console.WriteLine(isCSharpFun);   // Outputs True

            bool isFishTasty = false;
           Console.WriteLine(isFishTasty);   // Outputs False

            char myGrade = 'B';
            Console.WriteLine(myGrade);

            string greeting = "Hello World";
            Console.WriteLine(greeting);

            // implicit typecasting

            int myInt = 9;
            double myDouble = myInt;       // Automatic casting: int to double

            Console.WriteLine(myInt);      // Outputs 9
            Console.WriteLine(myDouble);   // Outputs 9

            //explicit casting
            double myDouble1 = 9.78;
            int myInt1 = (int)myDouble;    // Manual casting: double to int

            Console.WriteLine(myDouble1);   // Outputs 9.78
            Console.WriteLine(myInt1);      // Outputs 9

            //type conversion method
            int myInt2 = 10;
            double myDouble2 = 5.25;
            bool myBool2 = true;

            Console.WriteLine(Convert.ToString(myInt2));    // convert int to string
            Console.WriteLine(Convert.ToDouble(myInt2));    // convert int to double
            Console.WriteLine(Convert.ToInt32(myDouble2));  // convert double to int
            Console.WriteLine(Convert.ToString(myBool2));   // convert bool to string

            //user input
            // Type your username and press enter
            //Console.WriteLine("Enter username:");

            //// Create a string variable and get user input from the keyboard and store it in the variable
            //string userName = Console.ReadLine();

            //// Print the value of the variable (userName), which will display the input value
            //Console.WriteLine("Username is: " + userName);


            //Console.WriteLine("Enter your age:");
            //int age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Your age is: " + age);

            //operators
            //arithmetic  +,-,*,/,%,a++,a--
            //assignments =,+=,-=,*=,/=,%=,&=,|=,x^=3 x=x^3
            //comparison ==,!=,>,<,>=,<=
            //logical &&,||,!

            int sum1 = 100 + 50;        // 150 (100 + 50)
            Console.WriteLine(sum1);

            int sum2 = sum1 + 250;      // 400 (150 + 250)
            Console.WriteLine(sum2);

            int sum3 = sum2 + sum2;     // 800 (400 + 400)
            Console.WriteLine(sum3);


            //comparison operators
            int h = 5;
            int g = 3;
            Console.WriteLine(h > g); // returns True because 5 is greater than 3

            //c# math
            int i = 5;
            int j = 10;
            Console.WriteLine(Math.Max(i,j));
            Console.WriteLine(Math.Min(i,j ));
            Console.WriteLine(Math.Sqrt(i));


            //c# strings
            //strings  A string variable contains a collection of characters surrounded by double quotes:
            string greeting1 = "Hello Sukarma";
            Console.WriteLine(greeting1);
            string greeting2 = "Nice to meet you!";
            Console.WriteLine(greeting2);
            //string length
            string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Console.WriteLine("The length of the txt string is: " + txt.Length);

            //upper to lower
            string txt1 = "Hello World";
            Console.WriteLine(txt1.ToUpper());   // Outputs "HELLO WORLD"
            Console.WriteLine(txt1.ToLower());   // Outputs "hello world"

            //concatenation
            string firstName1 = "Sukarma ";
            string lastName1 = "Gurung Ghale";
            string name1 = firstName1 + lastName1;
            Console.WriteLine(name1);

            //we can use string concat
            string firstName2 = "Kavita ";
            string lastName2 = "Gurung";
            string name3 = string.Concat(firstName2, lastName2);
            Console.WriteLine(name3);

            //            C# uses the + operator for both addition and concatenation.

            //Remember: Numbers are added.Strings are concatenated.
            int x1 = 10;
            int y1 = 20;
            int z1 = x1 + y1;  // z will be 30 (an integer/number)
            Console.WriteLine(z1);


            string x2 = "10";
            string y2 = "20";
            string z2 = x2 + y2;  // z will be 1020 (a string)
            Console.WriteLine(z2);


            //interpolation
            //Another option of string concatenation, is string interpolation, which
            //substitutes values of variables into placeholders in a string.
            //Note that you do not have to worry about spaces, like with concatenation:
            //you have to use the dollar sign ($) when using the string interpolation method.

            string firstName4 = "Ram";
            string lastName4 = "Gurung";
            string name4 = $"My full name is: {firstName4} {lastName4}";
            Console.WriteLine(name4);


            //Access strings
            string myString = "Hello";
            Console.WriteLine(myString[4]);  // Outputs "H"

            string myString1 = "Hello";
            Console.WriteLine(myString1.IndexOf("e"));  // Outputs "1"

            //special characters
            // \'=single quote,\"= double quotes,\\ =backslash,\n=next line,\t=tab,\b= backspace
            string txt2 = "We are the so-called \"Vikings\" from the north.";
            Console.WriteLine(txt2);

            string txt3 = "It\'s alright.";
            Console.WriteLine(txt3);

            string txt4 = "The character \\ is called backslash.";
            Console.WriteLine(txt4);

            //c# boolean
            //int myAge = 25;
            //int votingAge = 18;
            //Console.WriteLine(myAge >= votingAge);

            int myAge = 25;
            int votingAge = 18;

            if (myAge >= votingAge)
            {
                Console.WriteLine("Old enough to vote!");
            }
            else
            {
                Console.WriteLine("Not old enough to vote.");
            }


            //c# if 
            if (20 > 18)
            {
                Console.WriteLine("20 is greater than 18");
            }

            int p = 20;
            int q = 18;
            if (q < p)
            {
                Console.WriteLine("p is greater than q");
            }

            //c# else
            int time = 20;
            if (time < 18)
            {
                Console.WriteLine("Good day.");
            }
            else
            {
                Console.WriteLine("Good evening.");
            }

            //c# else if
            int timer = 22;
            if (timer < 10)
            {
                Console.WriteLine("Good morning.");
            }
            else if (timer > 20)
            {
                Console.WriteLine("Good day.");
            }
            else
            {
                Console.WriteLine("Good evening.");
            }

            //short hand if else
            //syntax variable = (condition) ? expressionTrue :  expressionFalse;

            int timers = 20;
            string result = (timers < 18) ? "Good day." : "Good evening.";
            Console.WriteLine(result);


            //c # switch

            //Use the switch statement to select one of
            //many code blocks to be executed


            int day = 4;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Sunday");
                    break;
                case 2:
                    Console.WriteLine("Monday");
                    break;
                case 3:
                    Console.WriteLine("Tuesday");
                    break;
                case 4:
                    Console.WriteLine("Wednesday");
                    break;
                case 5:
                    Console.WriteLine("Thrusday");
                    break;
                case 6:
                    Console.WriteLine("Friday");
                    break;
                case 7:
                    Console.WriteLine("Saturday");
                    break;
            }

            //The default keyword is optional and specifies
            //some code to run if there is no case match:
            int days = 4;
            switch (days)
            {
                case 6:
                    Console.WriteLine("Today is Saturday.");
                    break;
                case 7:
                    Console.WriteLine("Today is Sunday.");
                    break;
                default:
                    Console.WriteLine("Looking forward to the Weekend.");
                    break;
            }
            //c# while loops
            int m = 0;
            while (m < 5)
            {
                Console.WriteLine(i);
                m++;
            }

            int n = 0;
            do
            {
                Console.WriteLine(n);
                n++;
            }
            while (n < 6);


            //c# for loop
            //suntax for (statement 1; statement 2; statement 3) 
            //{
            //    // code block to be executed
            //}

            for (int s = 0; s < 5; s++)
            {
                Console.WriteLine(s);
            }
            for (int o = 0; o <= 10; o = o + 2)
            {
                Console.WriteLine(o);
            }


            // Outer loop
            for (int t = 1; t <= 2; ++t)
            {
                Console.WriteLine("Outer: " + t);  // Executes 2 times

                // Inner loop
                for (int u = 1; u <= 3; u++)
                {
                    Console.WriteLine(" Inner: " + u); // Executes 6 times (2 * 3)
                }
            }
            //my anpther login










        }
    }
}

