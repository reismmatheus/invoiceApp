using PdfSharp;
using PdfSharp.Pdf;
using System.Net.Http;
using TheArtOfDev.HtmlRenderer.PdfSharp;

namespace InvoiceApp.CrossCutting
{
    public class PdfFile
    {
        public byte[] GeneratePdf(string html)
        {
            using (var stream = new MemoryStream())
            {
                var pdf = PdfGenerator.GeneratePdf(html, PageSize.A4);
                pdf.Save(stream, false);
                return stream.ToArray();
            }
        }
    }
}
