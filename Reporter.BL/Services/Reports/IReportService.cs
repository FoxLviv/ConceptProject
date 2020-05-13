using System;
using Reporter.Common.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Reporter.BL.Services.Reports
{
    public interface IReportService
    {
        IEnumerable<ReportDTO> GetAllReports();

        Task Create(ReportDTO report);

        Task<ReportDTO> GetById(int id);

        IEnumerable<ReportDTO> GetAllForAuthor(string autorId);

        Task Update(ReportDTO report);

        Task Delete(Guid id);
    }
}
