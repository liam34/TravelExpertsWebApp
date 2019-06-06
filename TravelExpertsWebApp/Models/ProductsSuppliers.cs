using System;
using System.Collections.Generic;

namespace TravelExpertsWebApp.Models
{
    public partial class ProductsSuppliers
    {
        public int ProductSupplierId { get; set; }
        public int? ProductId { get; set; }
        public int? SupplierId { get; set; }
    }
}
