using System;

namespace Inyeccion_de_Dependencias
{
    class Program
    {
        static void Main(string[] args)
        {
            Cantinero oCantinero = new Cantinero();
            oCantinero.preparar();
        }
    }
}
