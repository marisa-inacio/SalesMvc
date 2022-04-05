using Microsoft.AspNetCore.Mvc;
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

        public SellersController(SellerService sellerService)
        {
            _sellerService = sellerService;
        }
        public IActionResult Index()
        {
            //chamamos o controlador (index) - o controlador acessou o model e encaminha a list para a view. retorna uma lista de seller
            var list = _sellerService.FindAll();
            return View(list);
        }
    }
}
