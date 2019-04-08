using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootcampWPF
{
    class Supplier : BaseModel
    {
        public string Name { get; set; }
        public bool isDelete { get; set; }
        public ICollection<Item> Items { get; set; }
    }
}
