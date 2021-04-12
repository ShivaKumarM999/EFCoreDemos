using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CoreWebAppCodeFirst.Models;

namespace CoreWebAppCodeFirst.Pages.CustomersPages
{
    public class IndexModel : PageModel
    {
        private readonly CoreWebAppCodeFirst.Models.MyDBContext _context;

        public IndexModel(CoreWebAppCodeFirst.Models.MyDBContext context)
        {
            _context = context;
        }

        public IList<Customer> Customer { get;set; }

        public async Task OnGetAsync()
        {
            Customer = await _context.Customers.ToListAsync();
        }
    }
}
