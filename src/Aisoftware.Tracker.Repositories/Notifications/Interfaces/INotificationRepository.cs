using System.Threading.Tasks;
using Aisoftware.Tracker.Borders.Groups.Entities;
using System.Collections.Generic;
using Aisoftware.Tracker.Borders.Notifications.DTO;
using Aisoftware.Tracker.Borders.Notifications.Entities;

namespace Aisoftware.Tracker.Repositories.Groups.Interfaces
{
    public interface INotificationRepository
    {
        /// <summary>
        /// @Get
        /// </summary>        
        Task<IEnumerable<Notification>> Find(NotificationParam param);

        /// <summary>
        /// @Get 
        /// <para>Fetch a list of available Notification types</para>
        /// </summary>        
        Task<IEnumerable<string>> FindTypes();

        /// <summary>
        /// @Post
        /// </summary>
        Task<Notification> Save(Notification request);

        ///<summary>
        /// @Post
        /// <para>Send test notification to current user via Email and SMS</para> 
        ///</summary>
        /// <returns>success = 204</returns>
        Task Test();

        /// <summary>
        /// @Put
        /// </summary>
        Task<Notification> Update(Notification request);

        /// <summary>
        /// @Delete
        /// </summary>
        Task Delete(int id);
    }
}