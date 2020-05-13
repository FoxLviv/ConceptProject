using Reporter.Common.DTOs;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Reporter.BL.Services.Comments
{
    public interface ICommentService
    {
        Task Create(CommentDTO comment);

        Task<CommentDTO> GetById(int id);

        IEnumerable<CommentDTO> GetAllForReport(int reportId);

        IEnumerable<CommentDTO> GetAllForAuthor(string authorID);

        Task Update(CommentDTO comment);

        Task Delete(int id);

    }
}
