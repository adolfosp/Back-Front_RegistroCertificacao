using Microsoft.EntityFrameworkCore;
using RegistroCertificadoWebMVC.Data;
using RegistroCertificadoWebMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroCertificadoWebMVC.Services
{
    public class CertificadoService
    {
        private readonly RegistroCertificadoWebMVCContext _context;
        private readonly InstituicaoService _instituicaoService;

        public CertificadoService(RegistroCertificadoWebMVCContext registroCertificadoWebMVCContext,InstituicaoService instituicaoService)
        {
            _context = registroCertificadoWebMVCContext;
            _instituicaoService = instituicaoService;
        }


        public async Task InsertAsync(Certificado certificado)
        {
            _context.Add(certificado);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Certificado>> FindAllAsync()
        {
            var result = from obj in _context.Certificado select obj;

            //return await _context.Certificado.ToListAsync();

            return await result
                .Include(x => x.Instituicao).ToListAsync();

        }
    }
}
