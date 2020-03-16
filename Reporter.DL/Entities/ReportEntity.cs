﻿using Reporter.DL.Entities.Base;
using System;
using System.Collections.Generic;

namespace Reporter.DL.Entities
{
    public class ReportEntity:BaseEntity
    {
        public Guid AuthorId { get; set; }

        public PersonEntity Author { get; set; }

        public DateTimeOffset CreatedAt { get; set; }

        public string Report { get; set; }

        public List<CommentEntity> Comments { get; set; }
    }
}
