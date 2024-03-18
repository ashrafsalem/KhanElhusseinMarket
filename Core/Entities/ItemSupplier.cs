using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class ItemSupplier
    {
        public int ID {get; set;}
        public int SupplierID {get; set;}
        //to fix search with barcoe starts with 0
        public string ItemBarcode {get; set;}
        public float CostPrice {get; set;}
        public float SalePrice {get; set;}
    }
}