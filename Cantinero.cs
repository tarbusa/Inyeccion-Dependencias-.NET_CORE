using System;
using System.Collections.Generic;
using System.Text;

namespace Inyeccion_de_Dependencias
{
    public class Cantinero
    {
        PiñaColada bebida;
        public Cantinero()
        {
            this.bebida = new PiñaColada();

        }
        public void preparar()
        {
            this.bebida.preparar();
        }
    }
}
