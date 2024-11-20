////using System;
////using System.Collections.Generic;
////using System.Linq;
////using System.Text;
////using System.Threading.Tasks;
////using Week3Tutorial;

////namespace Week3
////{
////    public class ShapeCalculator
////    {
////        public static void Main()
////        {
////            List<Shape> shape = new List<Shape>();
////            Shape sh = new Shape();


////            List<Rectangle> rec = new List<Rectangle>();

////            List<Square> sq = new List<Square>();

////            Shape rec1 = new Rectangle(55, 6);
////            Shape rec2 = new Rectangle(9, 5);

////            Shape sq1 = new Square(5);
////            Shape sq2 = new Square(10);


////            rec.Add((Rectangle)rec1);
////            rec.Add((Rectangle)rec2);

////            shape.AddRange(rec);

////            sq.Add((Square)sq1);
////            sq.Add((Square)sq2);

////            shape.AddRange(sq);

////            foreach (Shape shape in office)
//////        {
//////            employee.DisplayEmployeeDetails();
//////        }

////        }

////    }
////}
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Week3Tutorial;

//namespace Week3
//{
//    public class ShapeCalculator
//    {
//        public static void Main()
//        {
//            List<Shape> shape = new List<Shape>();

//            List<Rectangle> rec = new List<Rectangle>();

//            List<Square> sq = new List<Square>();

//            Shape rec1 = new Rectangle(55, 6);
//            Shape rec2 = new Rectangle(9, 5);

//            Shape sq1 = new Square(5);
//            Shape sq2 = new Square(10);


//            rec.Add((Rectangle)rec1);
//            rec.Add((Rectangle)rec2);

//            shape.AddRange(rec);

//            sq.Add((Square)sq1);
//            sq.Add((Square)sq2);

//            shape.AddRange(sq);

//            foreach (Rectangle r in rec)
//            {
//                r.Display();
//            }

//            foreach (Square s in sq)
//            {
//                s.Display();
//            }
//        }
//    }
//}