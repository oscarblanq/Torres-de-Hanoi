using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Pila
    {
        public int Size { get; set; }
        public int Top { get; set; }
        public List<Disco> Elementos { get; set; }
        public Pila()
        {
            this.Elementos = new List<Disco>();
            this.Size = Elementos.Count;
            this.Top = 99;
        }

        public void push(Disco d)
        {
            this.Elementos.Insert(0, d);
            this.Size = this.Elementos.Count;
            this.Top = d.Valor;
        }

        public Disco pop()
        {
            Disco discoEliminado = this.Elementos[0];
            this.Elementos.RemoveAt(0);
            this.Size = this.Elementos.Count;
            if (isEmpty() == true) this.Top = 99;
            if (isEmpty() == false) this.Top = this.Elementos[0].Valor;
            return discoEliminado;
        }                

        public bool isEmpty()
        {
            if (Elementos.Count == 0) return true;
            else return false;
        }

    }
}
