using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class DeliveryEvaluate
    {
        public int ID { get; set; }
        public int SalesOrderID { get; set; }
        public int DeliveryEmpID { get; set; }
        public int UserID { get; set; }
        public string Evaluate { get; set; }
        public string EvaluateDate { get; set; }
        // in case of customer service response for the bad review or even the good one
        public string CSResponse { get; set; }
        public string CSResponseDate { get; set; }
    }
}