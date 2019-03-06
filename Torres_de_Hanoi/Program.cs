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

            ini.push(new Disco(3));
            ini.push(new Disco(2));
            ini.push(new Disco(1));

            Hanoi juego = new Hanoi();

            juego.mover_disco(ini, fin);
            Console.WriteLine("________________________________________________________________________________");
            Console.WriteLine("PRIMER MOVIMIENTO REALIZADO: ");
            Console.WriteLine("Número de discos en las pilas => INI: " + ini.Size + " AUX: " + aux.Size + " FIN: " + fin.Size);
            Console.WriteLine("TOP en las pilas => INI: " + ini.Top + " AUX: " + aux.Top + " FIN: " + fin.Top);

            juego.mover_disco(ini, aux);
            Console.WriteLine("________________________________________________________________________________");
            Console.WriteLine("SEGUNDO MOVIMIENTO REALIZADO: ");
            Console.WriteLine("Número de discos en las pilas => INI: " + ini.Size + " AUX: " + aux.Size + " FIN: " + fin.Size);
            Console.WriteLine("TOP en las pilas => INI: " + ini.Top + " AUX: " + aux.Top + " FIN: " + fin.Top);

            juego.mover_disco(fin, aux);
            Console.WriteLine("________________________________________________________________________________");
            Console.WriteLine("TERCER MOVIMIENTO REALIZADO: ");
            Console.WriteLine("Número de discos en las pilas => INI: " + ini.Size + " AUX: " + aux.Size + " FIN: " + fin.Size);
            Console.WriteLine("TOP en las pilas => INI: " + ini.Top + " AUX: " + aux.Top + " FIN: " + fin.Top);

            juego.mover_disco(ini, fin);
            Console.WriteLine("________________________________________________________________________________");
            Console.WriteLine("CUARTO MOVIMIENTO REALIZADO: ");
            Console.WriteLine("Número de discos en las pilas => INI: " + ini.Size + " AUX: " + aux.Size + " FIN: " + fin.Size);
            Console.WriteLine("TOP en las pilas => INI: " + ini.Top + " AUX: " + aux.Top + " FIN: " + fin.Top);

            juego.mover_disco(aux, ini);
            Console.WriteLine("________________________________________________________________________________");
            Console.WriteLine("QUINTO MOVIMIENTO REALIZADO: ");
            Console.WriteLine("Número de discos en las pilas => INI: " + ini.Size + " AUX: " + aux.Size + " FIN: " + fin.Size);
            Console.WriteLine("TOP en las pilas => INI: " + ini.Top + " AUX: " + aux.Top + " FIN: " + fin.Top);

            juego.mover_disco(aux, fin);
            Console.WriteLine("________________________________________________________________________________");
            Console.WriteLine("SEXTO MOVIMIENTO REALIZADO: ");
            Console.WriteLine("Número de discos en las pilas => INI: " + ini.Size + " AUX: " + aux.Size + " FIN: " + fin.Size);
            Console.WriteLine("TOP en las pilas => INI: " + ini.Top + " AUX: " + aux.Top + " FIN: " + fin.Top);

            juego.mover_disco(ini, fin);
            Console.WriteLine("________________________________________________________________________________");
            Console.WriteLine("SÉPTIMO MOVIMIENTO REALIZADO: ");
            Console.WriteLine("Número de discos en las pilas => INI: " + ini.Size + " AUX: " + aux.Size + " FIN: " + fin.Size);
            Console.WriteLine("TOP en las pilas => INI: " + ini.Top + " AUX: " + aux.Top + " FIN: " + fin.Top);

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
