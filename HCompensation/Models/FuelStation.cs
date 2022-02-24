using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HCompensation.Models
{
    public class FuelStation
    {
        public int Id { get; set; }
        public string BusinessName { get; set; }
        public string Email { get; set; }
        public string TicketUrl { get; set; }
        public string LastSupplyDetails { get; set; }
        public string Location { get; set; }
    }
}
