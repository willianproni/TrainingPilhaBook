using System;

namespace PilhaTraining
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PilhaLivro pilha = new PilhaLivro();

            int opcao;

            void Inserir()
            {
                Console.Clear();
                Console.WriteLine("-_-_-_-Inserindo Livros-_-_-_-_-\n");
                Console.Write("Digite o Título do Livro: ");
                string titulo = Console.ReadLine();
                Console.Write("Digite o Autor do Livro: ");
                string autor = Console.ReadLine();
                Console.Write("Digite o Número de Páginas: ");
                int paginas = int.Parse(Console.ReadLine());
                Console.Write("Digite o Ano de Publicação:");
                int ano = int.Parse(Console.ReadLine());

                pilha.Puch(new Livro(titulo, autor, paginas, ano));
                Console.ReadKey();
                Console.Clear();
            }

            void Menu()
            {
                Console.WriteLine("------------Menu-------------\n\n" +
                                    "[1] - Adicionar Livro\n" +
                                    "[2] - Imprimir livro\n" +
                                    "[3] - Remover livro\n" +
                                    "[4] - Buscar Livro\n");
                Console.WriteLine("------------------------------");
                Console.Write("Opção: ");
            }

            do
            {
                Menu();
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Inserir();
                        break;
                    case 2:
                        pilha.Print();
                        break;
                    case 3:
                        pilha.Pop();
                        break;
                    case 4:
                        pilha.Seach();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("----------------------------\nEscolha uma opção válida!!\n----------------------------");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            } while (true);
        }
    }
}
