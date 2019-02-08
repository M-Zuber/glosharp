using System;
using System.Collections.Generic;
using System.Text;

namespace Glosharp.Constants
{
    public class UserEndpoints
    {
        public static string User()
        {
            return $"{Endpoint.Base}/user";
        }
    }
}
