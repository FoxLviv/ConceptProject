using System;

namespace Reporter.DL.Entities
{
    public class PersonRoleEntity
    {
        public int RoleId { get; set; }

        public RoleEntity Role { get; set; }

        public Guid PersonId { get; set; }

        public PersonEntity Person { get; set; }
    }
}
