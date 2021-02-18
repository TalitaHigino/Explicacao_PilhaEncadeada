using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explicacao_PilhaEncadeada
{
    class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int Isbn { get; set; }
        // atributo da propria classe 
        public Livro Anterior { get; set; }
        public override string ToString()
        {
            return ("\n\n>>> Dados do Livro <<<\n Titulo: " + Titulo + "\n Autor: " + Autor + "\n ISBN: " + Isbn);
        }
        public void ImprimirTitulo(string encontrar)
        {
            if (encontrar == Titulo)
            {
                Console.WriteLine("\n>>>DADOS DO LIVRO<<<\nTitulo: " + Titulo + "\nAutor: " + Autor
                    + "\nISBN: " + Isbn);
            }
            else
            {
                Console.WriteLine("\nLivro NÃO Encontrado!");
            }
        }
    }
}
