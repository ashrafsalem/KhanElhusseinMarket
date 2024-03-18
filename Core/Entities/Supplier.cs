using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Supplier
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string ContactsInfo { get; set; }
        public string RegNumber { get; set; }
        public bool IsActive { get; set; }
    }
}