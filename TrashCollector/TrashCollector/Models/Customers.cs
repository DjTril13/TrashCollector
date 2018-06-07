using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrashCollector.Models
{
    public class Customers
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //address

        public PickupDay PickupDay { get; set; }    //this is the literal object off Pickupday, being the day/price 
        public int PickupDayId { get; set; }        //this is just a key to the type of PickupDay on the table


    }
}