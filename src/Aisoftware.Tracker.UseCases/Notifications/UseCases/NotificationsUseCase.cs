using System.Threading.Tasks;
using System.Collections.Generic;
using Aisoftware.Tracker.Borders.Notifications.DTO;
using Aisoftware.Tracker.Repositories.Groups.Interfaces;

namespace Aisoftware.Tracker.UseCases.Groups.UseCases
{
    public class NotificationUseCase : INotificationUseCase
    {
        public Task Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<NotificationDTO>> Find(KeyValuePair<string, string> param)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<string>> FindTypes()
        {
            throw new System.NotImplementedException();
        }

        public Task<NotificationDTO> Save(NotificationDTO request)
        {
            throw new System.NotImplementedException();
        }

        public Task Test()
        {
            throw new System.NotImplementedException();
        }

        public Task<NotificationDTO> Update(NotificationDTO request)
        {
            throw new System.NotImplementedException();
        }
    }
}