using RegistroCertificadoWebMVC.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroCertificadoWebMVC.Models
{
    public class Certificado
    {

        public int Id { get; set; }

        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Display(Name = "Horas de Curso")]
        public int HorasConclusao { get; set; }

        [Display(Name = "Nome da Instituição")]
        public Instituicao Instituicao { get; set; }

        [Display(Name = "Nome da Instituição")]
        public int InstituicaoId { get; set; }

        [Display(Name = "Back/Front")]
        public AreaCertificado AreaCertificado { get; set; }
       
        public Certificado()
        {

        }

        public Certificado(int id, string descricao, int horasConclusao, Instituicao instituicao, AreaCertificado areaCertificado)
        {
            Id = id;
            Descricao = descricao;
            HorasConclusao = horasConclusao;
            Instituicao = instituicao;
            AreaCertificado = areaCertificado;
        }
    }
}
