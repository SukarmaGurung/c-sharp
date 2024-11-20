using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week3Tutorial;

namespace Week3
{
    public class Square : Shape
    {
        public float Length { get; set; }
        public float Breadth { get; set; }
        public float Area { get; set; }
        public float Perimeter { get; set; }

        public Square(float length)
        {
            Length = length;

        }
        public override float CalculateArea()
        {
            Area = Length * Length;
            return Area;
        }

        public override float CalculatePerimeter()
        {
            Perimeter = 4 * Length;
            return Perimeter;
        }

        public void Display()
        {
            Console.WriteLine("Area of square = " + Area);
            Console.WriteLine("Perimeter of Square = " + Perimeter);
        }
    }
}