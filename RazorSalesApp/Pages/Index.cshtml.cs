using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorSalesApp.Context;
using RazorSalesApp.Model;

namespace RazorSalesApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly RazorSalesApp.Context.SalesDbContext _context;

        public IndexModel(RazorSalesApp.Context.SalesDbContext context)
        {
            _context = context;
        }

        public IList<Sales> Sales { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Sales = await _context.Sales.ToListAsync();
        }
    }
}
