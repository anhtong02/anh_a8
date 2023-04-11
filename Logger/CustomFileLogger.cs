using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public class CustomFileLogger : ILogger
    {
        public readonly string filename;
        public readonly string category;

        /// <summary>
        /// Creates a filelogger with the specified category. The category options are the same as a basic
        /// ILogger.
        /// </summary>
        /// <param name="category">The level of information documented. Options are the same as a basic 
        /// ILogger.</param>
        public CustomFileLogger(string category)
        {
            string time = DateTime.Now.ToString().Replace(" ", "").Replace("/", "-").Replace(":", "-");
            this.filename = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
                + Path.DirectorySeparatorChar
                + $"CS3500-{category}-{time}.log";

            this.category = category;
        }

        /// <summary>
        /// Not needed for this project. Is here so the ILogger interface is properly implemented.
        /// </summary>
        /// <typeparam name="TState">Unused, may be null.</typeparam>
        /// <param name="state">Unused, may be null.</param>
        /// <returns>Nothing, will always throw a NotImplementedException.</returns>
        /// <exception cref="NotImplementedException">Will always be thrown.</exception>
        public IDisposable? BeginScope<TState>(TState state) where TState : notnull
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Not needed for this project. Is here so the ILogger interface is properly implemented.
        /// </summary>
        /// <param name="logLevel">Unused, may be null.</param>
        /// <returns>Nothing, will always throw a NotImplementedException.</returns>
        /// <exception cref="NotImplementedException">Will always be thrown.</exception>
        public bool IsEnabled(LogLevel logLevel)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Logs the given message to the file found at filename (public field in this class).
        /// </summary>
        /// <typeparam name="TState">The level at which the message will be logged. Options are same as 
        /// ILogger.</typeparam>
        /// <param name="logLevel">The level at which the message will be logged. Options are same as 
        /// ILogger.</param>
        /// <param name="eventId">Unused, may be null.</param>
        /// <param name="state">The state of object.</param>
        /// <param name="exception">The exception if necessary.</param>
        /// <param name="formatter">Formats the message.</param>
        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter)
        {
            string logDate = $"{DateTime.Now}: {state}{exception}";
            File.AppendAllText(filename, logDate + Environment.NewLine);
            File.AppendAllText(filename, formatter(state, exception) + Environment.NewLine);
        }
    }
}