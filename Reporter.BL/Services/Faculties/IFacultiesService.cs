using Reporter.Common.DTOs;
using System.Collections.Generic;

namespace Reporter.BL.Services.Faculties
{
    public interface IFacultiesService
    {
        void Create(FacultieDTO facultie);

        void Update(FacultieDTO facultie);

        void Delete(int id);

        IEnumerable<PersonDTO> GetListPersones(int facultieId);
    }
}
