using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_5_trabajo_de_listas
{
    class Lista 
    {
        public int Insertar()
        {
            var seed = Environment.TickCount;
            var random = new Random(seed);
            var value = random.Next(0, 25);
            return value;
        }
    }
}
