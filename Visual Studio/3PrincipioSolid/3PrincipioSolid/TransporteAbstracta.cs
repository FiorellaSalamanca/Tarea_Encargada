using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3PrincipioSolid
{
    public abstract class TransporteAbstracta
    {
        //Las clases abstractas nos permiten tener una clase base con cierta funcionalidad común ya implementada
        //sobre la que podemos heredar y especificar algunos métodos. 

        //Ejemplo:
        
        //La clase Transporte implementa el método Mover, y las clases Coche y Bicicleta especifican el número de ruedas.

        public void Mover() //sealed
        {
            Console.WriteLine("Moviendo {0} ruedas", Ruedas);
        }
        public abstract int Ruedas { get; }
    }

    public class Coche : TransporteAbstracta
    {
        public override int Ruedas
        {
            get { return 4; }
        }
    }

    public class Bicicleta : TransporteAbstracta
    {
        public override int Ruedas
        {
            get { return 2; }
        }
    }
}
