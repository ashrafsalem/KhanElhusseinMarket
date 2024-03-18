using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class User
    {
        public int ID {get; set;}
        public string Name {get; set;}
        public string Address {get; set;}
        public string Phones {get; set;}
        public string Whatsapp {get; set;}
        public bool IsActive {get; set;}
    }
}