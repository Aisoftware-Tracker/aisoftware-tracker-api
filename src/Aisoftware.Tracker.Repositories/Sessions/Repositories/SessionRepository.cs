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

        public async Task<User> Find()
        {
            string url = $"{_config.BaseUrl}{SESSION}";

            var cookies = new CookieContainer();

            var cookie = new Cookie("JSESSIONID", "teste", "/");
            cookies.Add(cookie);

            var handler = new HttpClientHandler
            {
                CookieContainer = cookies
            };

            var uri = new Uri(url);

            using (var httpClient = new HttpClient(handler))
            {
                httpClient.DefaultRequestHeaders.Clear();
                httpClient.DefaultRequestHeaders.Add("Content-Type", "application/json");

                var response = await httpClient.GetAsync(url);

                var cookieList = cookies.GetCookies(uri);

                _cookie = cookieList[0];

                return await response.Content.ReadAsAsync<User>();
            }

        }

        public async Task<User> CreateSession(Dictionary<string, string> request)
        {
            string url = $"{_config.BaseUrl}{SESSION}";

            return await PostFormUrlEncoded<User>(url, request);
        }

        //TODO Criar interfaces e Classes genericas paras os verbos http e suas implementacoes
        private async Task<TResult> PostFormUrlEncoded<TResult>(string url, IEnumerable<KeyValuePair<string, string>> request)
        {
            CookieContainer cookies = new CookieContainer();
            HttpClientHandler handler = new HttpClientHandler();
            handler.CookieContainer = cookies;
            var uri = new Uri(url);

            using (var httpClient = new HttpClient(handler))
            {
                using (var content = new FormUrlEncodedContent(request))
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