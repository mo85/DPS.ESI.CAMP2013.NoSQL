using System;
using System.Collections.Generic;

namespace Zuehlke.Camp2013.NoSQL.DAL.Entities
{
    public class WebPageEntity
    {
        public virtual Guid Id { get; set; }

        public virtual string Url { get; set; }

        public virtual string Content { get; set; }

        public virtual string Title { get; set; }

        public virtual string Description { get; set; }
    }
}