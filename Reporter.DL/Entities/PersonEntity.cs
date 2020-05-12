using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace Reporter.DL.Entities
{
    public class PersonEntity: IdentityUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int FacultieId { get; set; }

        public FacultieEntity Facultie { get; set; }

        public int DepartmentId { get; set; }

        public DepartmentEntity Department { get; set; }

        public List<ReportEntity> Reports { get; set; }

        public List<CommentEntity> Comments { get; set; }
    }
}
