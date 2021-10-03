using System.Threading.Tasks;
using Aisoftware.Tracker.Repositories.Groups.Interfaces;
using System.Collections.Generic;
using Aisoftware.Tracker.Borders.Notifications.Entities;
using Aisoftware.Tracker.Borders.Notifications.DTO;

namespace Aisoftware.Tracker.Repositories.Groups.Repositories
{
    public class NotificationRepository : INotificationRepository
    {
        public Task Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Notification>> Find(NotificationParam param)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<string>> FindTypes()
        {
            throw new System.NotImplementedException();
        }

        public Task<Notification> Save(Notification request)
        {
            throw new System.NotImplementedException();
        }

        public Task Test()
        {
            throw new System.NotImplementedException();
        }

        public Task<Notification> Update(Notification request)
        {
            throw new System.NotImplementedException();
        }
    }
}