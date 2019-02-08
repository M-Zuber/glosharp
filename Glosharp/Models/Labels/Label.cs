using System;
using Glosharp.Models.Labels;
using Glosharp.Models.Users;

namespace Glosharp.Models.Boards
{
    public class Label
    {
        public string Id {get;set;}

        public string Name {get;set;}

        public LabelColor Color {get;set;}

        public DateTime CreatedDate {get;set;}

        public PartialUser CreatedBy {get;set;}
    }
}