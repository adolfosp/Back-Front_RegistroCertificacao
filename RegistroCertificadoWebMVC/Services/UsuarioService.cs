using Microsoft.EntityFrameworkCore;
using RegistroCertificadoWebMVC.Data;
using RegistroCertificadoWebMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroCertificadoWebMVC.Services
{
    public class UsuarioService
    {

        private readonly RegistroCertificadoWebMVCContext _context;
        public UsuarioService(RegistroCertificadoWebMVCContext context)
        {
            _context = context;
        }

        public async Task<List<Usuario>> FindAllAsync()
        {
            List<Usuario> listaDeUsuarios = await _context.Usuario.OrderBy(p => p.Nome).ToListAsync();
            return listaDeUsuarios;

        }

        public async Task CreateUser(Usuario usuario)
        {
            _context.Add(usuario);
            await _context.SaveChangesAsync();
        }
    }
}
