using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using Aisoftware.Tracker.Api.Handlers;

namespace Aisoftware.Tracker.Api.Controllers
{
    public class AisoftwareTrackerCodeBehind
    {
        public Auth Auth;
        private HttpRequest _request;
        private HttpResponse _response;
        private HandlerFactory _handlerFactory;

        private readonly string ERROR_MESSAGE = "ErrorMessage";
        private readonly string WARNING_MESSAGE = "WarningMessage";
        private readonly string SUCCESS_MESSAGE = "SuccessMessage";
        private readonly string USER_AGENT = "User-Agent";
        private readonly int ONE_THOUSAND = 1000;

        public AisoftwareTrackerCodeBehind(HttpRequest request, HttpResponse response, HandlerFactory handlerFactory)
        {
            _request = request;
            _response = response;
            _handlerFactory = handlerFactory;

            Auth = new Auth(this, handlerFactory);
        }

        private Dictionary<string, string> _valores = new Dictionary<string, string>();

        public void SaveValue(string key, object value, int? daysToExpire)
        {
            value = $"{value?.ToString()}{string.Empty}";

            _response.Cookies.Delete(key);

            int days = daysToExpire != null ? daysToExpire.Value : ONE_THOUSAND;

            var options = new CookieOptions
            {
                IsEssential = true,
                Expires = DateTime.Now.AddDays(days)
            };

            _response.Cookies.Append(key, value.ToString(), options);

            if (_valores.ContainsKey(key))
            {
                _valores[key] = value.ToString();
            }
            else
            {
                _valores.Add(key, value.ToString());
            }
        }

        public string GetValue(string key)
        {
            return _valores.ContainsKey(key) ? _valores[key] : _valores[key] = _request.Cookies[key];
        }

        public void AdicionaErro(string msg)
        {
            SaveValue(ERROR_MESSAGE, msg, null);
        }

        public string GetErro()
        {
            return GetValueAndErase(ERROR_MESSAGE);
        }

        public void AdicionaWarning(string msg)
        {
            SaveValue(WARNING_MESSAGE, msg, null);
        }

        public string GetWarning()
        {
            return GetValueAndErase(WARNING_MESSAGE);
        }

        public void AdicionaSuccess(string msg)
        {
            SaveValue(SUCCESS_MESSAGE, msg, null);
        }

        public string GetSuccess()
        {
            return GetValueAndErase(SUCCESS_MESSAGE);
        }

        public string GetValueAndErase(string key)
        {
            string response = _valores.ContainsKey(key) ? _valores[key] : _request.Cookies[key];

            _valores.Remove(key);
            _response.Cookies.Delete(key);
            return response;
        }

        public string GetBrowser()
        {
            return _request.Headers[USER_AGENT];
        }
    }
}
