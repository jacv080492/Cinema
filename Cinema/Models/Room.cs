using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Models
{
    public class Room
    {
        public int IdRoom { get; set; }
        public int IdTheater { get; set; }
        public Theater? Theater { get; set; }
        public int Number { get; set; }
        public List<Seat> Seats { get; set; } = new List<Seat>();
    }
}
