using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Core.Entities
{
    public class DeliveryEmp
    {
        public int ID {get; set;}
        public string Name {get; set;}
        public string Phone {get; set;}
        public string Img {get; set;}
        public bool IsActive {get; set;}
    }
}