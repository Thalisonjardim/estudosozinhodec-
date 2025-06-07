using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace estudo_sozinho.models
{
    public class Livro
    {
        private static int proximoId = 1;

        public int Id { get; set; }
        public string Titulo { get; set; }
        public Autor Autor { get; set; }

        public Livro(string titulo, Autor autor)
        {
            Id = proximoId++;
            Titulo = titulo;
            Autor = autor;
        }

        public void ExibirInfo()
        {
            Console.WriteLine($"Livro: {Titulo} | Autor: {Autor.Nome}");
        }


    }
}