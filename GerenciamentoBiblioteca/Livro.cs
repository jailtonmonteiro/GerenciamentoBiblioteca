﻿using System;
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

        }

        public void Devolver()
        {

        }

        public void VerificarDisponibilidade()
        {

        }

        public override string ToString()
        {
            return 
                "\nTitulo: " + titulo + 
                "\nAutor: " + autor + 
                "\nAno Publicação: " + anoPublicacao + 
                "\nQuantidade de Exemplares: " + quantidadeExemplares;
        }
    }
}
