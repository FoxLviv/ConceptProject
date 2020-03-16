using Reporter.DL.Entities.Base;
using System.Collections.Generic;

namespace Reporter.DL.Entities
{
    public class DepartmentEntity: BaseEntity
    {
        public string Name { get; set; }

        public List<PersonEntity> Person { get; set; }
    }
}