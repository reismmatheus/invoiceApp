using InvoiceApp.Application.Interface;
using InvoiceApp.CrossCutting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceApp.Application.Service
{
    public class InvoiceService : IInvoiceInterface
    {
        public InvoiceService()
        {
            
        }

        public void GenerateInvoice()
        {
            var pdfFIle = new PdfFile();

            var html = "";

            var invoice = pdfFIle.GeneratePdf(html);
        }
    }
}
