using InvoiceApp.Application.Interface;
using InvoiceApp.CrossCutting.Extension;
using InvoiceApp.Data.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceApp.Application.Service
{
    public class InvoiceService : IInvoiceService
    {
        private readonly ITemplateRepository _templateRepository;
        public InvoiceService(ITemplateRepository templateRepository)
        {
            _templateRepository = templateRepository;
        }
        public void Generate()
        {
            var html = _templateRepository.GetTemplateByName("test");

            var file = new PdfExtention().GenerateFromHtml(html);
            //get personal info
            //get costumer
            //get info
            //generate html and pdf
        }
    }
}
