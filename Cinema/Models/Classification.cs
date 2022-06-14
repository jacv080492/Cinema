using Cinema.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Models
{
    public class Classification
    {
        public int IdClassification { get; set; }
        public Label Label { get; set; }
        public int MinimumAge { get; set; }
    }
}
