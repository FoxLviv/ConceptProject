using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Reporter.Common.DTOs;
using Reporter.DL;
using Reporter.DL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reporter.BL.Services.Reports {
    public class ReportService : IReportService
    {
        private IMapper _mapper;
        private ReporterDBContext _dbContext;

        public ReportService(IMapper mapper, ReporterDBContext dbContext) {
            this._mapper = mapper;
            this._dbContext = dbContext;
        }

        public IEnumerable<ReportDTO> GetAllReports() {
            IEnumerable<ReportEntity> reports = _dbContext.Reports
                .AsNoTracking();
            var reportDTOs = _mapper.Map<List<ReportDTO>>(reports);
            return reportDTOs;
        }

        public async Task Create(ReportDTO report) {
            await _dbContext.AddAsync(report);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<ReportDTO> GetById(int id) {
            var report = await _dbContext.Reports.FindAsync(id);

            return _mapper.Map<ReportDTO>(report);
        }

        public IEnumerable<ReportDTO> GetAllForAuthor(Guid autorId) {
            return _dbContext.Reports.Where(report => report.AuthorId == autorId).Select(report => _mapper.Map<ReportDTO>(report));
        }

        public async Task Update(ReportDTO report) {
            var reportEntity = _mapper.Map<ReportEntity>(report);
            _dbContext.Reports.Update(reportEntity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task Delete(Guid id) {
            ReportEntity report = await _dbContext.Reports.FindAsync(id);
            if (report != null)
            {
                _dbContext.Reports.Remove(report);
                await _dbContext.SaveChangesAsync();
            }
        }
    }
}