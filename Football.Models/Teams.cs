using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string TeamName { get; set; }
        public string City { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
        public int Draws { get; set; }
    }
}

