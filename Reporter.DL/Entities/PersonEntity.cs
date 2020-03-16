using System;
using System.Collections.Generic;

namespace Reporter.DL.Entities
{
    public class PersonEntity
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public byte[] PasswordHash { get; set; }

        public byte[] PasswordSalt { get; set; }

        public int FacultieId { get; set; }

        public FacultieEntity Facultie { get; set; }

        public int DepartmentId { get; set; }

        public DepartmentEntity Department { get; set; }

        public List<PersonRoleEntity> PersonRoles { get; set; }

        public List<ReportEntity> Reports { get; set; }

        public List<CommentEntity> Comments { get; set; }
    }
}
