using System.Threading.Tasks;
using System.Collections.Generic;
using Aisoftware.Tracker.Borders.Positions.Entities;
using Aisoftware.Tracker.Borders.Positions.DTO;

namespace Aisoftware.Tracker.Repositories.Groups.Interfaces
{
    public interface IPositionRepository
    {
       /// <summary>
        /// @Get
        /// </summary>        
        Task<IEnumerable<Position>> Find(KeyValuePair<string, string> param);
    }
}