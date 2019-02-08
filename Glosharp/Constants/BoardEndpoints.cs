using System;
using System.Collections.Generic;
using System.Text;

namespace Glosharp.Constants
{
    public class BoardEndpoints
    {
        public static string Boards = "/boards";

        public static string Board(string boardId)
        {
            return $"/boards/{boardId}";
        }
    }
}
