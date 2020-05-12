using Reporter.DL.Entities.Base;
using System;
using System.Collections.Generic;

namespace Reporter.DL.Entities
{
    public class ReportEntity : BaseEntity
    {
        public string AuthorId { get; set; }

        public PersonEntity Author { get; set; }

        public DateTimeOffset CreatedAt { get; set; }

        public string Title { get; set; }

        public string Report { get; set; }

        public List<CommentEntity> Comments { get; set; }
    }
}
