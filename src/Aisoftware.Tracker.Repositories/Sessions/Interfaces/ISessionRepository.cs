using System.Threading.Tasks;
using Aisoftware.Tracker.Borders.Users.Entities;
using System.Collections.Generic;
using System.Net;

namespace Aisoftware.Tracker.Repositories.Sessions.Interfaces
{
    public interface ISessionRepository
    {
        /// <summary>
        /// @Get
        /// <para/>Fetch Session information
        /// </summary>
        Task<User> Find();

        /// <summary>
        /// @Post        
        /// <para/>Create a new Session
        /// </summary>
        Task<User> CreateSession(Dictionary<string, string> request);

        /// <summary>
        /// @Delete
        /// <para/>Close the Session
        /// </summary>
        Task Delete();

        /// <summary>
        /// <para/>Fetch Cookies
        /// </summary>
        Cookie GetCookie();
    }
}