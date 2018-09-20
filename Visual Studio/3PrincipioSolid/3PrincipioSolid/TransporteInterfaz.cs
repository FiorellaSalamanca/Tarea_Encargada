using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3PrincipioSolid
{
    //una interfaz por sí sola no aporta funcionalidad
    //fija un contrato que pueden implementar de manera distinta otras clases

    /*static class TransporteInterfaz
    {
        public static void Mover(this ITransporte transporte)
        {
            Console.WriteLine("Moviendo {0} ruedas", transporte.Ruedas);
        }
    }
    public interface ITransporte
    {
        public abstract int Ruedas { get; }
    }

    public class Coche : ITransporte
    {
        public override int Ruedas
        {
            get { return 4; }
        }
    }

    public class Bicicleta : ITransporte
    {
        public override int Ruedas
        {
            get { return 2; }
        }
    }*/
}
