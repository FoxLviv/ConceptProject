using AutoMapper;
using Microsoft.AspNetCore.Identity;
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
        private UserManager<PersonEntity> _userManager;

        public ReportService(IMapper mapper, ReporterDBContext dbContext, UserManager<PersonEntity> userManager) {
            this._mapper = mapper;
            this._dbContext = dbContext;
            this._userManager = userManager;
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

        public IEnumerable<ReportDTO> GetAllForAuthor(string autorId) {
            return _dbContext.Reports.Where(report => report.AuthorId == autorId).Select(report => _mapper.Map<ReportDTO>(report));
        }

        public async Task Update(ReportDTO report) {
            var exestingReport = _dbContext.Reports.Find(report.ID);

            exestingReport.Title = report.Title;
            exestingReport.Report = report.Report;

            _dbContext.Reports.Update(exestingReport);
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

        public IEnumerable<ReportDTO> GetFiltered(int facultatyId, int departmenId) {
            var autors = _userManager.Users;

            if (facultatyId != 0)
                autors = autors.Where(r => r.FacultieId == facultatyId);
            if (facultatyId != 0)
                autors = autors.Where(r => r.DepartmentId == departmenId);

            return _mapper.Map<IEnumerable<ReportDTO>>(_dbContext.Reports.Where(report => autors.Select(autor => autor.Id).Contains(report.AuthorId)));

        }
    }
}