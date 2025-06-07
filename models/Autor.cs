using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace estudo_sozinho.models
{
    public class Autor
    {
        private static int proximoId = 1;

        public int Id { get; set; }
        public string Nome { get; set; }

        public Autor(string nome)
        {
            Id = proximoId++;
            Nome = nome;
        }
    }
}