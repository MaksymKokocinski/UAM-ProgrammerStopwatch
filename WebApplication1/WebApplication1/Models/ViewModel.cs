using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt.Models
{
    public class ViewModel
    {
        public int tasks_id { get; set; }
        public string tasks_name { get; set; }
        public int tasks_time_admin { get; set; }
        public int tasks_time_user { get; set; }
        public int tasks_diffrence { get; set; }
        public bool tasks_stan { get; set; }
        public int tasks_id_holdTime { get; set; }
        public int holdTime_id { get; set; }
        public int holdTime_czas_start { get; set; }
        public int holdTime_czas_end { get; set; }

    }
}
