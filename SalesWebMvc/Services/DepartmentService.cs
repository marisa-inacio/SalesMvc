using SalesWebMvc.Data;
using SalesWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Services
{
    public class DepartmentService
    {
        //dependencia para o Context
        private readonly SalesWebMvcContext _context;

        //construtor para que a injecao de dependencia ocorra
        public DepartmentService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            //retorna a lista de departamentos orndenada por nome
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
