using Expenses.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

namespace Expenses.Controllers
{
    public class DashboardController : Controller
    {

        private readonly ExpenseDbContext _context;

        public DashboardController(ExpenseDbContext context)
        {
            _context = context;
        }

        public async Task<ActionResult> Index()
        {

            ViewBag.RecentExpenses = await _context.Expenses.OrderByDescending(x => x.ExpenseDate).Take(10).ToListAsync();
            ViewBag.chartExpenses = await _context.Expenses.GroupBy(g => g.ExpenseCategory).Select(a => new
            {
                amount = a.Sum(g => g.ExpenseAmount),
                category = a.First().ExpenseCategory,
                formattedAmount = String.Format("{0:C}", a.Sum(g => g.ExpenseAmount))
            }).ToListAsync();


            return View();
        }
    }
}
