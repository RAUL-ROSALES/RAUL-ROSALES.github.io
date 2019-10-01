using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobre_Carga_1
{
   public class Operaciones
    {
        public double Multiplicar(double a)
        {
            double res;
            res = a*7;
            return res;
        }//creo tres metodos que sean del mismo tipo 
        //pero con diferentes parametros 
        public double Multiplicar(double a,double b)
        {
            double res;
            res = a* b;
            return res;
        }
        public double Multiplicar()
        {
            double res;
            res = 1 * 2;
            return res;
        }
    }
}
