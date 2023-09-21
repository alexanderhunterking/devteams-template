using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevTeams.Data.Entities
{
    public class DeveloperTeam
    {
        // Primary Key
        public int Id { get; set; }
        public string Name { get; set; }
        // One developer team can have many developers
        public List<Developer> DevsOnTeam { get; set; } = new List<Developer>();
    }
}