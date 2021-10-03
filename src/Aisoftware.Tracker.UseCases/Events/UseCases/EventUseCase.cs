using System.Threading.Tasks;
using Aisoftware.Tracker.Borders.Events.DTO;
using Aisoftware.Tracker.UseCases.Groups.Interfaces;

namespace Aisoftware.Tracker.UseCases.Groups.UseCases
{
    public class EventUseCase : IEventUseCase
    {
        public Task<EventDTO> FindById(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}