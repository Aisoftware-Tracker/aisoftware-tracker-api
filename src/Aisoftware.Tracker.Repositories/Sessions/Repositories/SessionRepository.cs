using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Aisoftware.Tracker.Borders.Users.Entities;
using Aisoftware.Tracker.Repositories.Sessions.Interfaces;

namespace Aisoftware.Tracker.Repositories.Devices.Repositories
{
    public class SessionRepository : ISessionRepository
    {
        private readonly IAppConfiguration _config;
        public static Cookie _cookie;
        private const string SESSION = "session";

        public SessionRepository(IAppConfiguration config)
        {
            _config = config;
            _cookie = new Cookie();
        }

        public Cookie GetCookie()
        {
            return _cookie;
        }

        public Task Delete()
        {
            throw new System.NotImplementedException();
        }

        public Task<User> Find()
        {
            throw new System.NotImplementedException();
        }

        public async Task<User> CreateSession(Dictionary<string, string> request)
        {
            string url = $"{_config.BaseUrl}{SESSION}";

            return await PostFormUrlEncoded<User>(url, request);
        }

        //TODO Criar interfaces e Classes genericas paras os verbos http e suas implementacoes
        private async Task<TResult> PostFormUrlEncoded<TResult>(string url, IEnumerable<KeyValuePair<string, string>> postData)
        {
            CookieContainer cookies = new CookieContainer();
            HttpClientHandler handler = new HttpClientHandler();
            handler.CookieContainer = cookies;
            var uri = new Uri(url);

            using (var httpClient = new HttpClient(handler))
            {
                using (var content = new FormUrlEncodedContent(postData))
                {
                    content.Headers.Clear();
                    content.Headers.Add("Content-Type", "application/x-www-form-urlencoded");

                    HttpResponseMessage response = await httpClient.PostAsync(url, content);

                    var cookieList = cookies.GetCookies(uri);

                    _cookie = cookieList[0];

                    return await response.Content.ReadAsAsync<TResult>();
                }
            }
        }
    }
}