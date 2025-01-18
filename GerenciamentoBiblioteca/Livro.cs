using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoBiblioteca
{
    internal class Livro
    {
        string titulo;
        Autor autor;
        int anoPublicacao;
        int quantidadeExemplares;
        int quantidadeDisponivel;

        public Livro(string titulo, Autor autor, int anoPublicacao, int quantidadeExemplares)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.anoPublicacao = anoPublicacao;
            this.quantidadeExemplares = quantidadeExemplares;
            this.quantidadeDisponivel = quantidadeExemplares;
        }

        public string Titulo
        {
            get { return titulo; }
        }

        public void Emprestar()
        {
            if (quantidadeDisponivel > 0)
            {
                quantidadeDisponivel--;
                Console.WriteLine("Livro emprestado com sucesso!");
            }
            else
            {
                Console.WriteLine("Livro indisponível para empréstimo");
            }

        }

        public void Devolver()
        {
            if (quantidadeDisponivel < quantidadeExemplares)
            {
                quantidadeDisponivel++;
                Console.WriteLine("Livro devolvido com sucesso!");
            }
            else
            {
                Console.WriteLine("Não é possível devolver o livro");
            }
        }

        public void VerificarDisponibilidade()
        {
            if (quantidadeExemplares > 0)
            {
                Console.WriteLine("Livro disponível");
            }
            else
            {
                Console.WriteLine("Livro indisponível");
            }
        }

        public override string ToString()
        {
            return 
                "\nTitulo: " + titulo + 
                "\nAutor: " + autor + 
                "\nAno Publicação: " + anoPublicacao + 
                "\nQuantidade de Exemplares: " + quantidadeExemplares + "\n";
        }
    }
}
