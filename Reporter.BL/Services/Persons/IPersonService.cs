using Reporter.Common.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reporter.BL.Services.Persons {
    interface IPersonService {
        
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
        PersonDTO GetByUid(Guid id);

        /// <summary>
        ///     Delete Persone by id
        /// </summary>
        /// <param name="id"></param>
        void Delete(Guid id);

    }
}
