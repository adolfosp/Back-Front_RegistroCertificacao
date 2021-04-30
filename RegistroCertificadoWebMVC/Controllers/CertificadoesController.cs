using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RegistroCertificadoWebMVC.Data;
using RegistroCertificadoWebMVC.Models;

namespace RegistroCertificadoWebMVC.Controllers
{
    public class CertificadoesController : Controller
    {
        private readonly RegistroCertificadoWebMVCContext _context;


        public CertificadoesController(RegistroCertificadoWebMVCContext context)
        {
            _context = context;
        }

        // GET: Certificadoes
        public async Task<IActionResult> Index()
        {
            return View();
        }

      
    }
}
