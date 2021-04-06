using BillReminder.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BillReminder.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Bill> bills = new List<Bill>();
            bills = _context.Bills.ToList();
            return View(bills);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Bill bill)
        {
            if (ModelState.IsValid)
            {
                _context.Bills.Add(bill);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        private readonly BillsContext _context;

        public HomeController(BillsContext context)
        {
            _context = context;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
