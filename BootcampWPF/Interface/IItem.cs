using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootcampWPF.Interface
{
    interface IItem
    {
        List<Item> Get();
        Item Get(int id);
        bool Insert(Item item);
        bool Update(int id, Item item);
        bool Delete(int id);
    }
}
