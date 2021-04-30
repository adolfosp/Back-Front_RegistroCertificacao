using RegistroCertificadoWebMVC.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroCertificadoWebMVC.Models
{
    public class CertificadoFormViewModel
    {

        public Certificado Certificado { get; set; }
        public ICollection<Instituicao> Instituicaos { get; set; }

        public String[] AreaCertificados { get; set; }
    }
}
