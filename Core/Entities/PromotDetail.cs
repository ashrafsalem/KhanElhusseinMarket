using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class PromotDetail
    {
        public int ID{get; set;}
        public string ItemBarcode{get; set;}

        // in case of direct deduction

        public float DeductionPrice {get; set;}
        //_____________________________________
        // in case of amount deduction
        public float SalesAmount{get; set;}
        public float DeductionAmount{get; set;}
        //_______________________________________
        public bool IsActive{get; set;}
    }
}