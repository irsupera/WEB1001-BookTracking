using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BookTrackingApp.Models;

    public class Context_Book : DbContext
    {
        public Context_Book (DbContextOptions<Context_Book> options)
            : base(options)
        {
        }

        public DbSet<BookTrackingApp.Models.Book> Book { get; set; }
    }
