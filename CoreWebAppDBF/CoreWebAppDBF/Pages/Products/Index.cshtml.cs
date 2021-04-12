using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CoreWebAppDBF.Models;

namespace CoreWebAppDBF.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly CoreWebAppDBF.Models.MyDBContext _context;

        public IndexModel(CoreWebAppDBF.Models.MyDBContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; }

        public async Task OnGetAsync()
        {
            Product = await _context.Products.ToListAsync();
        }
    }
}
