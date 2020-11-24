using System;
using System.Collections.Generic;
using System.Text;

namespace Inyeccion_de_Dependencias
{
    public class PiñaColada : IBebida
    {
        public void preparar()
        {
            Console.WriteLine("se hace una piña colada");
        }
    }
}
