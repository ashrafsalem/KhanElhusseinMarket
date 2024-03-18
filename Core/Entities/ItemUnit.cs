using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class ItemUnit
    {
        public int ID { get; set; }
        public int ItemID { get; set; }
        public int UnitID { get; set; }
        public int SmallUnitID { get; set; }
        public float SmallUnitAmount { get; set; }
    }
}