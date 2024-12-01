using Week5;

namespace Week5
{
    public class Program
    {
        public static void Main()
        {
            Student studentData = new Student()
            {
                ID = Guid.NewGuid().ToString(),
                Name = "Sukarma",
                Age = 20,
                Marks = 67,
                AcademicYear = "3rd"
            };
            DisplayDetails(studentData);

        }
        public static void DisplayDetails(Student studentData)
        {
            Console.WriteLine("Student data: ");
            Console.WriteLine($"ID: {studentData.ID}");
            Console.WriteLine($"Name: {studentData.Name}");
            Console.WriteLine($"Age: {studentData.Age}");

        }
    }
}


