using System;
using Reporter.Common.DTOs;
using System.Collections.Generic;

namespace Reporter.BL.Services.Reports
{
    public interface IReportService
    {
        IEnumerable<ReportDTO> GetAllReports();

        void Create(ReportDTO report);

        ReportDTO GetById(int id);

        IEnumerable<ReportDTO> GetAllForAuthor(Guid autorId);

        void Update(ReportDTO report);

        void Delete(Guid id);
    }
}
