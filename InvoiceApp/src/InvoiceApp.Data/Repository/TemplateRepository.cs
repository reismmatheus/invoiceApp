using InvoiceApp.Data.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceApp.Data.Repository
{
    public class TemplateRepository : ITemplateRepository
    {
        public string GetTemplateByName(string name)
        {
            return @"<!DOCTYPE html>
                <html lang=""en"">
                <head>
                  <meta charset=""UTF-8"">
                  <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
                  <title>Invoice</title>
                  <style>
                    body {
                      font-family: 'Arial', sans-serif;
                      margin: 40px;
                      color: #333;
                      background: #fff;
                    }

                    .invoice-container {
                      max-width: 900px;
                      margin: auto;
                    }

                    /* Header */
                    .header-table {
                      width: 100%;
                      margin-bottom: 30px;
                      border-collapse: collapse;
                    }
                    .header-table td {
                      vertical-align: top;
                      padding: 0;
                    }
                    .company-info h2 {
                      margin: 0;
                      font-size: 18px;
                      font-weight: bold;
                    }
                    .company-info p {
                      margin: 2px 0;
                      font-size: 14px;
                    }
                    .invoice-title {
                      text-align: right;
                    }
                    .invoice-title h1 {
                      margin: 0;
                      font-size: 28px;
                      font-weight: bold;
                      color: #111;
                    }
                    .invoice-title p {
                      margin: 5px 0;
                      font-size: 14px;
                      color: #555;
                    }
                    .balance-due {
                      margin-top: 15px;
                      font-size: 14px;
                      color: #000;
                    }
                    .balance-due strong {
                      font-size: 18px;
                      display: block;
                    }

                    /* Bill To + Invoice Details */
                    .details-table {
                      width: 100%;
                      margin-bottom: 20px;
                      border-collapse: collapse;
                      font-size: 14px;
                    }
                    .details-table td {
                      vertical-align: top;
                      padding: 0;
                    }
                    .bill-to h3 {
                      margin: 0;
                      font-size: 16px;
                      font-weight: bold;
                    }
                    .bill-to p {
                      margin: 2px 0;
                    }
                    .invoice-details {
                      text-align: right;
                    }
                    .invoice-details p {
                      margin: 2px 0;
                    }

                    /* Table */
                    table.items {
                      width: 100%;
                      border-collapse: collapse;
                      margin-bottom: 20px;
                      font-size: 14px;
                    }
                    .items thead th {
                      background: #333;
                      color: #fff;
                      text-align: left;
                      padding: 10px;
                    }
                    .items tbody td {
                      border-bottom: 1px solid #ddd;
                      padding: 10px;
                    }
                    .items tbody tr:last-child td {
                      border-bottom: none;
                    }

                    /* Totals */
                    table.totals {
                      width: 100%;
                      margin-top: 20px;
                      border-collapse: collapse;
                    }
                    .totals td {
                      padding: 6px 10px;
                      font-size: 14px;
                    }
                    .totals td:nth-child(2) {
                      text-align: right;
                    }
                    .totals .total strong {
                      font-size: 16px;
                    }
                    .totals .balance-due {
                      background: #f4f4f4;
                      font-weight: bold;
                      font-size: 16px;
                      padding: 10px;
                    }

                    /* Payment info */
                    .payment-info {
                      margin-top: 40px;
                      font-size: 14px;
                      line-height: 1.6;
                    }
                    .payment-info h4 {
                      margin: 0 0 10px;
                      font-size: 14px;
                      text-transform: uppercase;
                      font-weight: bold;
                      color: #333;
                    }
                    .payment-info p {
                      margin: 2px 0;
                    }

                    .note {
                      margin-top: 20px;
                      font-size: 13px;
                      color: #555;
                    }

                    footer {
                      border-top: 1px solid #ccc;
                      margin-top: 50px;
                      text-align: center;
                      font-size: 14px;
                      color: #555;
                      padding-top: 10px;
                    }
                  </style>
                </head>
                <body>
                  <div class=""invoice-container"">

                    <!-- Header -->
                    <table class=""header-table"">
                      <tr>
                        <td class=""company-info"">
                          <h2>Matheus Matheus Matheus</h2>
                          <p>New South Wales</p>
                          <p>Australia</p>
                          <p>ABN 123123123123</p>
                          <p>reis.mmatheus@gmail.com</p>
                        </td>
                        <td class=""invoice-title"">
                          <h1>INVOICE</h1>
                          <p>IN-MMM-00026</p>
                          <div class=""balance-due"">
                            Balance Due<br>
                            <strong>$33.00</strong>
                          </div>
                        </td>
                      </tr>
                    </table>

                    <!-- Client + Invoice Details -->
                    <table class=""details-table"">
                      <tr>
                        <td class=""bill-to"">
                          <h3>Not Registered</h3>
                          <p>address 1</p>
                          <p>city</p>
                          <p>2000 New South Wales</p>
                          <p>Australia</p>
                        </td>
                        <td class=""invoice-details"">
                          <p><strong>Invoice Date:</strong> 24/08/2025</p>
                          <p><strong>Terms:</strong> Due on Receipt</p>
                          <p><strong>Due Date:</strong> 24/08/2025</p>
                        </td>
                      </tr>
                    </table>

                    <!-- Items -->
                    <table class=""items"">
                      <thead>
                        <tr>
                          <th>#</th>
                          <th>Description</th>
                          <th>Qty</th>
                          <th>Rate</th>
                          <th>Amount</th>
                        </tr>
                      </thead>
                      <tbody>
                        <tr>
                          <td>1</td>
                          <td>01/08 - Sydney</td>
                          <td>1.00</td>
                          <td>33.00</td>
                          <td>33.00</td>
                        </tr>
                      </tbody>
                    </table>

                    <!-- Totals -->
                    <table class=""totals"">
                      <tr>
                        <td>Sub Total</td>
                        <td>33.00</td>
                      </tr>
                      <tr>
                        <td>Default (0%)</td>
                        <td>0.00</td>
                      </tr>
                      <tr class=""total"">
                        <td><strong>Total</strong></td>
                        <td><strong>$33.00</strong></td>
                      </tr>
                      <tr class=""balance-due"">
                        <td>Balance Due</td>
                        <td>$33.00</td>
                      </tr>
                    </table>

                    <!-- Payment Information -->
                    <div class=""payment-info"">
                      <h4>SUPPLY SERVICES</h4>
                      <p>CommBank</p>
                      <p><strong>Account Name:</strong> Matheus Matheus Matheus</p>
                      <p><strong>BSB:</strong> 123123123</p>
                      <p><strong>Account Number:</strong> 123123123</p>
                      <p><strong>PayID:</strong> 1233 123 123</p>
                    </div>

                    <!-- Note -->
                    <div class=""note"">
                      Please make the payment by the due date.
                    </div>

                    <footer>
                      Created with InvoiceApp
                    </footer>

                  </div>
                </body>
                </html>
            ";
        }
    }
}
