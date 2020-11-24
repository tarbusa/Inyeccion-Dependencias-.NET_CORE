using System;
using System.Collections.Generic;
using System.Text;

namespace Inyeccion_de_Dependencias
{
    public class MediasDeSeda : IBebida
    {
        public string tipo { get; set; }

        public MediasDeSeda(string tipo)
        {
            this.tipo = tipo;
        }
        public void preparar()
        {
            Console.WriteLine("se hace una Medias de SEDA " + this.tipo);
        }
    }
}
