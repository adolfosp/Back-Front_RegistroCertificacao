using Microsoft.EntityFrameworkCore;
using RegistroCertificadoWebMVC.Data;
using RegistroCertificadoWebMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroCertificadoWebMVC.Services
{
    public class InstituicaoService
    {

        private readonly RegistroCertificadoWebMVCContext _context;

        public InstituicaoService(RegistroCertificadoWebMVCContext registroCertificadoWebMVCContext)
        {
            _context = registroCertificadoWebMVCContext;
        }

     

        public async Task<List<Instituicao>> FindAllAsync()
        {
            return await _context.Instituicao.OrderBy(x => x.Nome).ToListAsync();
        }
    }
}
