using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FamilyTree.Models
{
    public class RelationshipCategory
    {
        public int TypeId { get; set; }
        public string RelationshipType { get; set; }
    }
}