using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceApp.Domain
{
    public class Item : Entity
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Guid InvoiceId { get; set; }
    }
}
