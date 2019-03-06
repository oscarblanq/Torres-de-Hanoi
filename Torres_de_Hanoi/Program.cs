using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Pila ini = new Pila();
            Pila aux = new Pila();
            Pila fin = new Pila();

            Hanoi juego = new Hanoi();

            int numero = 3;

            int movimientos = juego.iterativo(numero, ini, fin, aux);

            Console.WriteLine("El número de movimientos es: "+movimientos+".");

            if (movimientos == Math.Pow(2, numero) - 1) Console.WriteLine("El juego es correcto.");

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
