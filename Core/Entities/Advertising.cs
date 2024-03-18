using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Advertising
    {
        public int ID{get; set;}
        public string Description {get; set;}
        public string Area {get; set;}
        public string Img {get; set;}
        public string StartDateTime {get; set;}
        public string EndDateTime {get; set;}
        public bool IsActive{get; set;}
    }
}