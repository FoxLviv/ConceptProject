using Reporter.DL.Entities.Base;
using System;

namespace Reporter.DL.Entities
{
    public class CommentEntity: BaseEntity
    {
        public Guid AuthorId { get; set; }

        public PersonEntity Author { get; set; }

        public int ReportId { get; set; }

        public ReportEntity Report { get; set; }

        public DateTimeOffset CreateAt { get; set; }

        public string Comment { get; set; }
    }
}
