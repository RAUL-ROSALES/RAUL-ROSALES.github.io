﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobre_Carga_1
{
   public class Datos
    {
        public void Obtener_Datos()
        {
            Operaciones oper = new Operaciones();//instancio la clase para poder acceder a ella y poder usar los metodos 
            Console.WriteLine("===Hola===");
            Console.WriteLine("ingrese 2 datos");//pido datos para guardar en las variables 
            Console.WriteLine("dato 1");
            double c1 =Convert.ToDouble( Console.ReadLine());
            Console.WriteLine("dato 2");
            double c2 = Convert.ToDouble(Console.ReadLine());
            double res1 = oper.Multiplicar(c1, c2);
            Console.WriteLine("el resultado es: "+res1);//imprimo la suma de los datos que captura el usuario


        }
    }
}
