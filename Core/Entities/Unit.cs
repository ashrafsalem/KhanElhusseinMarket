using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Unit
    {
        // ID
        public int ID {get; set;}
        // unit name: Piece , K*12 , k*8
        public string Name {get; set;}
        //unit measure depend on the name: 1 or 12 or 8
        public string Units {get; set;}
    }
}