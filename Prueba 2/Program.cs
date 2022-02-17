using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Recuerde introducir su edad en numeros sin letras ok? Ok");
            susDatosEstanCompletos();
            
            
            
        }
        static void susDatosEstanCompletos()
        {
            Console.WriteLine("Introduzca su nombre completo");
            string nombre;
            nombre = Console.ReadLine();

            Console.WriteLine("Introduzca su edad");
            int edad = int.Parse(Console.ReadLine());

            Console.WriteLine("Su nombre es: " + nombre);
            Console.WriteLine("Su edad es de: " + edad + " años");

            Console.WriteLine(suma(7, 6));

         
        }
        static int suma(int edad1, int edad2)
        {
            return edad1 + edad2;
        }
    }
}
