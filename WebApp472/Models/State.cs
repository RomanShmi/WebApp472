using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApp472.Models
{
    public class State
    {
        [Key]
        public int Id { get; set; }
        
        [Display(Name="State")]
        [Required(ErrorMessage = "state name is required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "state abbreviation is required")]
        public string Abbreviation { get; set; }
    }
}