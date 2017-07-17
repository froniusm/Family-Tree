using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FamilyTree.Models;

namespace FamilyTree.DAL
{
    public interface IPersonDAL
    {
        void SavePerson(Person person);
    }
}
