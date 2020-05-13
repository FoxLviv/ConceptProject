using Reporter.Common.DTOs;
using Reporter.Common.DTOs.Person;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Reporter.BL.Services.Faculties
{
    public interface IFacultiesService
    {
        Task Create(FacultieDTO facultie);

        Task Update(FacultieDTO facultie);

        Task Delete(int id);

        IEnumerable<PersonDTO> GetListPersones(int facultieId);
    }
}
