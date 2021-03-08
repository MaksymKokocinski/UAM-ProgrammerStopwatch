using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Projekt.Models
{
    public class Tasks
    {
        
        public int id { get; set; }
        [StringLength(50, ErrorMessage = "Pole {0} musi posiadać nie więcej niż 50 znaków.")]
        [Required(ErrorMessage = "Pole {0} jest wymagane.")]
        [Display(Name = "Nazwa zadania")]
        public string name { get; set; }
        [Range(1, 100000, ErrorMessage = "Pole {0} musi być liczbą z przedziału od 1 do 100000.")]
        [Required(ErrorMessage = "Pole {0} jest wymagane.")]
        [Display(Name = "Czas ustalony")]
        public int time_admin { get; set; }
        [Display(Name = "Czas realny")]
        public int time_user { get; set; }
        [Display(Name = "Różnica")]
        public int diffrence { get; set; }
        public bool stan { get; set; }
        public int id_holdTime { get; set; }
        public int id_usera { get; set; }
    }
}
