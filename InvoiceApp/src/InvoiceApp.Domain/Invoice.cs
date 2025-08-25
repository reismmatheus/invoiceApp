using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceApp.Domain
{
    public class Invoice : Entity
    {
        public string Number { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal Total { get; set; }
        public string Description { get; set; }
        public Guid CustomerId { get; set; }
        public Guid BusinessId { get; set; }
        public List<Guid> ListItemId { get; set; }

    }
}
