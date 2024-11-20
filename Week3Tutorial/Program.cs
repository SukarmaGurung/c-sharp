//using Week3Tutorial;

//public class Program
//{
//    public static void Main()
//    {
//        List<Employee> office = new List<Employee>();
//        //Employee employee = new Employee();
//        Employee fullEmployee1 = new FullTimeEmployee("Ram", "Manager", 400000);
//        Employee fullEmployee2 = new FullTimeEmployee("Shyam", "Analyst", fixedSalary: 200000);

//        office.Add(fullEmployee1);
//        office.Add(fullEmployee2);


//    }
//}

//using Week3Tutorial;

//public class Program
//{
//    public static void Main()
//    {
//        List<Employee> office = new List<Employee>();

//        #region Try
//        //Employee tryToMakeThisObject = new Employee();
//        #endregion

//        #region Full time employee
//        //Employee fullEmployee1 = new FullTimeEmployee("Ram", "Manager", 400000);
//        //Employee fullEmployee2 = new FullTimeEmployee("Shyam", "Analyst", fixedSalary: 200000);

//        //office.Add(fullEmployee1);
//        //office.Add(fullEmployee2);
//        #endregion

//        #region Part time employee

//        List<PartTimeEmployee> partTimeEmployees = new List<PartTimeEmployee>();

//        Employee halfEmployee1 = new PartTimeEmployee("Kiran", "Graphics designer", 15000);
//        Employee halfEmployee3 = new PartTimeEmployee("Mohan", "Tester", hourlyRate: 5000);

//        partTimeEmployees.Add((PartTimeEmployee)halfEmployee1); //typecasting garem hai
//        partTimeEmployees.Add((PartTimeEmployee)halfEmployee3);

//        office.AddRange(partTimeEmployees);

//        #endregion

//        #region Display all employees

//        Console.WriteLine("\n-------------------");
//        Console.WriteLine("Employees details: ");

//        foreach (Employee employee in office)
//        {
//            employee.DisplayEmployeeDetails();
//        }

//        #endregion

//        #region Calculations with PartTimeEmployee

//        int totalPartTimeBudget = 0;
//        foreach (PartTimeEmployee employee in partTimeEmployees)
//        {
//            totalPartTimeBudget += employee.CalculateSalary();
//        }

//        Console.WriteLine("\n-------------------");
//        Console.WriteLine("Total budget for part time emloyees: " + totalPartTimeBudget);

//        #endregion

//        #region Questions to practice
//        /*
//         * Make a Shape parent class (with only two abstract method named CalculateArea, CalculatePerimter)
//         * Make two another child classes of Shape: 
//         * 1. Rectangle with attributes: length and height
//         * 2. Square with attribute: length
//         * Now make an example of Rectangle and Square objects and calculate their perimeter and area
//         */
//        #endregion
//    }
//}

//#region Enum
//#endregion

//#region Struct
//#endregion

//#region Interface

//#endregion

//#region Generics
//#endregion

//#region Namespace

//#endregion