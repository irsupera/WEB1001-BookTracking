using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BookTrackingApp.Models;
using Schema.NET;

namespace BookTrackingApp.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly Context_Book _context;

        public Thing JSONLD { get; set; } = new Thing();

        public IndexModel(Context_Book context)
        {
            _context = context;
        }

        public IList<Models.Book> Book { get; set; }

        public async Task OnGetAsync()
        {
            Book = await _context.Book
                .Include(b => b.Category).ToListAsync();

            Schema.NET.Book book = new Schema.NET.Book();

            book.About = new OneOrMany<IThing>(new List<Thing>() { new Thing() { Name = "Test Book" } });
            book.Name = @"Test Book";

            JSONLD = book;
        }

    }
}
