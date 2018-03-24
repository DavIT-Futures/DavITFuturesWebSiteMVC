using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace davIT.Models
{
    public static class ExtensionMethods
    {
        public static bool Contains(this HttpRequestBase req, string variable)
        {
            foreach (var item in req.ServerVariables.Keys)
            {
                if (item == variable)
                    return true;
            }
            return false;
        }
    }
}