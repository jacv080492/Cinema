using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Models
{
    public class Moviesboard
    {
        public int IdMovieBoard { get; set; }
        public DateTime PremiereDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public List<CinemaFunction>? CinemaFunctions { get; set; }
    }
}
