using Reporter.Common.DTOs;
using System;
using System.Collections.Generic;

namespace Reporter.BL.Services.Comments
{
    public interface ICommentService
    {
        public void Create(CommentDTO comment);

        public CommentDTO GetById(int id);        

        public IEnumerable<CommentDTO> GetAllForReport(int reportId);       

        public IEnumerable<CommentDTO> GetAllForAuthor(Guid authorID);        

        public void Update(CommentDTO comment);        

        public void Delete(int id);

    }
}
