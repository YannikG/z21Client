using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Z21Client.DTO;

namespace Z21Client.Events
{
    public class LogMessageEventArgs
    {
        internal LogMessageEventArgs(LogLevel logLevel, string? message)
        {
            Message = message;
            LogLevel = logLevel;
        }

        internal LogMessageEventArgs(LogLevel logLevel, Exception? exception, string? message = null)
        {
            Exception = exception;
            Message = message;
            LogLevel = logLevel;
        }

        public Exception? Exception { get; set; } = default!;

        public string? Message { get; internal set; } = default!;

        public LogLevel LogLevel { get; internal set; } = LogLevel.Info;
    }
}
