using System;
using System.Collections.Generic;
using System.Text;
using Glosharp.Models.Users;

namespace Glosharp.Models.Comments
{
    public class Comments
    {
        public string Id { get; set; }

        public string CardId { get; set; }

        public string BoardId { get; set; }

        public string CreatedDate { get; set; }

        public string UpdatedDate { get; set; }

        public PartialUser CreatedBy { get; set; }

        public PartialUser UpdatedBy { get; set; }

        public string Text { get; set; }
    }
}
