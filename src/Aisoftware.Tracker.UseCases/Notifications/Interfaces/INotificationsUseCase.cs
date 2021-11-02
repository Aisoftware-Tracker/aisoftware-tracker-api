using System.Threading.Tasks;
using System.Collections.Generic;
using Aisoftware.Tracker.Borders.Notifications.DTO;

namespace Aisoftware.Tracker.Repositories.Groups.Interfaces
{
    public interface INotificationUseCase
    {
        /// <summary>
        /// @Get
        /// </summary>        
        Task<IEnumerable<NotificationDTO>> Find(KeyValuePair<string, string> param);

        /// <summary>
        /// @Get 
        /// <para>Fetch a list of available Notification types</para>
        /// </summary>        
        Task<IEnumerable<string>> FindTypes();

        /// <summary>
        /// @Post
        /// </summary>
        Task<NotificationDTO> Save(NotificationDTO request);

        ///<summary>
        /// @Post
        /// <para>Send test notification to current user via Email and SMS</para> 
        ///</summary>
        /// <returns>success = 204</returns>
        Task Test();

        /// <summary>
        /// @Put
        /// </summary>
        Task<NotificationDTO> Update(NotificationDTO request);

        /// <summary>
        /// @Delete
        /// </summary>
        Task Delete(int id);
    }
}