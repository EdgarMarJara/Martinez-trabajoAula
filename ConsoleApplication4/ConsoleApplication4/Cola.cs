using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.cola
{
    class Cola
    {
        public Cola()
        {

        }
        public void insertarCola()
        {

        }
        public void imprimircola()
        {
            Queue<string> MiCola = new Queue<string>();
            MiCola.Enqueue("Mauro");
            MiCola.Enqueue("Augusto");
            MiCola.Enqueue("Mobin");
            MiCola.Enqueue("Nelson");
            while (MiCola.Count() > 0)
            {
                Console.WriteLine(MiCola.Dequeue());
            }
        }

    }
}
