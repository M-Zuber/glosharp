using System;
using System.Collections.Generic;

namespace Glosharp.Models.Boards
{
    public class Board
    {
        public string Id {get;set;}

        public string Name {get;set;}

        public List<BoardColumn> Columns {get;set;}

        public List<BoardColumn> ArchivedColumns {get;set;}

        public List<BoardMember> InvitedMembers {get;set;}

        public List<BoardMember> Members {get;set;}

        public DateTime ArchivedDate {get;set;}

        
    }
}