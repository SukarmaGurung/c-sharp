//// See https://aka.ms/new-console-template for more information
////lab 1
////class Nilgiri
////{
////   public static void Main(string[] args)
////    {
////        Console.Write("Enter Your London Met ID:");
////        string studentId = Console.ReadLine();

////        Console.Write("Enter Your Name: ");
////        string studentName = Console.ReadLine();

////        Console.Write("Enter Your Age:");
////        int studentAge = Convert.ToInt32(Console.ReadLine());

////        Console.Write("Enter Your Gender:");
////        string studentGender = Console.ReadLine();

////        Console.Write("Enter your phone number:");
////        string phoneNumberString = Console.ReadLine();

////        Console.Write("Your Phone number:");
////        long phoneNumberLong = Convert.ToInt64(Console.ReadLine());



////        Console.WriteLine("\nStudent Details:");
////        Console.WriteLine("ID: " + studentId);
////        Console.WriteLine("Name:" + studentName);
////        Console.WriteLine("Age :" + studentAge);
////        Console.WriteLine("Gender:" + studentGender);
////        Console.WriteLine("Phone:" + phoneNumberLong);
////    }
////}

//// Lab1
////class Student
////{
////    public static void Main(string[] args)
////    {
////        string[] names = new string[]
////        {
////        "Sukarma",
////         "Sahil",
////        "Smriti",
////         "Abinash"
////        };
////        Console.WriteLine("First index:" + names[0]);
////        Console.WriteLine("Second index:" + names[1]);
////        Console.WriteLine("Third index:" + names[2]);
////        Console.WriteLine("Fouth index:" + names[3]);


////        var jaggedArray = new int[][]
////        {
////        new int []{1,2,3_00_000},
////        new int []{7,9},
////        new int []{4,5,6,9,1},
////        };
////        Console.WriteLine(jaggedArray[2][4]);


////    }
////}


////Tutorial 2

////var a = 15;
////var b = 5;
////var c = 7;
////int sum = a + b + c;
////int multiply = a * b;
////double quotient = a / c;
////double divide = (double)a / (double)c;
////int remainder = a % c;
////Console.WriteLine("Multiply eg:");
////Console.WriteLine(a + "*" + b + "=" + multiply + "\n");
////Console.WriteLine("Sum eg: ");
////Console.WriteLine("{0} + {1} + {2} = {3}\n", a ,b, c, sum);

////Console.WriteLine("Quotient eg: ");
////Console.WriteLine($"{a} / {c}  =  {quotient}\n");

////Console.WriteLine("Remainder eg:");
////Console.WriteLine("{0} %  {1} = {2}\n", a, c, remainder);


//////Console.WriteLine("Divide :" + divide);
////Console.WriteLine("Divide eg:");
////Console.WriteLine($"{a} / {c}  =  {divide}\n");

////second part 
////var i = 3;
////var j = 4;
////Console.WriteLine(i++);
////Console.WriteLine(i);
////Console.WriteLine(--j);
////i += 2;
////Console.WriteLine(i);
////var k = 5;
////Console.WriteLine(++k);


////third part

////var a = 6;
////var b = 7;
////var c = 8;
////if (a > b) {
////    Console.WriteLine("a is greater than b");
////}
////else if (b > c)
////{
////    Console.WriteLine("b is greater than c");
////}
////else if (c > a)
////{
////    Console.WriteLine("c is greater than a");

////}
////else
////{
////    Console.WriteLine("Won't come here");
////}
////Console.WriteLine(a > b ? $"{a}>{b}" : $"{b}>{a}");

////var x = 34;
////var y = 35;
////bool condition = --y >= x++;
////Console.WriteLine($"x={x}, y={y}");
////Console.WriteLine(condition);

////Console.WriteLine("For Loop:");
////for (int i =1; i<=5; i++)
////{
////    Console.WriteLine($"Even number {i}: {i * 2}");

////}
////string[] names = new string[]
////{
////    "Sukarma","Sahil","Abinash","Smriti"
////};

////Console.WriteLine("\nFor each loop: name list");
////foreach(string name in names)
////{
////    Console.WriteLine($"Hello, {name}:!");

////}
//////Console.WriteLine("\nWhile loop : Countdown from 5 to 1");
//////int count = 5;
//////while (count > 0)
//////{
//////    Console.WriteLine($)
//////}
////Console.WriteLine("\nWhile Loop: Countdown from 5 to 1");
////int count = 5;
////while (count > 0)
////{
////    Console.WriteLine($"Countdown: {count}");
////    count--;
////}

////Console.WriteLine("\nDo-While Loop: Enter even number to exit");
////int userInput;

////try
////{
////    do
////    {
////        Console.Write("Please enter any even numver, to exit: ");
////        userInput = Convert.ToInt32(Console.ReadLine());
////    } while (userInput % 2 == 0);

////    Console.WriteLine("You entered 'password'. Exiting...");
////}
////catch
////{
////    Console.WriteLine("You entered wrong format for input. Exiting...");
////}
////---------------------------------------



///* 
// * copy from lecture slide checked and unchecked 
// */


//// question 
//// 1. Using for loop, make a Multiplication table for any number.
//int number = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine($"Multiplication table of : {number}");
//for (int i = 1; i <= 10; i++)
//{
//    Console.WriteLine($"{number} * {i} = {number * i}");
//}


//// 2. Using while loop, starting from 1, double the number until it is greater than 100. (Try using Exception handling and not break the code on wrong input)

//// 3. Using do while loop, ask user to input number that is both divisible by 5 and 7.

////int number;

////// Keep asking the user until they enter a valid number divisible by both 5 and 7
////do
////{
////    Console.Write("Enter a number divisible by both 5 and 7: ");
////    number = Convert.ToInt32(Console.ReadLine());

////    if (number % 5 != 0 || number % 7 != 0)
////    {
////        Console.WriteLine("The number is not divisible by both 5 and 7. Try again.");
////    }

////} while (number % 5 != 0 || number % 7 != 0); // Condition to repeat if the number is not divisible by 5 and 7

////Console.WriteLine($"You entered a valid number: {number}");


//    int num=0; // Initialize the number variable

//    // Loop until the user enters a number divisible by both 5 and 7
//    do
//    {
//        try
//        {
//            Console.Write("Enter a number divisible by both 5 and 7: ");
//            number = Convert.ToInt32(Console.ReadLine());
//        }
//        catch (FormatException)
//        {
//            Console.WriteLine("Please enter a valid integer.");
//            continue; 
//        }

//    } while (num % 5 != 0 || num % 7 != 0);

//    Console.WriteLine($"You entered a valid number: {num}");



//// 4. Using foreach loop, given a list of names, print out which names have more than 5 letters.
//string[] names = new string[]
//        {
//            "Sukarma", "Sahil", "Abinash", "Smriti"
//        };

//// Iterate over the array and print names with more than 5 letters
//foreach (string name in names)
//{
//    if (name.Length > 5)
//    {
//        Console.WriteLine(name);
//    }
//}

///* 
// * Check out more Logical operators, Bitwise and binary shift operator 
// * 
// */
//for (int i = 1; i <= 10; i++)
//{
//    if(i%2==0)
//    {
//        Console.WriteLine
//    }
//}








// 1. Using for loop, make a Multiplication table for any number.

//Console.WriteLine("Enter a number for its multiplication table:");
//int number = Convert.ToInt32(Console.ReadLine());

//for (int i = 1; i <= 10; i++)
//{
//    int multiplication = number * i;
//    Console.WriteLine(number + "*" + i + "=" + multiplication);
//}

//// 2. Using while loop, starting from 1, double the number until it is greater than 100. 
//int num = 1;
//while (num <= 100)
//{
//    Console.WriteLine(num);
//    num *= 2;
//}
//Console.WriteLine(num);

//// 3. Using do while loop, ask user to input number that is both divisible by 5 and 7.(Try using Exception handling and not break the code on wrong input)

//int divBy = 0;
//bool check = false;
//do
//{
//    try
//    {
//        Console.WriteLine("Enter a number divisible by both 5 and 7: ");
//        divBy = int.Parse(Console.ReadLine());

//        if (divBy % 5 == 0 && divBy % 7 == 0)
//        {
//            Console.WriteLine(divBy + " is divisible by 5 and 7.");
//            check = true;
//        }
//        else
//        {
//            Console.WriteLine(divBy + " is not divisible by both 5 and 7");
//        }
//    }
//    catch (Exception ex)
//    {
//        Console.WriteLine("Please enter a valid number.");
//    }
//} while (!check);


////// 4. Using foreach loop, given a list of names, print out which names have more than 5 letters.
//string[] names = new string[]
//   { "Ram", "Shyam", "Andrew", "Ricky", "Mathew", "Felix", "Danish" };
//foreach (string name in names)
//{
//    if (name.Length < 5)
//    {
//        Console.WriteLine(name + " has less  than 5 letters");

//    }
//}

//// 5. Using for loop print out prime numbers between 1 to 50.
//bool isPrime = true;
//Console.WriteLine("Prime Numbers : ");
//for (int i = 2; i <= 50; i++)
//{
//    for (int j = 2; j <= 50; j++)
//    {

//        if (i != j && i % j == 0)
//        {
//            isPrime = false;
//            break;
//        }

//    }
//    if (isPrime)
//    {
//        Console.Write("\n" + i);
//    }
//    isPrime = true;
//}
//Console.ReadLine();




////6.Using foreach loop find out which is the largest score in a given list.
//List<int> scores = new List<int> { 7, 89, 9, 56, 178, 107, 92 };


//int largestScore = int.MinValue;


//foreach (int score in scores)
//{
//    if (score > largestScore)
//    {
//        largestScore = score; 
//    }
//}


//Console.WriteLine("The largest score is: " + largestScore);


////7.Using while loop check if a given input is a palindrome number. (eg: 121, 222, 65756 is palindrome 223, 5567, 112112 isn't)
////8.Using do while loop print the first N terms of Fibonacci sequence. (eg: input = 7 output = 0, 1, 1, 2, 3, 5, 8)

////9.Using while loop, print factorial of a number. (eg: input = 5 output = 120)
////10.Given a multidimensional array of 5 students with marks of 5 different subjects. Use for loop and find out which student has highest percentage.

    
public class TourPackage {
    //fields
    private int _id;
    private List <string> _destination;
    private int _days;
    private int _price;
    private string _name;
    private bool _booked;
    public static void Main()
    {
        TourPackage pokharaPackage = new TourPackage();
        pokharaPackage.SetUpPackage("Pokhara", 3, 9000);
        pokharaPackage.DisplayPackageDetails();
        pokharaPackage.BookPackage("Sukarma", true);
        pokharaPackage.DisplayPackageDetails();

        TourPackage ktmPackage = new TourPackage();
        ktmPackage.SetUpPackage("KTM", 6, 9000);
        ktmPackage.DisplayPackageDetails();
        ktmPackage.BookPackage("Kavita", true);
        ktmPackage.DisplayPackageDetails();

        TourPackage ktmPackage2 = new TourPackage();
        ktmPackage2.SetUpPackage("KTM", 7, 9000);
        ktmPackage2.DisplayPackageDetails();
        ktmPackage2.BookPackage("Ram", true);
        ktmPackage2.DisplayPackageDetails();

    }

    public void DisplayPackageDetails()
    {
        Console.WriteLine("Destination:" + _destination);
        Console.WriteLine("Days:" + _days);
        Console.WriteLine("Price:" + _price);
        Console.WriteLine("Booked status:" + _booked);
        if (!_booked) {
            Console.WriteLine("It isn't booked yet");
        }
        else {
            Console.WriteLine("Booked by:" + _name);
        }


    }
    public void SetUpPackage(string destination, int days, int price)
    {
        _destination = new List<string>();
        _destination.Add(destination);
        _days = days;
        _price = price;
        Console.WriteLine(_destination);
    }
    private void BookPackage(string name, bool book)

    {
        _name = name;
        _booked = book;
    }

}

    //basic examples
    //students
    //course
    //bankAccount
    //libraray









