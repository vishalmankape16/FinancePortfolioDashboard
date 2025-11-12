using Microsoft.AspNetCore.Mvc;
using FinancePortfolioDashboard.Models;
using System.Collections.Generic;

namespace FinancePortfolioDashboard.Controllers
{
    public class PortfoliosController : Controller
    {
        // For demo: in-memory storage
        private static List<Portfolio> portfolios = new List<Portfolio>();

        // GET: /Portfolios
        public IActionResult Index()
        {
            return View(portfolios);
        }

        // GET: /Portfolios/Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // POST: /Portfolios/Create
        [HttpPost]
        public IActionResult Create(Portfolio model)
        {
            if (ModelState.IsValid)
            {
                portfolios.Add(model); // Replace with DB logic if needed
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}
