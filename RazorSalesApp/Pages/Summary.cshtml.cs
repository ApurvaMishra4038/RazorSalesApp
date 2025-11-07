using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorSalesApp.Context;
using RazorSalesApp.Model; // Update this if your namespace differs
using System.Linq;

namespace RazorSalesApp.Pages
{
    public class SummaryModel : PageModel
    {
        private readonly SalesDbContext _context;

        public SummaryModel(SalesDbContext context)
        {
            _context = context;
        }

        public decimal TotalSales { get; set; }
        public int TotalItemsSold { get; set; }

        public void OnGet()
        {
            TotalSales = _context.Sales.Sum(s => s.Price * s.Quantity);
            TotalItemsSold = _context.Sales.Sum(s => s.Quantity);
        }
    }
}
