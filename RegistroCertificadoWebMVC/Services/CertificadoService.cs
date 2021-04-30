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
        public async Task<Certificado> FindByIdAsync(int id)
        {
            return await _context.Certificado.Include(obj => obj.Instituicao).FirstOrDefaultAsync(obj => obj.Id == id);
            //eager loading - carregar um objeto dentro de outro objeto
        }

        public async Task UpdateAsync(Certificado certificado)
        {
            //bool hasAny = await _context.Certificado.AnyAsync(x => x.Id == certificado.Id);
            //if (!hasAny)
            //{
            //    throw new ApplicationException("Não foi possível encontrar o certificado");
            //}

            try
            {
                _context.Update(certificado);
                await _context.SaveChangesAsync();

            }
            catch (ApplicationException ex)
            {
                throw new ApplicationException("Não foi possível atualizar o registro: " + ex.Message);
            }

        }

    }
}
