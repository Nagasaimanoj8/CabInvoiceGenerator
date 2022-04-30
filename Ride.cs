using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    public class Ride
    {
        // Declaring attributes 
        public double distance;
        public int time;
        // Parameterised Constructor to initialise the instance of the ride class summary
        public Ride(double distance, int time)
        {
            this.distance = distance;
            this.time = time;
        }
    }
}
