using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explicacao_PilhaEncadeada
{
    class Program
    {
        static void Main(string[] args)
        {

            Pilha_DinamicaLivro minha_pilha = new Pilha_DinamicaLivro { Topo = null };
            int escolha = 0, cont = 0;
            // Console.ReadKey();
            do
            {
                Console.WriteLine("******** MENU ********  ");
                Console.WriteLine("\n>>> ESCOLHA A OPÇÃO <<< ");
                Console.WriteLine(" 1) - Inserir um livro. ");
                Console.WriteLine("\n 2) - Remover um livro.");
                Console.WriteLine("\n 3) - Imprimir a pilha . ");
                Console.WriteLine("\n 4) - Quantidades de elementos na Pilha. ");
                Console.WriteLine("\n 5) - Busca de um livro na Pilha por título.");
                Console.WriteLine("\n 0) - Sair do Programa.\n");

                escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1: // menu principal 
                        Console.WriteLine(" PARA INSERIR UM LIVRO INFORME: ");
                        Console.WriteLine("\n Informe o título do seu livro: ");
                        string Titulo = Console.ReadLine();
                        Console.WriteLine("\n Informe o Autor do livro: ");
                        string Autor = Console.ReadLine();
                        Console.WriteLine("\n Informe o Registro do livro: ");
                        int Isbn = int.Parse(Console.ReadLine());
                        Livro l = new Livro
                        {
                            Titulo = Titulo,
                            Autor = Autor,
                            Isbn = Isbn,

                        };
                        //para inserir na lista
                        minha_pilha.Push(l);
                        cont--;
                        break;

                    case 2: // para excluir 
                        minha_pilha.Pop();
                        break;

                    case 3: // impressão da lista 
                        minha_pilha.ImprimirDados();
                        break;

                    case 4: // mostra a quantidade de livros da pilha 
                        Console.Write("A quantidade total de livros cadastrados na pilha é de: " + cont);
                        Console.WriteLine("");
                        break;

                    case 5: //busca do livro 
                        Console.Write("Informe o título do livro que deseja encontrar: ");
                        string encontrar = Console.ReadLine();
                        minha_pilha.BuscarLivro(encontrar);
                        break;
                    case 6: //Sair
                        Console.WriteLine("Pressione qualquer tecla para fechar o programa!");
                        break;

                }
            } while (escolha != 6);

            // trata a exceção de escolher numero diferente do menu 
            try
            {
                escolha = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Digite um Valor entre 0 e 5");

            }
           
            Console.ReadKey();
        }
        
    }
}



// fazer menu 

// inserir livro (ok), remover livro, imprimir, quantidade de elementos, busca de livro e  fechar
// Faz parte da explicação 
// tipo da minha pilha
//Pilha_DinamicaLivro minha_pilha = new Pilha_DinamicaLivro { Topo = null };
/* minha_pilha.Push(l);
 minha_pilha.Push(new Livro { Titulo = "A volta dos que não foram", Autor = "Jonh", Isbn = 456377 });
 minha_pilha.Imprimir();

 minha_pilha.Pop();
 minha_pilha.Imprimir();
 minha_pilha.Pop();
 minha_pilha.Imprimir();
 minha_pilha.Pop();*/

//Console.WriteLine(l.ToString());