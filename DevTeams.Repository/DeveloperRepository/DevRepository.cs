using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevTeams.Data.Entities;

namespace DevTeams.Repository.DeveloperRepository
{
    public class DevRepository
    {
        // create our fake database
        private readonly List<Developer> _devDbContext = new List<Developer>();

        // Database Id base value
        private int _count =0;
        
    }
}