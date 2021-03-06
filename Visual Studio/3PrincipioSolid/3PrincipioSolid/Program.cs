﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3PrincipioSolid
{
    class Program
    {
        private static void Main(string[] args)
        {
            //programa inicia creando los rectangulos
            
            var rectangulos = new[]
            {
                new Rectangle {Width = 8, Height = 5},
                new Rectangle {Width = 4, Height = 6},
                new Rectangle {Width = 9, Height = 1},
                new Rectangle {Width = 8, Height = 9},
            };

            var sumaDeAreas = Rectangle.SumAreas(rectangulos);
            var sumaDePerimetros = Rectangle.SumPerimeters(rectangulos);

            Console.WriteLine("Area Total: " +   sumaDeAreas + "\n" + "Perimetro total: " + sumaDePerimetros);
            Console.ReadKey();
        }
    }
}
