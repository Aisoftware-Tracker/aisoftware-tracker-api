using System.Threading.Tasks;
using Aisoftware.Tracker.Borders.Events.Entities;

namespace Aisoftware.Tracker.Repositories.Groups.Interfaces
{
    public interface IEventRepository
    {      
        /// <summary>
        /// @Get
        /// </summary>
        Task<Event> FindById(int id);

    }
}