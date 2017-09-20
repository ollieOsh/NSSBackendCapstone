using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SoundClout.Models
{
    public class MainName
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Word { get; set; }

        [Required]
        public int SyllableCount { get; set; }

        [Required]
        public string Weekday { get; set; }

        [Required]
        public int NumerologyInt { get; set; }

        [Required]
        public int PrefixInt { get; set; }

        [Required]
        public int OrderInt { get; set; }

    }
}
