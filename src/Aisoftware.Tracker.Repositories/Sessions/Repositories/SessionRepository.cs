using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Aisoftware.Tracker.Borders.Users.Entities;
using Aisoftware.Tracker.Repositories.Sessions.Interfaces;
using System.Net.Http.Headers;

///TODO Refatorar esta classe para reestruturar melhor e adicionar try catch
namespace Aisoftware.Tracker.Repositories.Devices.Repositories
{
    public class SessionRepository : ISessionRepository
    {
        private readonly IAppConfiguration _config;
        public static Cookie _cookie;
        private const string SESSION = "session";
        private const string FORM_URLENCODE = "application/x-www-form-urlencoded";
        private readonly string _url;
        
        public SessionRepository(IAppConfiguration config)
        {
            _config = config;
            _cookie = new Cookie();
            _url = $"{_config.BaseUrl}/api/{SESSION}";
        }

        public Cookie GetCookie()
        {
            return _cookie;
        }

        public Task Delete()
        {
            throw new System.NotImplementedException();
        }

        public async Task<User> Find(string cookieValue)
        {
            var cookie = new Cookie(_config.CookieName, cookieValue, "/", _config.BaseUrl.Replace("http://",String.Empty));
            var cookies = new CookieContainer();
            cookies.Add(cookie);

            var handler = new HttpClientHandler
            {
                CookieContainer = cookies
            };

            var uri = new Uri(_url);
            User user = new User();

            using (var httpClient = new HttpClient(handler))
            {
                HttpRequestMessage request = new HttpRequestMessage();
                request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                request.Headers.Host = uri.Host;
                Console.WriteLine(request.Headers.Host);
                request.RequestUri = uri;
                Console.WriteLine(request.RequestUri);

                HttpResponseMessage response = await httpClient.SendAsync(request);

                Console.WriteLine(response.IsSuccessStatusCode);

                if (response.IsSuccessStatusCode)
                {
                    user = await response.Content.ReadAsAsync<User>();
                    Console.WriteLine(user.Name);
                }

                return user;

            }
        }

        public async Task<User> CreateSession(Dictionary<string, string> request)
        {
            return await PostFormUrlEncoded<User>(_url, request);
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
                    content.Headers.Add("Content-Type", FORM_URLENCODE);

                    HttpResponseMessage response = await httpClient.PostAsync(url, content);

                    var cookieList = cookies.GetCookies(uri);

                    _cookie = cookieList[0];

                    return await response.Content.ReadAsAsync<TResult>();
                }
            }
        }
    }
}