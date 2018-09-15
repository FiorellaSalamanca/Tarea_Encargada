using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3PrincipioSolid
{
    public class Rectangle2
    {
        public double Sides { get; }
        public double Height { get; set; }
        public double Width { get; set; }

        public class AreaOperations
        {
            public static double Sum(IEnumerable<Rectangle> rectangles)
            {
                double area = 0;
                foreach (var rectangle in rectangles)
                    area += rectangle.Height * rectangle.Width;
                return area;
            }
        }


        public class PerimeterOperations
        {
            public static double SumPerimeters(IEnumerable<Rectangle> rectangles)
            {
                double perimeter = 0;
                foreach (var rectangle in rectangles)
                    perimeter += rectangle.Height * rectangle.Width;
                return perimeter;
            }
        }

        //donde cada clase tiene una responsabilidad
    }
}
