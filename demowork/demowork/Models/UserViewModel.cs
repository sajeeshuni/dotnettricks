using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using demowork.Attributes;

namespace demowork.Models
{
    public class UserViewModel
    {
        [DisplayName("Employee Name")]
        [Required(ErrorMessage ="Employee name is required")]
        public string Name  { get; set; }
        
        [DisplayName("User Name")]
        [Required(ErrorMessage ="User name is required")]
        public string Username { get; set; }
        [DisplayName("Password")]
        [Required(ErrorMessage ="Password required")]
        public string Password { get; set; }

        [DisplayName("Confirmation Password")]
        [Required(ErrorMessage = "Confirmation password is required")]
        [Compare("Password",ErrorMessage ="Password and Confirm password must match")]
        public string  ConfirmPassword { get; set; }
        [DisplayName("Contact Number")]
        [RegularExpression("^[6,7,8,9]\\d{10}$",ErrorMessage ="Contact number is not correct")]
        [Required(ErrorMessage ="Contact number required")]
        public string Contact { get; set; }

        
        [DisplayName("City Name")]
        [Required(ErrorMessage ="Select a city name")]
        public int City { get; set; }
        public string Gender { get; set; }
        [ValidateCheckBox(ErrorMessage ="Please accept terms")]
        public bool AcceptTerms { get; set; }

    }
}
