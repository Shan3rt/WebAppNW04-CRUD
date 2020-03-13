using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NWSystem.DAL;
using NWSystem.ENTITIES;

namespace NWSystem.BLL
{
    public class SupplierController
    {
        public List<Supplier> Supplier_List()
        {
            using (var context = new NWContext())
            {
                return context.Suppliers.ToList();
            }
        }

        public Supplier Supplier_Get(int supplierid)
        {
            using (var context = new NWContext())
            {
                return context.Suppliers.Find(supplierid);
            }
        }
    }
}
