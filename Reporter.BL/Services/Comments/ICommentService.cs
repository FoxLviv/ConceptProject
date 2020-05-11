using Reporter.Common.DTOs;
using System;
using System.Collections.Generic;

namespace Reporter.BL.Services.Comments
{
    public interface ICommentService
    {
        void Create(CommentDTO comment);

        CommentDTO GetById(int id);

        IEnumerable<CommentDTO> GetAllForReport(int reportId);

        IEnumerable<CommentDTO> GetAllForAuthor(Guid authorID);

        void Update(CommentDTO comment);

        void Delete(int id);

    }
}
