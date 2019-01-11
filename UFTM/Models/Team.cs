using System;
using System.Collections.Generic;
namespace UFTM.Models
{
    public class Team
    {
        public List<Player> players { get; set; }
        public int TeamID { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Stadium { get; set; }
    }
}
