using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoTempus.Models.ViewModels
{
    public class CartVM
    {
        public IList<Service> ServiceList { get; set; }
        public OrderHeader OrderHeader { get; set; }
    }
}
