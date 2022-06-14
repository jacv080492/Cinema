using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Models
{
    public class CinemaFunction
    {
        public int IdMovieSchedule { get; set; }
        public int IdTheather { get; set; }
        public Theater? Theater { get; set; }
        public int IdMovie { get; set; }
        public Movie? Movie { get; set; }
        public int IdRoom { get; set; }
        public Room? Room { get; set; }
        public DateTime Schedule { get; set; }
        public bool IsPremiere { get; set; }
    }
}
