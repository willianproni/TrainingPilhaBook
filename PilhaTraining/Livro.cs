using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilhaTraining
{
    internal class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int Paginas { get; set; }
        public int AnoPublicacao { get; set; }
        public Livro Anterior { get; set; }
       
        public Livro(string titulo, string autor, int paginas, int anoPublicacao)
        {
            Titulo = titulo;
            Autor = autor;
            Paginas = paginas;
            AnoPublicacao = anoPublicacao;
            Anterior = null;

            Console.WriteLine("\n    Livro Adicionado!!");
        }

        public override string ToString()
        {
            return "\n***************************" +
                "\n\tTítulo:" + Titulo +
                    "\n\tAutor:" + Autor +
                    "\n\tPáginas:" + Paginas +
                    "\n\tAno: " + AnoPublicacao +
                    "\n***************************";
        }
    }
}
