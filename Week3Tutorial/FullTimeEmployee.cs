using System;
namespace Week3Tutorial
{
	public class FullTimeEmployee : Employee
	{
		public int FixedSalary { get; set; }
		public FullTimeEmployee( string name,string position,int fixedSalary):base(name,position)
		{
			FixedSalary = fixedSalary;

		}
        public override int CalculateSalary()
        {
			return FixedSalary;
        }
        public override void DisplayEmployeeDetails()
        {
            base.DisplayEmployeeDetails();
            Console.WriteLine("fixed salary:" + FixedSalary);
            Console.WriteLine("--------------------------");
        }
    }
}

