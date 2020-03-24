using Reporter.DL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Reporter.Common.Models;

namespace Reporter.DL.Repositories.Persons {
    public interface IPersonsRepository: IRepository<PersonEntity> {
        /// <summary>
        ///     Get values by guid
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        PersonEntity GetByUId(Guid Id);

        /// <summary>
        ///     Delete persone by guid
        /// </summary>
        /// <param name="id"></param>
        void Delete(Guid id);
    }
}
