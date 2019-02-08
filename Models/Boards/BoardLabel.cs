using System;

namespace Glosharp.Models.Boards
{
    public class BoardLabel
    {
        public string Id {get;set;}

        public string Name {get;set;}

        public BoardLabelColor Color {get;set;}

        public DateTime CreatedDate {get;set;}

        public BoardMember CreatedBy {get;set;}
    }
}