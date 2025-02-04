﻿using Microsoft.EntityFrameworkCore;

namespace Expense_Tracker.Models
{
    public class ApplicationDbContext:DbContext
    {
      public ApplicationDbContext(DbContextOptions options) : base(options)
        {}
        
        public DbSet<Transactions> Transactions { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
 