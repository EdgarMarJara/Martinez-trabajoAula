using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _4_5_trabajo_de_listas
{
    class Program
    {
        static void Main()
        {
            int valor = 0;
            int suma = 0;
            float pmd = 0;
            Console.WriteLine("buenasss!!!");
            Lista listalol = new Lista();
            for (int i = 0; i <=25; i++)
            {
                listalol.Insertar();
                valor = listalol.Insertar();
                suma = suma + valor;
                Console.WriteLine($"El numero que entra es: {valor}");
            }
            pmd = suma / 100;
            Console.WriteLine($"La suma es: {suma}");
            Console.WriteLine($"El promedio es: {pmd}");
            Console.WriteLine("Press any key para salir");
            Console.ReadKey();
        }
    }
}
