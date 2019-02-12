using System;
using System.Collections.Generic;
using System.Text;

namespace Glosharp.Constants
{
    public class BoardEndpoints
    {
        public static string Boards()
        {
            return $"{Endpoint.Base}/boards?page=1&per_page=50&sort=asc&archived=false&fields=name&fields=members&fields=labels&fields=invited_members&fields=created_date&fields=created_by&fields=columns&fields=archived_date&fields=archived_columns";
        }

        public static string Board(string boardId)
        {
            return $"/boards/{boardId}";
        }
    }
}
