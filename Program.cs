using System;

namespace Inyeccion_de_Dependencias
{
    class Program
    {
        static void Main(string[] args)
        {
            /*CREO EL OBJETO BEBIDA DEL TIPO PIÑA-COLADA
            Y SE LO ENVIO COMO OBJETO AL CANTINERO
            (ESO ES LA INYECCION DE DEPENDENCIAS)*/

            IBebida oBebida = new MediasDeSeda("Picante");
            //IBebida oBebida = new PiñaColada();
            /*Aqui podemos crear cualquier objeto que implemente la interfas 
             * IBebida y se lo enviamos al cantinero
             */

            Cantinero oCantinero = new Cantinero(oBebida);
            oCantinero.preparar();
            Console.ReadLine();
        }
    }
}
