using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroCertificadoWebMVC.Models
{
    public class Instituicao
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public Instituicao()
        {

        }

        public Instituicao(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }
    }
}
