using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevTeams.Data.Entities;

namespace DevTeams.Repository.DeveloperTeamRepository
{
    public class DevTeamRepository
    {
        private readonly List<DeveloperTeam> _devTeamDbContext = new List<DeveloperTeam>();
        private int _count = 0;
    }
}