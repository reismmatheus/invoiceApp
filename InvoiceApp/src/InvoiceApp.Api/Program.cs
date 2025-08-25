using DinkToPdf.Contracts;
using DinkToPdf;
using InvoiceApp.Application.Interface;
using InvoiceApp.Application.Service;
using InvoiceApp.Data.Interface;
using InvoiceApp.Data.Repository;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<IInvoiceService, InvoiceService>();

builder.Services.AddTransient<ITemplateRepository, TemplateRepository>();

builder.Services.AddSingleton(typeof(IConverter), new SynchronizedConverter(new PdfTools()));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
