using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FamilyTree.Models
{
    public class Relationship
    {
        public int FromId { get; set; }
        public int ToId { get; set; }
        public int TypeId { get; set; }
    }
}