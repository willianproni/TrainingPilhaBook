using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilhaTraining
{
    internal class PilhaLivro
    {
        public Livro Topo { get; set; }

        public PilhaLivro()
        {
            Topo = null;
        }

        public void Puch(Livro aux)
        {
            if (Topo == null)
            {
                Topo = aux;
            }
            else
            {
                aux.Anterior = Topo;
                Topo = aux;
            }
        }

        public void Print()
        {
            Livro imprimir = Topo;
            do
            {
                Console.WriteLine(imprimir.ToString());
                imprimir = imprimir.Anterior;
            } while (imprimir != null);
        }
    }
}
