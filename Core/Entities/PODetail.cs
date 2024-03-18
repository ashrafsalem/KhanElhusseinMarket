using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class PODetail
    {
        public int ID {get; set;}
        public int POID {get; set;}
        public string ItemBarcode {get; set;}
        public string ItemName {get; set;}
        public float Qty {get; set;}
    }
}