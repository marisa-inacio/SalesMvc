﻿
using System.Collections.Generic;


namespace SalesWebMvc.Models
{
    //tela de registo de vendedor
    public class SellerFormViewModel
    {
        public Seller Seller { get; set; }
        public ICollection<Department> Departments { get; set; }
    }
}
