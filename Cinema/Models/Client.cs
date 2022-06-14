using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Models
{
    public class Client
    {
        public int IdClient { get; set; }
        public int IdUser { get; set; }
        public User? User { get; set; }
        public string Name { get; set; } = string.Empty;
        public string BasicAdress { get; set; } = string.Empty;
        public byte Age { get; set; }
    }
}
