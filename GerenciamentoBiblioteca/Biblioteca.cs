using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoBiblioteca
{
    internal class Biblioteca
    {
        string nome;
        List<Livro> livros;

        public Biblioteca(string nome)
        {
            this.nome = nome;
            livros = new List<Livro>();
        }

        public void CadastrarLivro(Livro livro)
        {
            livros.Add(livro);
            Console.WriteLine("Livro cadastrado com sucesso!");
        }

        public void ConsultarLivro(string titulo)
        {

        }

        public void ListarLivros()
        {
            Console.WriteLine(
                "Lista de livros cadastrados\n\n" +
                "Titulo, Autor, Ano Publicação, Quantidade de Exemplares\n\n");
            foreach (Livro livro in livros)
            {
                Console.WriteLine(livro);
            }

        }

        public void RealizarEmprestimo(string titulo)
        {

        }

        public void RealizarDevolucao(string titulo)
        {

        }
    }
}
