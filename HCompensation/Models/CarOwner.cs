using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HCompensation.Models
{
    public class CarOwner
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string OwnershipUrl { get; set; }
        public string PurchaseUrl { get; set; }

    }
}
