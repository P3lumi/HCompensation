using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HCompensation.Models.ViewModels
{
    public class CarOwnerVM
    {
        [Required, DisplayName("Full Name")]
        public string FullName { get; set; }
        [DisplayName("Email Address"), Required]
        public string Email { get; set; }
        [Required, DisplayName("Car Documents (PDF)")]
        public IFormFile CarDocument { get; set; }
        [Required, DisplayName("Purchase Receipt")]
        public IFormFile PurchaseReceipt { get; set; }
        [Required, DisplayName("Additional Details")]
        public string LastSupplyDetails { get; set; }
    }
}
