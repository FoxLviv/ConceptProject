using System;
using System.Collections.Generic;
using System.Text;

namespace Reporter.Common.DTOs {
    public class PersonDTO {
        public Guid Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public int FacultieId { get; set; }

        public int DepartmentId { get; set; }
    }
}
