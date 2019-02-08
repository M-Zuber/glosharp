using System.Collections.Generic;
using Glosharp.Models.Labels;
using Glosharp.Models.Users;

namespace Glosharp.Models.Cards
{
    public class Card
    {
        public string Id {get;set;}

        public int Position {get;set;}

        public string Description {get;set;}

        public string BoardId {get;set;}

        public string ColumnId {get;set;}

        public string CreatedDate {get;set;}

        public string UpdatedDate {get;set;}

        public string ArchivedDate {get;set;}

        public List<PartialUser> Assignees { get; set; }

        public List<PartialLabel> Labels { get; set; }

        public string DueDate {get;set;}

        public int CommentCount {get;set;}

        public int AttachmentCount {get;set;}

        public int CompletedTaskCount {get;set;}

        public int TotalTaskCount {get;set;}

        public string CreatedBy {get;set;}
    }
}