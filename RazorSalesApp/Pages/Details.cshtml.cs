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
    public class DetailsModel : PageModel
    {
        private readonly RazorSalesApp.Context.SalesDbContext _context;

        public DetailsModel(RazorSalesApp.Context.SalesDbContext context)
        {
            _context = context;
        }

        public Sales Sales { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sales = await _context.Sales.FirstOrDefaultAsync(m => m.Id == id);
            if (sales == null)
            {
                return NotFound();
            }
            else
            {
                Sales = sales;
            }
            return Page();
        }
    }
}
