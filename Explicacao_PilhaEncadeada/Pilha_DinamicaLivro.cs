using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// pop pra retirar e push pra inserir == tradução 
namespace Explicacao_PilhaEncadeada
{
    class Pilha_DinamicaLivro
    {
        public Livro Topo { get; set; }

        public void Push(Livro aux)
        {
            if (Vazia())  // Verifica se a pilha esta vazia 
            {
                Topo = aux; // recebe o objeto 
            }
            else // se ele não tiver vazio 
            {
                aux.Anterior = Topo;
                Topo = aux; // topo recebendo aux       // só precisamos desse comando, pq o aux tbm verifica o vazio 
            }
            Console.WriteLine("Elemento inserido com sucesso!!!");
            return;
        }
        private bool Vazia()
        {
            if (Topo == null)
            {
                return true;
            }
            return false;
        }
        // para excluir 
        public void Pop()
        {
            int escolha = 0;

            if (escolha == 2)
            {
                if (Vazia())
                {
                    Console.WriteLine("Impossivel imprimir. Pilha Vazia!!!!!!!");
                    Console.ReadLine();
                }
                else
                {
                    Topo = Topo.Anterior;
                    Console.WriteLine("Elemento removido!!!");
                    Console.ReadLine();
                }
            }
        }
        public void ImprimirDados()
        {
            if (Vazia())
            {
                Console.WriteLine("Impossivel imprimir. Pilha Vazia!!!!!!!");
                Console.ReadLine();
            }
            else
            {
                Livro aux = Topo;
                Console.WriteLine("Os elementos na pilha são: ");
                do
                {
                    Console.WriteLine(aux.ToString());
                    aux = aux.Anterior;
                } while (aux != null);

                Console.WriteLine("\n\nPressione qualquer tecla para voltar ao menu...");
                Console.WriteLine("\n\n>>> FIM!!! <<<");
                Console.ReadKey();
            }
        }
        public void BuscarLivro(string encontrar)
        {
            Livro aux = Topo;
            do
            {
                aux.ImprimirTitulo(encontrar);
                aux = aux.Anterior;
                Console.WriteLine("");
            } while (aux != null);
        }
    }
}


// metodo de contar quantos livros tem 
//busca to titulo do livro 