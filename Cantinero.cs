using System;
using System.Collections.Generic;
using System.Text;

namespace Inyeccion_de_Dependencias
{
    public class Cantinero
    {
        //se instancia la INTERFAS O CONTRATO
        IBebida bebida;

        //en el constructor se recibe como parametro una bebida que respete la interfas
        public Cantinero(IBebida _bebida)
        {
            this.bebida = _bebida;

        }
        public void preparar()
        {
            this.bebida.preparar();
        }
    }
}
