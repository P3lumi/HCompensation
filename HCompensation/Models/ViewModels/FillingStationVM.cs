using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HCompensation.Models.ViewModels
{
    public class FillingStationVM
    {
        [Required, DisplayName("Business Name")]
        public string BusinessName { get; set; }
        [DisplayName("Email Address"), Required]
        public string Email { get; set; }
        [Required]
        public string Location { get; set; }
        [Required, DisplayName("Ticket")]
        public IFormFile OwnerShipDocument { get; set; }
        [Required, DisplayName("Additional Details")]
        public string LastSupplyDetails { get; set; }
    }
}
