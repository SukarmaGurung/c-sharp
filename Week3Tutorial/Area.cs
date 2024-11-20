using System;
namespace Week3Tutorial
{
	public class Area
	{
		public void CalculateArea(int length)
		{
			int area = length * length;
			Console.WriteLine("The area for square with length" + length + "is:" + area);
		}
        //Create an overload method to calculate area of circle for a given
        //Create an overload method for calculating area of rectangle
        public void CalculateArea(double radius)
		{
			double area = 3.14 * radius * radius;
            Console.WriteLine("The area for circle with radius" + radius + "is:" + area);

        }
        public void CalculateArea(int length, int breadth)
        {
            int area = length * breadth;
            Console.WriteLine("The area for reactangle with length" + length + " and breadth"+ breadth + "is:" + area);
        }
        public static void main()
        {

        }
    }
}

