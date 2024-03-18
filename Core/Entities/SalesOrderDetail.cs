using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class SalesOrderDetail
    {
        public int ID { get; set; }
        public int SalesOrderID { get; set; }
        public string ItemName { get; set; }
        public string ItemBarcode { get; set; }
        public float Qty { get; set; }
        public float SalePrice { get; set; }
        public float Total { get; set; }
        // in case of pormotion exsit
        public float LineDeduction { get; set; }
        //in case of promotion show running promotion ID
        public int PromotID { get; set; }
    }
}