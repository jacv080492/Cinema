using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Models
{
    public class Seat
    {
        public int IdSeat { get; set; }
        public int IdRoom { get; set; }
        public Room? Room { get; set; }
        public string Label { get; set; } = string.Empty;
        public int Line { get; set; }
        public bool Vacant { get; set; } = true;
    }
}
