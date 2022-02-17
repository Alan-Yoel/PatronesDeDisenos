using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseños
{
    internal class Program
    {
        //Esta funcion pertenece al ejemplo del patron de diseño FactoryMethod
        static void Main(string[] args)
        {
           FactoryMethod factoryMethod = Creador.CreadorDeBebidas(Creador.cerveza);
            //presentara los basos que me bebi por hora de vino o cerveza
            Console.WriteLine(factoryMethod.CuantoBebiPorHora());
        }
    }
}
