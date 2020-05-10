using Reporter.DL.Entities.Base;
using System.Collections.Generic;

namespace Reporter.DL.Entities
{
    public class FacultieEntity : BaseEntity
    {
        public string Name { get; set; }

        public List<PersonEntity> Persons { get; set; }
    }
}