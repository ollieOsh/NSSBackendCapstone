using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SoundClout.ViewModels
{
    public class Form
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public DateTime DOB { get; set; }

        public int Numerology { get; set; }

        public string Day { get; set; }

        public string Prefix { get;set; }

        public string Clout { get; set; }
    }
}
