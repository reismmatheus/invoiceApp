using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceApp.Domain
{
    public class Business : Entity
    {
        public string Name { get; set; }
        public string Abn { get; set; }
    }
}
