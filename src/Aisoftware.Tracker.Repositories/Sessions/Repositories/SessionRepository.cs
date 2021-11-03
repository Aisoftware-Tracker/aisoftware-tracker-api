using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Aisoftware.Tracker.Borders.Users.Entities;
using Aisoftware.Tracker.Repositories.Sessions.Interfaces;
using System.Net.Http.Headers;
using Aisoftware.Tracker.Borders.Constants;

///TODO Refatorar esta classe para reestruturar melhor e adicionar try catch
namespace Aisoftware.Tracker.Repositories.Devices.Repositories
{
    public class SessionRepository : ISessionRepository
    {
        private readonly IAppConfiguration _config;
        public static Cookie _cookie;
        private readonly string _url;
        private readonly Uri _uri;

        public SessionRepository(IAppConfiguration config)
        {
            _config = config;
            _url = $"{_config.BaseUrl}/api/{Endpoint.SESSION}";
            _uri = new Uri(_url);
        }

        public Cookie GetCookie()
        {
            return _cookie;
        }

        public async Task<User> Find(string cookieValue)
        {
            var handler = new HttpClientHandler
            {
                CookieContainer = GetCookieContainer(cookieValue)
            };

            var user = new User();

            using (var httpClient = new HttpClient(handler))
            {
                var request = new HttpRequestMessage
                {
                    RequestUri = _uri
                };
                request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue(ContentType.JSON));
                request.Headers.Host = _uri.Host;

                var response = await httpClient.SendAsync(request);

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
            var cookies = new CookieContainer();
            var handler = new HttpClientHandler
            {
                CookieContainer = cookies
            };

            using (var httpClient = new HttpClient(handler))
            {
                using (var content = new FormUrlEncodedContent(postData))
                {
                    content.Headers.Clear();
                    content.Headers.Add("Content-Type", ContentType.FORM_URLENCODE);

                    var response = await httpClient.PostAsync(url, content);

                    var cookieList = cookies.GetCookies(_uri);

                    _cookie = cookieList[0];

                    return await response.Content.ReadAsAsync<TResult>();
                }
            }
        }

        public async Task Delete(string cookieValue)
        {
            var handler = new HttpClientHandler
            {
                CookieContainer = GetCookieContainer(cookieValue)
            };

            using (var httpClient = new HttpClient(handler))
            {
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Delete,
                    RequestUri = _uri
                };
                request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue(ContentType.JSON));
                request.Headers.Host = _uri.Host;

                var response = await httpClient.SendAsync(request);

                var t = response;
            }
        }

        private CookieContainer GetCookieContainer(string cookie)
        {
            _cookie = new Cookie(CookieName.JSESSIONID, cookie, "/", _config.BaseDomain);
            var cookies = new CookieContainer();
            cookies.Add(_cookie);
            return cookies;
        }
    }
}