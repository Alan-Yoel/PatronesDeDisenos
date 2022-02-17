using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseños
{
    // Esta clase pertenece al patron de diseño FactoryMethod
    class Cerveza : FactoryMethod
    {
        public override int CuantoBebiPorHora()
        {
            return 5;
        }
    }
}
