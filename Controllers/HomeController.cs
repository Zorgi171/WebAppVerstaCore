using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebAppVerstaCore.Models;

namespace WebAppVerstaCore.Controllers
{
    public class HomeController : Controller
    {
        OrderContext db;

        public HomeController(OrderContext context)
        {
            db = context;
        }
        public IActionResult NewOrder()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ListOrders()
        {
            return View(db.Orders);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Order order)
        {
            if (ModelState.IsValid)
            {
                db.Orders.Add(order);
                db.SaveChanges();
                return RedirectToAction("ListOrders");
            }
            else return View(order);
            


        }
    }
}
