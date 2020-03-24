using Reporter.Common.Models;
using Reporter.DL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reporter.DL.Repositories.Persons {
    public class PersonsRepository: IPersonsRepository {
        private ReporterDBContext _dbContext; 

        public PersonsRepository(ReporterDBContext dbContext) {
            this._dbContext = dbContext;
        }

        public IEnumerable<PersonEntity> ReadAll() {
            var persons = _dbContext.Persons;
            return persons;
        }

        public void Create(PersonEntity entity) {
            _dbContext.Persons.Add(entity);
        }

        public PersonEntity GetByUId(Guid Id) {
            return _dbContext.Persons.Find(Id);
        }

        public void Update(PersonEntity entity) {
            _dbContext.Persons.Update(entity);
        }

        public void Delete(Guid id) {
            PersonEntity person = _dbContext.Persons.Find(id);
            if (person != null) {
                _dbContext.Persons.Remove(person);
            }
        }
    }
}
