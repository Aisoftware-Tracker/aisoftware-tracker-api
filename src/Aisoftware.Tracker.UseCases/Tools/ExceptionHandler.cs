using System;

namespace Aisoftware.Tracker.UseCases.Tools
{
    public static class ExceptionHandler
    {

    }

    public class MoviyException : Exception
    {
        public MoviyException(string message) : base(message) { }
    }
}
