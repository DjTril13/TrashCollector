using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TrashCollector.Models;

namespace TrashCollector.ViewModels
{
    public class NewCustomerViewModel
    {
        public IEnumerable<PickupDay> PickupDay { get; set; }
        public Customers Customer { get; set; }
    }
}