using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrashCollector.Models
{
    public class PickupDay
    {
        public int Id { get; set; }
        public string Day { get; set; }
        public double Fee { get; set; }
        

        //would go back and have fee change with day

    }
}