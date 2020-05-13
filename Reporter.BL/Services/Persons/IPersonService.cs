using Reporter.Common.DTOs.Person;
using System;
using System.Threading.Tasks;

namespace Reporter.BL.Services.Persons
{
    public interface IPersonService {

        /// <summary>
        ///     Check if person register
        /// </summary>
        /// <returns></returns>
        bool hasAccount(string email, string password);

        /// <summary>
        ///     Get person by id method.
        /// </summary>
        /// <param name="id">Person's id.</param>
        /// <returns>Person's view model.</returns>
        Task<PersonDTO> GetByIdAsync(string id);

        /// <summary>
        ///     Delete Persone by id method.
        /// </summary>
        /// <param name="id">Person id.</param>
        Task DeletePersonAsync(string id);

        /// <summary>
        ///     Create new person method.
        /// </summary>
        /// <param name="person">Data for creating new person.</param>
        /// <returns>Created person.</returns>
        //Task<PersonDTO> CreatePersonAsync(CreatePersonDTO person);

        /// <summary>
        ///     Update person method.
        /// </summary>
        /// <param name="person">Data for updating person.</param>
        /// <returns>Updated person.</returns>
        Task Update(PersonDTO person);
    }
}
