using RegistroCertificadoWebMVC.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroCertificadoWebMVC.Services
{
    public class AreaCertificadoService
    {

        public string[] RetornarEnum()
        {
            return Enum.GetNames(typeof(AreaCertificado));
        }
    }
}
