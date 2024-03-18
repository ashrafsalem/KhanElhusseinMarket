using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class ItemCatalog
    {
        // for sections or product tree
        // if is parent is true, it could has childs or just a head section
        // if parent id == parent --> head section , 
        //      if parent id is differ from ID it's sub section from parent id 
        public int ID {get; set;}

        public string Name{get; set;}

        public string Img {get; set;}

        // true by default , if false all section with it's items is diactivated
        public bool IsActive{get; set;}

        public bool IsParent {get; set;}

        public int ParentID{get; set;}

    }
}