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

            //Número de discos con los que se va a jugar
            int numero = 3;
            
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("             ALGORITMO ITERATIVO");
            Console.WriteLine("********************************************************************************");

            int movimientos = juego.iterativo(numero, ini, fin, aux);

            Console.WriteLine("El número de movimientos es: " + movimientos + ".");

            if (movimientos == Math.Pow(2, numero) - 1) Console.WriteLine("El juego es correcto.");

            Console.WriteLine();

            //Una vez terminado el algoritmo iterativo, borro los discos introducidos en
            //la pila final para volver a reutilizarla antes de empezar el siguiente algoritmo
            for (int i = numero; i > 0; i--) fin.pop();

            Console.WriteLine("********************************************************************************");
            Console.WriteLine("             ALGORITMO RECURSIVO");
            Console.WriteLine("********************************************************************************");

            //Creación e introducción de los discos en la pila inicial
            for (int i = numero; i > 0; i--) ini.push(new Disco(i));

            //Imprimir los elementos del disco
            for (int i = 0; i <= ini.Elementos.Count - 1; i++)
            {
                Console.WriteLine("Valores de los discos en la pila ini[" + i + "]: " + ini.Elementos[i].Valor);
            }

            Console.WriteLine();
            Console.WriteLine("Número de discos en las pilas => INI: " + ini.Size + " AUX: " + aux.Size + " FIN: " + fin.Size);
            Console.WriteLine("TOP en las pilas => INI: " + ini.Top + " AUX: " + aux.Top + " FIN: " + fin.Top);
            Console.WriteLine();
            Console.WriteLine("EMPIEZA EL JUEGO");

            int movimientosR = juego.recursivo(numero, ini, fin, aux);

            Console.WriteLine("________________________________________________________________________________");
            Console.WriteLine("El número de movimientos es: "+movimientosR+".");

            if (movimientosR == Math.Pow(2, numero) - 1) Console.WriteLine("El juego es correcto.");

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
