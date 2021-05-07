using RegistroCertificadoWebMVC.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroCertificadoWebMVC.Services
{
    public class PerfilUsuarioService
    {
        public string[] RetornarEnum()
        {
            return Enum.GetNames(typeof(PerfilUsuario));
        }
    }
}
