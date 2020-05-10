using System;
using System.Collections.Generic;
using System.Text;

namespace Reporter.Common.DTOs {
    public class ReportDTO {
        public int ID { get; set; }
        public Guid AuthorUID { get; set; }
        public string Title { get; set; }
        public string Report { get; set; }
    }
}
