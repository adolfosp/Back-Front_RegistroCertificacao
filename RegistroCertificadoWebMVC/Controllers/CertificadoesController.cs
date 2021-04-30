using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RegistroCertificadoWebMVC.Data;
using RegistroCertificadoWebMVC.Models;
using RegistroCertificadoWebMVC.Models.Enums;
using RegistroCertificadoWebMVC.Services;

namespace RegistroCertificadoWebMVC.Controllers
{
    public class CertificadoesController : Controller
    {
        private readonly InstituicaoService _instituicaoService;
        private readonly CertificadoService _certificadoService;


        public CertificadoesController( InstituicaoService instituicaoService, CertificadoService certificadoService)
        {
            _instituicaoService = instituicaoService;
            _certificadoService = certificadoService;
        }

        // GET: Certificadoes
        public async Task<IActionResult> Index()
        {
            List<Certificado> list = await _certificadoService.FindAllAsync();

            return View(list);
        }

       
        public async Task<IActionResult> Create()
        {
            var listEnum = Enum.GetNames(typeof(AreaCertificado));
            var instituicaos = await _instituicaoService.FindAllAsync();
            var viewModel = new CertificadoFormViewModel { Instituicaos = instituicaos, AreaCertificados =  listEnum};
            return View(viewModel);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Certificado certificado)
        {
            //if (!ModelState.IsValid)
            //{
            //    var departments = await _departmentService.FindAllAsync();
            //    var viewModel = new SellerFormViewModel { Seller = seller, Departments = departments };
            //    return View(viewModel);
            //}
            await _certificadoService.InsertAsync(certificado);
            return RedirectToAction(nameof(Index));
        }

    }
}
