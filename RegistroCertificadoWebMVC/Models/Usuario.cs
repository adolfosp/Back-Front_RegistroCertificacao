using RegistroCertificadoWebMVC.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroCertificadoWebMVC.Models
{
    public class Usuario
    {

        public int Id { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "{0} Campo requerido")]
        public string Nome { get; set; }

        [Display(Name = "Senha")]
        [Required(ErrorMessage = "{0} Campo requerido")]
        public string Senha { get; set; }

        [Display(Name = "Login")]
        [Required(ErrorMessage = "{0} Campo requerido")]
        public string Login { get; set; }
        public PerfilUsuario Perfil { get; set; }
        public int Ativo { get; set; }

        [Display(Name = "E-mail")]
        [EmailAddress(ErrorMessage = "Entre com um E-mail válido")]
        [Required(ErrorMessage = "{0} Campo requerido")]
        public string Email { get; set; }

    }
}
