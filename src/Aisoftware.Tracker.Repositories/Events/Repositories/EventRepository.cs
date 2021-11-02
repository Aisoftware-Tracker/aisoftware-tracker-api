using System.Threading.Tasks;
using Aisoftware.Tracker.Repositories.Groups.Interfaces;
using Aisoftware.Tracker.Borders.Events.Entities;

namespace Aisoftware.Tracker.Repositories.Groups.Repositories
{
    public class EventRepository : IEventRepository
    {
        public Task<Event> FindById(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}