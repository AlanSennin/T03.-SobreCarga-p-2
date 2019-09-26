using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobreCarga1
{
    public class Operaciones
    {
        public double Multiplicar() //Metodo sin Parametros
        {
            double Res;

            Res = 0;

            return Res; //Retornando 0 ya que no tiene un Parametro
        }

        public double Multiplicar(double A) //Metodo con 1 Parametro
        {
            return A;  //Retornando lo que valga A
        }

        public double Multiplicar(double A, double B) //Metodo con 2 Parametros
        {
            return A*B; //Retornando los multiplicacion de los valores ingresados de A y B
        }
    }
}
