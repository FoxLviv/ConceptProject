using Reporter.Common.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Reporter.BL.Services.Persons {
    public interface IPersonService {
        
        /// <summary>
        ///     Check if person register
        /// </summary>
        /// <returns></returns>
        bool hasAccount(string email, string password);
        
        /// <summary>
        ///     Get person by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<PersonDTO> GetByUid(Guid id);

        /// <summary>
        ///     Delete Persone by id
        /// </summary>
        /// <param name="id"></param>
        Task Delete(Guid id);

        Task Create(PersonDTO person);

        Task Update(PersonDTO person);
    }
}
