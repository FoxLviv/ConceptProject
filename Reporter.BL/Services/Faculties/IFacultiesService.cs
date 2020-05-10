using Reporter.Common.DTOs;
using System.Collections.Generic;

namespace Reporter.BL.Services.Faculties
{
    public interface IFacultiesService
    {
        public void Create(FacultieDTO facultie);

        public void Update(FacultieDTO facultie);

        public void Delete(int id);

        public IEnumerable<PersonDTO> GetListPersones(int facultieId);        
    }
}
