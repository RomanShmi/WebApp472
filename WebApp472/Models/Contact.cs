using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApp472.Models
{
    public class Contact
    {   [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "firstname is required")]
        [StringLength(WebConstant.MAX_FIRST_NAME_LENGTH)]
        public string FirstName { get; set; }


        [Required(ErrorMessage = "secondname is required")]
        [StringLength(WebConstant.MAX_LAST_NAME_LENGTH)]

        public string SecondName { get; set; }



        [Required(ErrorMessage = "email is required")]
        [EmailAddress(ErrorMessage ="email is required")]
        public string Email { get; set; }



        [Required]
        [StringLength(WebConstant.MAX_PHONE_LENGTH)]
        public string PrimaryPhone { get; set; }


        [Required]
        [StringLength(WebConstant.MAX_PHONE_LENGTH)]
        public string SecondaryPhone { get; set; }

        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }

        public string Address1 { get; set; }
        public string address2 { get; set; }

        [Required(ErrorMessage = "city is required")]
        [StringLength(WebConstant.MAX_CITY_LENGTH)]
        public string City { get; set; }

        [Required(ErrorMessage = "zip code is required")]
        [Display(Name ="Zip Code")]
        [StringLength(WebConstant.MAX_ZIP_CODE_LENGTH, MinimumLength =WebConstant.MIN_ZIP_CODE_LENGTH)]

        public string Zip { get; set; }
        [Required(ErrorMessage = "state code is required")]
        public virtual State State { get; set; }
        public int StateId { get; set; }
        [Required]
        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }

        [Display(Name ="full name")]
        public string FriendlyName => $"{FirstName} {SecondName}";
    }
}