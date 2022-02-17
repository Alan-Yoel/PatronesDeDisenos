using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseños
{
    public class Creador
    {
        public const int vinoLaFuerza = 1;
        public const int cerveza = 2;

        public static FactoryMethod CreadorDeBebidas(int Tipo)
        {
            switch (Tipo)
            {
                case vinoLaFuerza:
                    return new VinoLaFuerza();
                case cerveza:
                    return new Cerveza();
                    default: return null;

            }
        }
    }
}
