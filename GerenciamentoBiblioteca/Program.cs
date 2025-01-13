using System;

namespace GerenciamentoBiblioteca
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao = 1;
            Livro livro;
            Biblioteca biblioteca = new Biblioteca("Biblioteca");



            do
            {
                Console.Clear();
                Console.WriteLine("GERENCIAMENTO DA BIBLIOTECA\n\n");
                Console.WriteLine(
                    "1 - Cadastro de Livro\n" +
                    "2 - Consulta de Disponibilidade\n" +
                    "3 - Emprestimo\n" +
                    "4 - Devolução\n" +
                    "5 - Lista de Livros\n" +
                    "0 - Sair\n"
                    );

                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Cadastro de Livro");
                        Console.WriteLine("Digite os dados separados por virgula ex.: (Livro,Autor,ano pub,quantidade)\nDados: ");
                        string[] dados = Console.ReadLine().Split(',');
                        livro = new Livro(dados[0], new Autor(dados[1]), int.Parse(dados[2]), int.Parse(dados[3]));
                        biblioteca.CadastrarLivro(livro);
                        break;

                    case 5:
                        biblioteca.ListarLivros();
                        Console.WriteLine("Pressione enter para sair.");
                        Console.ReadLine();
                        break;

                    default:
                        Console.WriteLine("");
                        break;
                }

            } while (opcao != 0);

        }
    }
}