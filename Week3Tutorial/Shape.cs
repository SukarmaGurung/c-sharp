/*
         * Make a Shape parent class (with only two abstract method named CalculateArea, CalculatePerimter)
         * Make two another child classes of Shape: 
         * 1. Rectangle with attributes: length and height
         * 2. Square with attribute: length
         * Now make an example of Rectangle and Square objects and calculate their perimeter and area
         */
using System;
namespace Week3Tutorial
{
	public abstract class Shape
	{
        
 //       public Shape(float length, float breadth, float area, float perimeter)
	//	{
 //           Length = length;
 //           Breadth = breadth;
 //           Area = area;
 //           Perimeter = perimeter;
 //       }
        public abstract float CalculateArea();

        public abstract float CalculatePerimeter();
    }
}

