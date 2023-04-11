using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public class CustomFileLogProvider
    {
        /// <summary>
        /// Creates a new CustomFileLogger at the given level.
        /// </summary>
        /// <param name="categoryName">The level at which information will be logged.</param>
        /// <returns>A CustomFileLogger</returns>
        public ILogger CreateLogger(string categoryName)
        {
            return new CustomFileLogger(categoryName);
        }

        /// <summary>
        /// Unused, will always throw a NotImplementedException.
        /// This is unimplemented because we utilize File.Append for the logger's functionality, and thus don't need to worry
        /// about closing or disposing of the logger.
        /// </summary>
        /// <exception cref="NotImplementedException">Will always be thrown.</exception>
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}