using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public int IdClient { get; set; }
        public Client? Client { get; set; }
        public CinemaFunction? CinemaFunction { get; set; }
    }
}
