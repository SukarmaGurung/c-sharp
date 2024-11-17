using System;
namespace Week3Tutorial
{
	public class PartTimeEmployee : Employee
	{
		public int HourlyRate { get; set; }
	
	
		public PartTimeEmployee( string name, string position, int hourlyRate): base (name,position)
		{
		HourlyRate = hourlyRate;
		}
	public override int CalculateSalary() {
		Console.WriteLine("Calculating salary of" + Name);
		Console.WriteLine("Enter total hours:");
			int hoursWorked = Convert.ToInt32(Console.ReadLine());
			return CalculateSalary(hoursWorked);
	}
		public int CalculateSalary(int hoursWorked)
		{
			return hoursWorked = HourlyRate;
		}
        public override void DisplayEmployeeDetails()
        {
            base.DisplayEmployeeDetails();
			Console.WriteLine("part time work rate:" + HourlyRate);
			Console.WriteLine("---------------------");
        }

    }
}

