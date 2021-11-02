using System;

namespace Aisoftware.Tracker.Borders.Helpers
{
    public static class ExceptionHelper
    {
        public static Exception InnerException(Exception e)
        {
            if (e.InnerException != null)
            {
                InnerException(e.InnerException);
            }

            return e;
        }

        public static Exception HttpException(int httpStatus, string message)
        {
            throw new Exception($"[status] {httpStatus}; [message] {message} ");            
        }

        public static HttpExceptionResponse HttpHandleException(Exception e) 
        {
            string innerMessage = InnerException(e).Message;

            bool contains = innerMessage.Contains("[status]") || innerMessage.Contains("[message]");

            if(contains)
            {
                var messageArry = innerMessage.Split(';');

                var status = messageArry[0]?.Replace("[status]", string.Empty).Trim() ?? "500";
                
                var message = messageArry[1]?.Replace("[message]", string.Empty).Trim() ?? string.Empty;

                return new HttpExceptionResponse
                {
                    Status = Convert.ToInt32(status),
                    Message = message
                };
            }

            return null;            
        }
    }
}