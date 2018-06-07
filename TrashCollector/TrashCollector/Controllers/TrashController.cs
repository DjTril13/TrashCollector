using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrashCollector.Models;
using TrashCollector.ViewModels;


namespace TrashCollector.Controllers
{
    public class TrashController : Controller
    {
        // GET: Trash
        public ActionResult Requests()
        {
            var trash = new Trash() { Name = "Trash Pickups" };
            var customers = new List<Customers>
            {
                new Customers { Name = "Dominic" },
                new Customers { Name = "Chris" }
            };

            var viewModel = new RequestedTrashViewModel
            {
                Trash = trash,
                Customers = customers

            };

            return View(viewModel);
        }
    }
}