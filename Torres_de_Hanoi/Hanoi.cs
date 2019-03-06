using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Hanoi
    {
        public void mover_disco(Pila a, Pila b)
        {
            if (a.Top < b.Top) b.push(a.pop());
            else if (a.Top > b.Top) a.push(b.pop());
        }

        public int iterativo(int n, Pila ini, Pila fin, Pila aux)
        {
            int m = 0;

            //Creación e introducción de los discos en la pila inicial
            for (int i = n; i > 0; i--) ini.push(new Disco(i));
            //Mostrar por pantalla los elementos del disco
            for (int i = 0; i <= ini.Elementos.Count - 1; i++)
            {
                Console.WriteLine("Valores de los discos en la pila[" + i + "]: " + ini.Elementos[i].Valor);
            }
            Console.WriteLine();
            Console.WriteLine("Número de discos en las pilas => INI: " + ini.Size + " AUX: " + aux.Size + " FIN: " + fin.Size);
            Console.WriteLine("TOP en las pilas => INI: " + ini.Top + " AUX: " + aux.Top + " FIN: " + fin.Top);
            Console.WriteLine();
            Console.WriteLine("EMPIEZA EL JUEGO");

            if (n % 2 != 0)
            {
                while (fin.Size != n)
                {
                    mover_disco(ini, fin); m++;
                    Console.WriteLine("________________________________________________________________________________");
                    Console.WriteLine("MOVIMIENTO Nº" + m + " REALIZADO: ");
                    Console.WriteLine("Número de discos en las pilas => INI: " + ini.Size + " AUX: " + aux.Size + " FIN: " + fin.Size);
                    Console.WriteLine("TOP en las pilas => INI: " + ini.Top + " AUX: " + aux.Top + " FIN: " + fin.Top);
                    if (fin.Size == n) break;

                    mover_disco(ini, aux); m++;
                    Console.WriteLine("________________________________________________________________________________");
                    Console.WriteLine("MOVIMIENTO Nº" + m + " REALIZADO: ");
                    Console.WriteLine("Número de discos en las pilas => INI: " + ini.Size + " AUX: " + aux.Size + " FIN: " + fin.Size);
                    Console.WriteLine("TOP en las pilas => INI: " + ini.Top + " AUX: " + aux.Top + " FIN: " + fin.Top);
                    if (fin.Size == n) break;

                    mover_disco(aux, fin); m++;
                    Console.WriteLine("________________________________________________________________________________");
                    Console.WriteLine("MOVIMIENTO Nº" + m + " REALIZADO: ");
                    Console.WriteLine("Número de discos en las pilas => INI: " + ini.Size + " AUX: " + aux.Size + " FIN: " + fin.Size);
                    Console.WriteLine("TOP en las pilas => INI: " + ini.Top + " AUX: " + aux.Top + " FIN: " + fin.Top);
                    if (fin.Size == n) break;
                }
            }


            if (n % 2 == 0)
            {
                while (fin.Size != n)
                {
                    mover_disco(ini, aux); m++;
                    Console.WriteLine("________________________________________________________________________________");
                    Console.WriteLine("MOVIMIENTO Nº" + m + " REALIZADO: ");
                    Console.WriteLine("Número de discos en las pilas => INI: " + ini.Size + " AUX: " + aux.Size + " FIN: " + fin.Size);
                    Console.WriteLine("TOP en las pilas => INI: " + ini.Top + " AUX: " + aux.Top + " FIN: " + fin.Top);
                    if (fin.Size == n) break;

                    mover_disco(ini, fin); m++;
                    Console.WriteLine("________________________________________________________________________________");
                    Console.WriteLine("MOVIMIENTO Nº" + m + " REALIZADO: ");
                    Console.WriteLine("Número de discos en las pilas => INI: " + ini.Size + " AUX: " + aux.Size + " FIN: " + fin.Size);
                    Console.WriteLine("TOP en las pilas => INI: " + ini.Top + " AUX: " + aux.Top + " FIN: " + fin.Top);
                    if (fin.Size == n) break;

                    mover_disco(aux, fin); m++;
                    Console.WriteLine("________________________________________________________________________________");
                    Console.WriteLine("MOVIMIENTO Nº" + m + " REALIZADO: ");
                    Console.WriteLine("Número de discos en las pilas => INI: " + ini.Size + " AUX: " + aux.Size + " FIN: " + fin.Size);
                    Console.WriteLine("TOP en las pilas => INI: " + ini.Top + " AUX: " + aux.Top + " FIN: " + fin.Top);
                    if (fin.Size == n) break;
                }
            }

            Console.WriteLine("________________________________________________________________________________");
            return m;
        }

    }
}
