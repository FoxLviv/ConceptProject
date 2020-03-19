using Reporter.DL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reporter.DL.Repositories.Persons {
    public interface IPersonsRepository: IRepository<PersonEntity> {
        /// <summary>
        ///     Get values by id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        PersonEntity GetByUId(Guid Id);
    }
}
