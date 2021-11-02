using System.Threading.Tasks;
using Aisoftware.Tracker.Borders.Events.DTO;

namespace Aisoftware.Tracker.UseCases.Groups.Interfaces
{
    public interface IEventUseCase
    {      
        /// <summary>
        /// @Get
        /// </summary>
        Task<EventDTO> FindById(int id);

    }
}