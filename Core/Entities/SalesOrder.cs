using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class SalesOrder
    {
        public int ID {get; set;}
        public int UserID {get; set;}
        public string SalesDate {get; set;}
        public string SalesTime {get; set;}
        public float TotalAmount {get; set;}
        public float DeliveryEmpID {get; set;}
    }
}