using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TrashCollector.Models;

namespace TrashCollector.ViewModels
{
    public class RequestedTrashViewModel
    {
        public Trash Trash { get; set;}
        public List<Customers> Customers = new List<Customers>();
    }
}