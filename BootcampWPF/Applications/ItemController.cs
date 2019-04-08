using BootcampWPF.Core;
using BootcampWPF.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BootcampWPF.Applications
{
    class ItemController : IItem
    {
        static MyContext myContext = new MyContext();
        SaveChange go = new SaveChange(myContext);
        bool status = false;

        ISupplier iSupplier = new SupplierController();

        public List<Item> Get()
        {
            var get = myContext.Items.Include("Suppliers").Where(x => x.isDelete == false).ToList();
            return get;
        }

        public Item Get(int id)
        {
            var get = myContext.Items.Find(id);
            return get;
        }

        public bool Insert(Item item)
        {
            //myContext.Suppliers.Attach(item.Suppliers);
            myContext.Items.Add(item);
            //myContext.Entry(item.Suppliers).State = EntityState.Unchanged;
            
            return go.saved();
        }


        public bool Update(int id, Item item)
        {
            if (Get(id) != null)
            {
                Get(id).Name = item.Name;
                Get(id).Stock = item.Stock;
                Get(id).Price = item.Price;
                Get(id).Suppliers = item.Suppliers;
                myContext.Entry(Get(id)).State = EntityState.Modified;
                status = go.saved();
            }
            else
            {
                MessageBox.Show("Cant Find The ID.");
            }
            return status;
        }

        public bool Delete(int id)
        {
            Get(id).isDelete = true;
            myContext.Entry(Get(id)).State = EntityState.Modified;
            status = go.saved();
            
            return status;
        }
    }
}
