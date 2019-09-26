using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobreCarga1
{
    public class Datos
    {
        Operaciones R = new Operaciones(); //Instanciando la Clase Operaciones

        public void ObtenerDatos() //Metodo para obtener los datos
        {
            Console.WriteLine("Ingresar 2 Datos:");
            Console.WriteLine(" ");
            Console.WriteLine("Dato 1:");

            double N1 = Convert.ToDouble(Console.ReadLine()); //Asignarle valor al N1

            Console.WriteLine(" ");

            Console.WriteLine("Dato 2:");

            double N2 = Convert.ToDouble(Console.ReadLine()); //Asignarle valor al N2

            Console.WriteLine(" ");

            double Res1 = R.Multiplicar(); //Respuesta sin Parametros
            double Res2 = R.Multiplicar(N1); //Respuesta con 1 Parametro
            double Res3 = R.Multiplicar(N1, N2); //Respuesta con 2 Parametros

            Console.WriteLine("Sin Parametros: "+Res1);
            Console.WriteLine("Con 1 Parametro: "+Res2);
            Console.WriteLine("Con 2 Parametros: "+Res3);
            Console.WriteLine(" ");

            Console.WriteLine("Presione una Tecla para Salir...");

            Console.ReadKey();
        }
    }
}
