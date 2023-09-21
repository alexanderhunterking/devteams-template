using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevTeams.Data.Entities
{
    public class Developer
    {
        public Developer(){}

        public Developer(string firstName, string lastName, bool hasPluralSight)
        {
            FirstName = firstName;
            LastName = lastName;
            HasPluralSight = hasPluralSight;
        
        }
        // PrimaryKey
        public int Id { get; set; }
        public string FirstName { get; set; } 
        public string LastName { get; set; } 
        public string FullName { get {return $"{FirstName} {LastName}";} }
        public bool HasPluralSight  {get;set;}
    }
}