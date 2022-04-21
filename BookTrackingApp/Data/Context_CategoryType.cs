using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BookTrackingApp.Models;

    public class Context_CategoryType : DbContext
    {
        public Context_CategoryType (DbContextOptions<Context_CategoryType> options)
            : base(options)
        {
        }

        public DbSet<BookTrackingApp.Models.CategoryType> CategoryType { get; set; }
    }
