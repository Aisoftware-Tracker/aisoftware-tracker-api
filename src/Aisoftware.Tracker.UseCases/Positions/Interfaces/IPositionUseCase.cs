using System.Threading.Tasks;
using System.Collections.Generic;
using Aisoftware.Tracker.Borders.Positions.DTO;

namespace Aisoftware.Tracker.UseCases.Groups.Interfaces
{
    public interface IPositionUseCase
    {
       /// <summary>
        /// @Get
        /// </summary>        
        Task<IEnumerable<PositionDTO>> Find(KeyValuePair<string, string> param);
    }
}