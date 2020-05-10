using AutoMapper;
using Reporter.BL.Helpers;
using Reporter.Common.DTOs;
using Reporter.DL;
using Reporter.DL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Reporter.BL.Services.Persons {
    public class PersonService : IPersonService {
        private IMapper _mapper;
        private ReporterDBContext _dbContext;
        private RandomGenerator _randomGenerator;

        public PersonService(IMapper mapper, ReporterDBContext dbContext) {
            this._mapper = mapper;
            this._dbContext = dbContext;
            this._randomGenerator = new RandomGenerator();
        }

        public bool hasAccount(string email, string password) {
            var existingPerson = _dbContext.Persons.Where(elem => elem.Email == email).First();
            var existingPassword = Encoding.ASCII.GetString(existingPerson.PasswordHash) + Encoding.ASCII.GetString(existingPerson.PasswordSalt);

            return (existingPassword == password) ? true : false;
        }

        public void Create(PersonDTO person) {
            var personeToCreate = _mapper.Map<PersonEntity>(person);

            personeToCreate.Id = Guid.NewGuid();
            personeToCreate.PasswordSalt = Encoding.ASCII.GetBytes(_randomGenerator.RandomString(5,false));
            personeToCreate.PasswordHash = Encoding.ASCII.GetBytes(person.Password);

            _dbContext.Persons.Add(personeToCreate);
            _dbContext.SaveChanges();
        }

        public PersonDTO GetByUid(Guid id) {
            var person = _dbContext.Persons.Find(id);
            var results = _mapper.Map<PersonDTO>(person);
            
            return results;
        }

        public void Update(PersonDTO person) {
            var personeEntity = _mapper.Map<PersonEntity>(person);
            _dbContext.Persons.Update(personeEntity);
        }

        public void Delete(Guid id) {
            PersonEntity person = _dbContext.Persons.Find(id);
            if (person != null)
            {
                _dbContext.Persons.Remove(person);
                _dbContext.SaveChanges();
            }
        }
    }
}
