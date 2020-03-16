using Reporter.DL.Entities.Base;
using System.Collections.Generic;

namespace Reporter.DL.Entities
{
    public class RoleEntity: BaseEntity
    {
        public string Name { get; set; }

        public List<PersonRoleEntity> PersonRoles { get; set; }
    }
}
