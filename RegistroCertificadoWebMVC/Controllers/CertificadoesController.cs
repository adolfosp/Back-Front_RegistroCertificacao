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
        private readonly AreaCertificadoService _areaCertificadoService;

        public CertificadoesController( InstituicaoService instituicaoService, CertificadoService certificadoService,AreaCertificadoService areaCertificadoService)
        {
            _instituicaoService = instituicaoService;
            _certificadoService = certificadoService;
            _areaCertificadoService = areaCertificadoService;
        }

        // GET: Certificadoes
        public async Task<IActionResult> Index()
        {
            List<Certificado> list = await _certificadoService.FindAllAsync();

            return View(list);
        }

       
        public async Task<IActionResult> Create()
        {
            var listEnum = _areaCertificadoService.RetornarEnum();
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
        public async Task<IActionResult> Edit(int? id)
        {
            //if (id == null)
            //{
            //    return RedirectToAction(nameof(Error), new { message = "Id not provided" });
            //}

            var obj = await _certificadoService.FindByIdAsync(id.Value);

            //if (obj == null)
            //{
            //    return RedirectToAction(nameof(Error), new { message = "Id not Found" });
            //}
            List<Instituicao> instituicaos = await _instituicaoService.FindAllAsync();
            var listEnum = _areaCertificadoService.RetornarEnum();

            CertificadoFormViewModel viewModel = new CertificadoFormViewModel { Certificado = obj, Instituicaos = instituicaos, AreaCertificados = listEnum};
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Certificado certificado)

        {
            Console.WriteLine(certificado);
            Console.WriteLine(id);
            //if (!ModelState.IsValid)
            //{
            //    var departments = await _departmentService.FindAllAsync();
            //    var viewModel = new SellerFormViewModel { Seller = obj, Departments = departments };
            //    return View(viewModel);
            //}

            //if (id != obj.Id)
            //{
            //    return RedirectToAction(nameof(Error), new { message = "Id mismatch" });
            //}
            try
            {
                await _certificadoService.UpdateAsync(certificado);
                return RedirectToAction(nameof(Index));
            }
            catch (ApplicationException e)
            {
                //return RedirectToAction(nameof(Error), new { message = e.Message });
                throw new Exception("Não foi possível atualizar o registro: " + e.Message);

            }

        }

        public async Task<IActionResult> Delete(int? id)
        {
          

            Certificado certificado = await _certificadoService.FindByIdAsync(id.Value);
           
            return View(certificado);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await _certificadoService.RemoveAsync(id);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                throw new Exception("Não foi possível remover o registro: " + e.Message);
            }

        }


        public async Task<IActionResult> Details(int id)
        {
           var detalheCertificadoRetornado = await _certificadoService.FindByIdAsync(id);
           return View(detalheCertificadoRetornado);
        }
    }
}
