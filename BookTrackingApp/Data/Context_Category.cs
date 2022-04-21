using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BookTrackingApp.Models;

    public class Context_Category : DbContext
    {
        public Context_Category (DbContextOptions<Context_Category> options)
            : base(options)
        {
        }

        public DbSet<BookTrackingApp.Models.Category> Category { get; set; }
    }
