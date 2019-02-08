using System;
using System.Collections.Generic;
using System.Text;
using Glosharp.Models.Users;

namespace Glosharp.Models.Columns
{
    public class Column
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public int Position { get; set; }

        public string ArchivedDate { get; set; }

        public string CreatedDate { get; set; }

        public PartialUser CreatedBy { get; set; }
    }
}
