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

        public static string UserFull()
        {
            return $"{Endpoint.Base}/user?fields=email&fields=name&fields=username";
        }
    }
}
