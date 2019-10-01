using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobre_Carga_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Operaciones m1 = new Operaciones();
            double res1=m1.Multiplicar();//aqui toma el valor de el metodo multiplicar
            double res2 = m1.Multiplicar(1,2);//no ocupo istanciar varias veces 
            double res3 = m1.Multiplicar(1);
            Console.WriteLine("resultado 1: "+res1);
            Console.WriteLine("resultado 2: " +res2);
            Console.WriteLine("resultado 3: " +res3);
            Datos d = new Datos();//instancio la clase Datos para poder acceder al metodo obtener datos
            // y que ejecute todo lo que tiene el medoto 
            d.Obtener_Datos();
            Console.ReadKey();
        }
    }
}
