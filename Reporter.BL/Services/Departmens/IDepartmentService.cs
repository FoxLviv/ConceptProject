// <copyright file="IDepartmentService.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using Reporter.Common.DTOs;
using System.Collections.Generic;

namespace Reporter.BL.Services.Departmens
{
    public interface IDepartmentService
    {
        public void Create(DepatrmentDTO depatrment);

        public void Update(DepatrmentDTO depatrment);

        public void Delete(int id);

        public IEnumerable<PersonDTO> GetListPersones(int departmentID);
    }
}
