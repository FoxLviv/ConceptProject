// <copyright file="IDepartmentService.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using Reporter.Common.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Reporter.BL.Services.Departmens
{
    public interface IDepartmentService
    {
        Task Create(DepatrmentDTO depatrment);

        Task Update(DepatrmentDTO depatrment);

        Task Add(DepatrmentDTO depatrment);

        Task Delete(int id);

        IEnumerable<PersonDTO> GetListPersones(int departmentID);
    }
}
