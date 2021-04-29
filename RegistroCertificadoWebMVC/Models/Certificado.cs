using RegistroCertificadoWebMVC.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroCertificadoWebMVC.Models
{
    public class Certificado
    {

        public int Id { get; set; }
        public string Descricao { get; set; }
        public int HorasConclusao { get; set; }
        public Instituicao Instituicao { get; set; }
        public AreaCertificado AreaCertificado { get; set; }

        public Certificado()
        {

        }

        public Certificado(int id, string descricao, int horasConclusao, Instituicao instituicao,AreaCertificado areaCertificado)
        {
            Id = id;
            Descricao = descricao;
            HorasConclusao = horasConclusao;
            Instituicao = instituicao;
            AreaCertificado = areaCertificado;
        }
    }
}
