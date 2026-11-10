using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace davIT.Models
{
    /// <summary>
    /// Extension methods for HTTP request processing and server variable extraction.
    /// </summary>
    public static class ExtensionMethods
    {
        /// <summary>
        /// Determines whether the server variables collection contains the specified key name.
        /// </summary>
        /// <param name="req">The HTTP request context.</param>
        /// <param name="variable">The server variable name to locate.</param>
        /// <returns><c>true</c> if the variable key exists; otherwise, <c>false</c>.</returns>
        public static bool Contains(this HttpRequestBase req, string variable)
        {
            foreach (string item in req.ServerVariables.Keys)
            {
                if (item == variable)
                    return true;
            }
            return false;
        }
    }
}
