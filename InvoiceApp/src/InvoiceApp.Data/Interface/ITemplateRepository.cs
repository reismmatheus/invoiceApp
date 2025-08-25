using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceApp.Data.Interface
{
    public interface ITemplateRepository
    {
        string GetTemplateByName(string name);
    }
}
