using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Vehicles.API.Data.Entities
{
    public class Brands
    {
        public int Id { get; set; }

        [Display(Name = "Brand")]
        [MaxLength(50, ErrorMessage = "Maximum amount of characters for {0} is {1}")]
        [Required(ErrorMessage = "You must fill the {0} field")]
        public string Description { get; set; }
    }
}

