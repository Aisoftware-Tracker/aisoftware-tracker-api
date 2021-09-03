using System;
using Microsoft.AspNetCore.Mvc;
using Aisoftware.Tracker.Borders.Helpers;

namespace Aisoftware.Tracker.Api
{
    public class NotOk : ControllerBase
    {
        private readonly Exception _exception;
        
        public NotOk(Exception e)
        {
            _exception = e;
        }

        public ActionResult Build()
        {
            var response = ExceptionHelper.HttpHandleException(_exception);

            if(response != null && response.Status != 500)
            {
                return StatusCode(response.Status, new
                {
                    success = false,
                    message = response.Message,
                    detail = _exception.StackTrace.ToString()
                });
            }

            return StatusCode(500, new
            {
                success = false,
                message = ExceptionHelper.InnerException(_exception).Message,
                detail = _exception.StackTrace.ToString()
            });
        }
    }
}