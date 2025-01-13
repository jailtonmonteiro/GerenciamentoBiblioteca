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

        public void Emprestar()
        {
            
        }

        public void Devolver()
        {

        }

        public void VerificarDisponibilidade()
        {

        }
    }
}
