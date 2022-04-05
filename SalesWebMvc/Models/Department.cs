using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //implementa a associacao do departament com o seller
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();


        public Department()
        {

        }

        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void AddSeller (Seller seller)
        {
            Sellers.Add(seller);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            //calcular o total de vendas do departamento para o intervalo de datas. ver todos os vendedores do dpt e somar o total das suas vendas nesse periodo
            //cada vendedor - chama o total de vendas daquele periodo e soma
            return Sellers.Sum(seller => seller.TotalSales(initial, final));
        }
    }
}
