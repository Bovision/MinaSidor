using Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol;

namespace MinaSidor.Server.Controllers
    {
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
        {
        private readonly ApplicationDbContext _context;

        public ValuesController(ApplicationDbContext applicationDbContext)
            {
            _context = applicationDbContext;
            }
        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<string> GetCustomernotes()
            {
            var test = _context.Customernotes.Where(x => x.Customerid == 34).ToList();
            yield return test.ToJson();
            }
        [HttpGet("GetCustomer")]
        public IEnumerable<string> GetCustomer()
            {
            var test = _context.Customers
                .Include(customer => customer.Invoices).Where(x => x.Id == 34).ToList();
            yield return test.ToJson();
            }
        [HttpGet("GetInvoices")]
        public IEnumerable<string> GetInvoices()
            {
            var test = _context.Invoices.Where(x => x.Id == 34).ToList();
            yield return test.ToJson();
            }
        [HttpGet("GetInvoicematerials")]
        public IEnumerable<string> GetInvoicematerials()
            {
            var test = _context.Invoicematerials.Where(x => x.Id == 34).ToList();
            yield return test.ToJson();
            }
        [HttpGet("GetInvoicerows")]
        public IEnumerable<string> GetInvoicerows()
            {
            var test = _context.Invoicerows.Where(x => x.Id == 34).ToList();
            yield return test.ToJson();
            }
        [HttpGet("GetProducts")]
        public IEnumerable<string> GetProducts()
            {
            var test = _context.Products.ToList();
            yield return test.ToJson();
            }
        [HttpGet("GetProductPrices")]
        public IEnumerable<string> GetProductPrices()
            {
            var test = _context.ProductPrices.ToList();
            yield return test.ToJson();
            }
        }
    }
