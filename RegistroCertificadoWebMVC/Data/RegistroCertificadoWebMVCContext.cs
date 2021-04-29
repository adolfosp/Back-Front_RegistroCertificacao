using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RegistroCertificadoWebMVC.Models;

namespace RegistroCertificadoWebMVC.Data
{
    public class RegistroCertificadoWebMVCContext : DbContext
    {
        public RegistroCertificadoWebMVCContext (DbContextOptions<RegistroCertificadoWebMVCContext> options)
            : base(options)
        {
        }

        public DbSet<Instituicao> Instituicao { get; set; }

        public DbSet<RegistroCertificadoWebMVC.Models.Certificado> Certificado { get; set; }
    }
}
