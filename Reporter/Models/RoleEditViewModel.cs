using Microsoft.AspNetCore.Identity;
using Reporter.DL.Entities;
using System.Collections.Generic;

namespace Reporter.UI.Models
{
    public class RoleEditViewModel
    {
        public IdentityRole Role { get; set; }

        public IEnumerable<PersonEntity> Members { get; set; }

        public IEnumerable<PersonEntity> NonMembers { get; set; }
    }
}
