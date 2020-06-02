using Reporter.Common.DTOs;
using System.Collections.Generic;

namespace Reporter.UI.Models
{
    public class ReportsListViewModel
    {
        public IEnumerable<ReportDTO> Reports { get; set; }

        public string CurrentDepartment { get; set; }

        public string CurrentFacultie { get; set; }

        public int SelectedFaculties { get; set; }

        public int SelectedDepatrments { get; set; }
    }
}
