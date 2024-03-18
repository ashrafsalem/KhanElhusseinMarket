using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Promotion
    {
        public int ID { get; set; }
        // description of the deduction : 1 + 1 (buy 2 get 1 free), 6 with price of 5 (buy 6 get 1 free)
        public string Description { get; set; }
    }
}