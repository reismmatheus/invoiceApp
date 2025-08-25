using InvoiceApp.Application.Interface;
using InvoiceApp.Application.Service;
using Microsoft.AspNetCore.Mvc;

namespace InvoiceApp.Api.Controllers
{
    public class InvoiceController : Controller
    {
        private readonly IInvoiceService _invoiceService;
        public InvoiceController(IInvoiceService invoiceService)
        {
            _invoiceService = invoiceService;
        }
        [HttpPost("Generate")]
        public async Task<IActionResult> Generate()
        {
            _invoiceService.Generate();
            return Ok();
        }
    }
}
