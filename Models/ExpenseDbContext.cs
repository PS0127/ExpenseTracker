using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Expenses.Models
{
    public class ExpenseDbContext:DbContext
    {
        public ExpenseDbContext(DbContextOptions<ExpenseDbContext> options) : base(options) { }

        public DbSet<Expense> Expenses { get; set; }
    }
}
