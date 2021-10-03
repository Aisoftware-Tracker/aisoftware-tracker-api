using System.Threading.Tasks;
using Aisoftware.Tracker.UseCases.Groups.Interfaces;
using System.Collections.Generic;
using Aisoftware.Tracker.Borders.Positions.DTO;

namespace Aisoftware.Tracker.UseCases.Groups.UseCases
{
    public class PositionUseCase : IPositionUseCase
    {
        public Task<IEnumerable<PositionDTO>> Find(KeyValuePair<string, string> param)
        {
            throw new System.NotImplementedException();
        }
    }
}