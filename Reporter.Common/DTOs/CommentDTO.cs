using System;

namespace Reporter.Common.DTOs {
    public class CommentDTO {
        public int ID { get; set; }
        public Guid AuthorUid { get; set; }
        public int ReportID { get; set; }
        public DateTime CreateAt { get; set; }
        public string Comment { get; set; }
    }
}
