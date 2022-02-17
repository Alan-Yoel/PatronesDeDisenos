using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseños
{
    //Esta clase pertenece al Patron de diseño FactoryMethod
     class VinoLaFuerza : FactoryMethod
    {
        public override int CuantoBebiPorHora()
        {
            return 20;
        }
    }
}
