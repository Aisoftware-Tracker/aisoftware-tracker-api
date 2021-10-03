using System.Threading.Tasks;
using Aisoftware.Tracker.Repositories.Groups.Interfaces;
using System.Collections.Generic;
using Aisoftware.Tracker.Borders.Positions.Entities;

namespace Aisoftware.Tracker.Repositories.Groups.Repositories
{
    public class PositionRepository : IPositionRepository
    {
        public Task<IEnumerable<Position>> Find(KeyValuePair<string, string> param)
        {
            throw new System.NotImplementedException();
        }
    }
}