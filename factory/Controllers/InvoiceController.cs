using Microsoft.AspNetCore.Mvc;
using Models;
using Factory;
namespace teste_factory.Controllers;

[ApiController]
[Route("[controller]")]
public class InvoiceController : ControllerBase
{
    [HttpGet]
    [Route("Invoice/{invoiceNumber}/Type/{invoiceCode}")]
    public Invoice getInvoice([FromRoute] string invoiceNumber, int invoiceCode){
        return new InvoiceFactory().createInvoice(invoiceNumber, invoiceCode);
    }
    
    [HttpGet]
    [Route("Invoice/{invoiceNumber}/Type/{invoiceCode}/Costs")]
    public string getInvoiceCosts([FromRoute] string invoiceNumber, int invoiceCode){
        return new InvoiceFactory().createInvoice(invoiceNumber, invoiceCode).ListCosts();
    }
}
