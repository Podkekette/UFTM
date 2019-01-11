using System;
using System.Collections.Generic;

namespace UFTM.Models
{
    public class Player
    {
        public int PlayerID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Position { get; set; }
        public string Laterality { get; set; }
        public int Size { get; set; }
        public int Weight { get; set; }
        public bool isCaptain { get; set; }
        public List<Attributes> attributes { get; set; }
        public int TeamID { get; set; }
    }
}
