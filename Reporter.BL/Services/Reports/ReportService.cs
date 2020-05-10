using AutoMapper;
using Reporter.Common.DTOs;
using Reporter.DL;
using Reporter.DL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reporter.BL.Services.Reports {
    public class ReportService: IReportService {
        private IMapper _mapper;
        private ReporterDBContext _dbContext;

        public ReportService(IMapper mapper, ReporterDBContext dbContext) {
            this._mapper = mapper;
            this._dbContext = dbContext;
        }

        public void Create(ReportDTO report) {
            _dbContext.Add(report);
            _dbContext.SaveChanges();
        }

        public ReportDTO GetById(int id) {
            var report = _dbContext.Reports.Find(id);

            return _mapper.Map<ReportDTO>(report);
        }

        public IEnumerable<ReportDTO> GetAllForAuthor(Guid autorId) {
            return _dbContext.Reports.Where(report => report.AuthorId == autorId).Select(report => _mapper.Map<ReportDTO>(report));
        }

        public void Update(ReportDTO report) {
            var reportEntity = _mapper.Map<ReportEntity>(report);
            _dbContext.Reports.Update(reportEntity);
            _dbContext.SaveChanges();
        }

        public void Delete(Guid id) {
            ReportEntity report = _dbContext.Reports.Find(id);
            if (report != null)
            {
                _dbContext.Reports.Remove(report);
                _dbContext.SaveChanges();
            }
        }
    }
}
