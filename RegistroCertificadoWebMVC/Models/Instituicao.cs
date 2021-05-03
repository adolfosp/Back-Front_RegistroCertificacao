using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroCertificadoWebMVC.Models
{
    public class Instituicao
    {
        public int Id { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "{0} Campo requerido")]
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
