using AutoMapper;
using Reporter.Common.DTOs;
using Reporter.DL;
using Reporter.DL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reporter.BL.Services.Comments {
    public class CommentService {
        private IMapper _mapper;
        private ReporterDBContext _dbContext;

        public CommentService(IMapper mapper, ReporterDBContext dbContext) {
            this._mapper = mapper;
            this._dbContext = dbContext;
        }

        public void Create(CommentDTO comment) {
            _dbContext.Comments.Add(_mapper.Map<CommentEntity>(comment));
            _dbContext.SaveChanges();
        }

        public CommentDTO GetById(int id) {
            var comment = _dbContext.Comments.Find(id);

            return _mapper.Map<CommentDTO>(comment);
        }

        public IEnumerable<CommentDTO> GetAllForReport(int reportId) {
            return _dbContext.Comments.Where(comment => comment.ReportId == reportId).Select(comment => _mapper.Map<CommentDTO>(comment));
        }

        public IEnumerable<CommentDTO> GetAllForAuthor(Guid authorID) {
            return _dbContext.Comments.Where(comment => comment.AuthorId == authorID).Select(comment => _mapper.Map<CommentDTO>(comment));
        }

        public void Update(CommentDTO comment) {
            var commentEntity = _mapper.Map<CommentEntity>(comment);
            _dbContext.Comments.Update(commentEntity);
            _dbContext.SaveChanges();
        }

        public void Delete(int id) {
            CommentEntity comment = _dbContext.Comments.Find(id);
            if (comment != null)
            {
                _dbContext.Comments.Remove(comment);
                _dbContext.SaveChanges();
            }
        }
    }
}
