using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3PrincipioSolid
{
    public class Rectangle
    {
        //Principio de Responsabilidad Unica

        //Aplicacion donde se tiene que sumar las areas y perimetros de un conjunto de rectangulos.
        
        public double Sides { get; }
        public double Height { get; set; }
        public double Width { get; set; }

        public static double SumAreas(IEnumerable<Rectangle> rectangles)
        {
            double area = 0;
            foreach (var rectangle in rectangles)
                area += rectangle.Height * rectangle.Width;
            return area;
        }


        public static double SumPerimeters(IEnumerable<Rectangle> rectangles)
        {
            double perimeter = 0;
            foreach (var rectangle in rectangles)
                perimeter += rectangle.Height * rectangle.Width;
            return perimeter;
        }

        //pero se observa que se esta violando el 1 principio solid : principio de responsabilidad unica

        // - No se debe declara los metodos SumAreas y SumPerimeters dentro de la clas Rectangle. 
    }
}
