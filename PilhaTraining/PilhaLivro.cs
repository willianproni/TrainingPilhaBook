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
            Console.Clear();
            Console.WriteLine("------------Mostrar Livros----------------");
            if (Vazio())
            {
                Console.WriteLine("Nenhum Livro Adicionado");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Livro imprimir = Topo;
                do
                {
                    Console.WriteLine(imprimir.ToString());
                    imprimir = imprimir.Anterior;
                } while (imprimir != null);
                Console.ReadKey();
                Console.Clear();
            }
        }

        public void Pop()
        {
            Console.Clear();
            Console.WriteLine("------------Remover Livro----------------");
            if (Vazio())
            {
                Console.WriteLine("Nenhum Livro Adicionado");
                Console.ReadKey();
                Console.Clear();
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
        public void Seach()
        {
            Console.Clear();
            Console.WriteLine("-----------Buscar Livro-------------\n");
            if (Vazio())
            {

                Console.WriteLine("Nenhum Livro Adicionado");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.Write("Digite o nome do Livro que deseja Buscar:");
                string busca = Console.ReadLine();
                Livro livro = Topo;
                do
                {
                    if (busca.CompareTo(livro.Titulo) == 0)
                    {
                        Console.WriteLine(livro.ToString());
                    }
                    livro = livro.Anterior;
                } while (livro != null);
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
