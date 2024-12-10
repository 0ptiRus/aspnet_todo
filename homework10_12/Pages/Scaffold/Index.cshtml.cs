using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using homework10_12.Data;
using homework10_12.Models;

namespace homework10_12.Pages.Scaffold
{
    public class IndexModel : PageModel
    {
        private readonly homework10_12.Data.TodoContext _context;

        public IndexModel(homework10_12.Data.TodoContext context)
        {
            _context = context;
        }

        public IList<Todo> Todo { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Todo = await _context.Todo.ToListAsync();
        }
    }
}
