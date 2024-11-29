


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
            double myDoubleNum = 5.99D;
            char myLetter = 'D';
            bool myBool = true;
            string myText = "Hello";
            Console.WriteLine(myNum3);
            Console.WriteLine(myDoubleNum);
            Console.WriteLine(myLetter);
            Console.WriteLine(myBool);
            Console.WriteLine(myText);


        }
    }
}

