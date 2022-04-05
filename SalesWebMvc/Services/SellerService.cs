using SalesWebMvc.Data;
using SalesWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Services
{
    public class SellerService
    {

        //dependencia para o Context
        private readonly SalesWebMvcContext _context;

        //construtor para que a injecao de dependencia ocorra
        public SellerService(SalesWebMvcContext context)
        {
            _context = context;
        }

        //retorna uma lista com todos os vendedores da base de dados. coverte para uma lista
        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        } 
    }
}
