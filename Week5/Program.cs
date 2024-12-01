using System.Text.Json;
using Week5;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Week5
{
    public class Program
    {
        public static void Main()
        {
            Student studentData = new Student()
            {
                ID = Guid.NewGuid().ToString(), //unique value 
                Name = "Sukarma",
                Age = 20,
                Marks = 67,
                AcademicYear = "3rd"
            };
            DisplayDetails(studentData);
            string fileName = "Sukarma.json";
            AddDataToJSONFile(studentData, fileName);

            //ReadDataFromJSONFile()

        }
        public static void DisplayDetails(Student studentData)
        {
            Console.WriteLine("Student data: ");
            Console.WriteLine($"ID: {studentData.ID}");
            Console.WriteLine($"Name: {studentData.Name}");
            Console.WriteLine($"Age: {studentData.Age}");
            Console.WriteLine($"AcademicYear: {studentData.AcademicYear}");
            Console.WriteLine($"Marks: {studentData.Marks}");

        }

        public static void AddDataToJSONFile(Student data, string fileName)
        {
            string jsonString = JsonSerializer.Serialize(data);
            File.WriteAllText(fileName, jsonString);
            Console.WriteLine("Data saved to file.");
        }

        public static Student ReadDataFromJSONFile(string fileName)
        {
            string jsonFromFile = File.ReadAllText(fileName);
            Student deserializedStudentData = JsonSerializer.Deserialize<Student>(jsonFromFile);

            return deserializedStudentData;
        }
        //public static void AddDataToJSONFile(Student data, string fileName)
        //{
        //    string jsonString = JsonSerializer.Serialize(data);
        //    File.WriteAllText(fileName, jsonString);
        //    Console.WriteLine("Data saved to file.");

        //}
        //public static Student ReadDataFromJSONFile(string fileName)
        //{
        //    string jsonFromFile = File.ReadAllText(fileName);
        //    Student deserializedStudentData = JsonSerializer.Deserialize<Student>(jsonFromFile);
        //    return deserializedStudentData
        //}
    }
}


