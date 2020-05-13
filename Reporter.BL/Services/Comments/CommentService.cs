using AutoMapper;
using Reporter.Common.DTOs;
using Reporter.DL;
using Reporter.DL.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reporter.BL.Services.Comments {
    public class CommentService: ICommentService
    {
        private IMapper _mapper;
        private ReporterDBContext _dbContext;

        public CommentService(IMapper mapper, ReporterDBContext dbContext) {
            this._mapper = mapper;
            this._dbContext = dbContext;
        }

        public async Task Create(CommentDTO comment) {
            await _dbContext.Comments.AddAsync(_mapper.Map<CommentEntity>(comment));
            _dbContext.SaveChangesAsync();
        }

        public async Task<CommentDTO> GetById(int id) {
            var comment = await _dbContext.Comments.FindAsync(id);

            return _mapper.Map<CommentDTO>(comment);
        }

        public IEnumerable<CommentDTO> GetAllForReport(int reportId) {
            return _dbContext.Comments.Where(comment => comment.ReportId == reportId).Select(comment => _mapper.Map<CommentDTO>(comment));
        }

        public IEnumerable<CommentDTO> GetAllForAuthor(string authorID) {
            return _dbContext.Comments.Where(comment => comment.AuthorId == authorID).Select(comment => _mapper.Map<CommentDTO>(comment));
        }

        public async Task Update(CommentDTO comment) {
            var commentEntity = _mapper.Map<CommentEntity>(comment);
            _dbContext.Comments.Update(commentEntity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task Delete(int id) {
            CommentEntity comment = await _dbContext.Comments.FindAsync(id);
            if (comment != null)
            {
                _dbContext.Comments.Remove(comment);
                await _dbContext.SaveChangesAsync();
            }
        }
    }
}
