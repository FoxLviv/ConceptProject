// <copyright file="IDepartmentService.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using Reporter.Common.DTOs;
using System.Collections.Generic;

namespace Reporter.BL.Services.Departmens
{
    public interface IDepartmentService
    {
        void Create(DepatrmentDTO depatrment);

        void Update(DepatrmentDTO depatrment);

        void Delete(int id);

        IEnumerable<PersonDTO> GetListPersones(int departmentID);
    }
}
