using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrashCollector.Models;
using TrashCollector.ViewModels;

namespace TrashCollector.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;


        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult New()
        {
            var pickupDay = _context.PickupDay.ToList();
            var viewModel = new NewCustomerViewModel
            {
                PickupDay = pickupDay
            };

            return View(viewModel);
        }
        public ViewResult Index()
        {
            var customers = _context.Customers.ToList();
            return View(customers);

        }

        public ActionResult Details(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);
            if (customer == null)
                return HttpNotFound();

            return View(customer); 
        }

  
        
    }
}