using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SoundClout.ViewModels
{
    public class Form
    {
        [Required(ErrorMessage = "Please Enter a First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please Enter a First Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please Enter a Valid Date of Birth")]
        public DateTime DOB { get; set; }

        public string Prefix { get;set; }

        public string Clout { get; set; }
    }
}
