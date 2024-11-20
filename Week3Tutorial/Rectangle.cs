using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week3Tutorial;

namespace Week3
{
    public class Rectangle : Shape
    {
        public float Length { get; set; }
        public float Breadth { get; set; }
        public float Area { get; set; }
        public float Perimeter { get; set; }
        public Rectangle(float length, float breadth)
        {
            Length = length;
            Breadth = breadth;

        }
        public override float CalculateArea()
        {
            Area = Length * Breadth;
            return Area;
        }

        public override float CalculatePerimeter()
        {
            Perimeter = 2 * (Length + Breadth);
            return Perimeter;
        }

        public void Display()
        {
            Console.WriteLine("Area = " + Area);
            Console.WriteLine("Perimeter = " + Perimeter);
        }
    }
}