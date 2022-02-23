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

        public bool Vazio()
        {
            if (Topo == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Puch(Livro aux)
        {
            if (Vazio())
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
            if (Vazio())
            {
                Console.WriteLine("Nenhum Livro Adicionado");
            }
            else
            {
                Livro imprimir = Topo;
                do
                {
                    Console.WriteLine(imprimir.ToString());
                    imprimir = imprimir.Anterior;
                } while (imprimir != null);
            }
        }

        public void Pop()
        {
            if (Vazio())
            {
                Console.WriteLine("Nenhum Livro Adicionado");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("-_-_-_-_Removendo Livro_-_-_-_-_-\n");
                Console.WriteLine("Removendo..." + Topo.Titulo);
                Topo = Topo.Anterior;
                Console.ReadKey();
                Console.Clear();
            }

        }
    }
}
