using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Projekt.Models
{
    public class holdTime
    {
        public int id { get; set; }
        [Display(Name ="Czas realny")]
        public int time_start { get; set; }
        public int time_end { get; set; }
        public int time_diffrence { get; set; }
    }
}
