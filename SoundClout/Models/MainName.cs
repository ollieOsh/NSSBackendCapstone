using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SoundClout.Models
{
    public class MainName
    {
        [Required]
        public string Word { get; set; }

        [Required]
        public DayOfWeek Weekday { get; set; }

        [Required]
        public int NumerologyInt { get; set; }

        [Required]
        public int SyllableCount { get; set; }

    }
}
