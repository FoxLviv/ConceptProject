using System;
using Reporter.Common.DTOs;
using System.Collections.Generic;

namespace Reporter.BL.Services.Reports
{
    public interface IReportService
    {
        public IEnumerable<ReportDTO> GetAllReports();

        public void Create(ReportDTO report);

        public ReportDTO GetById(int id);

        public IEnumerable<ReportDTO> GetAllForAuthor(Guid autorId);

        public void Update(ReportDTO report);

        public void Delete(Guid id);
    }
}
