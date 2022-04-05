using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;
using SalesWebMvc.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Controllers
{
    public class SellersController : Controller
    {
        private readonly SellerService _sellerService;
        private readonly DepartmentService _departmentService;

        public SellersController(SellerService sellerService, DepartmentService departmentService)
        {
            _sellerService = sellerService;
            _departmentService = departmentService;
        }
        public IActionResult Index()
        {
            //chamamos o controlador (index) - o controlador acessou o model e encaminha a list para a view. retorna uma lista de seller
            var list = _sellerService.FindAll();
            return View(list);
        }

        public IActionResult Create()
        {
            // quando a tela de registo for acionada pela primeira vez ja vai receber os departamentos 
            var departments = _departmentService.FindAll();
            var viewModel = new SellerFormViewModel { Departments = departments };
            return View(viewModel);
        }

        //indicar que é post 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Seller seller)
        {
            _sellerService.Insert(seller);

            //redirecionar para o index
            return RedirectToAction(nameof(Index));
        }
    }
}
