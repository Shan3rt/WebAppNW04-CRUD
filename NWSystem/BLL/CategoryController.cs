using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NWSystem.DAL;
using NWSystem.ENTITIES;

namespace NWSystem.BLL
{
    public class CategoryController
    {
        public List<Category> Categories_List()
        {
            using (var context = new NWContext())
            {
                return context.Categories.ToList();
            }
        }
    }
}
