using AutoMapper;
using Reporter.Common.DTOs;
using Reporter.DL.Entities;
using Reporter.DL.Repositories.Persons;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reporter.BL.Services.Persons {
    public class PersonService : IPersonService {
        private IMapper _mapper;
        private IPersonsRepository _personRepositiry;

        public PersonService(IMapper mapper, IPersonsRepository personsRepository) {
            this._mapper = mapper;
            this._personRepositiry = personsRepository;
        }

        public bool hasAccount(string email, string password) {
            throw new NotImplementedException();
        }

        public PersonDTO GetByUid(Guid id) {
            var person = _personRepositiry.GetByUId(id);
            var results = _mapper.Map<PersonDTO>(person);
            
            return results;
        }

        public void Update(PersonDTO person) {
            var personeEntity = _mapper.Map<PersonEntity>(person);
            _personRepositiry.Update(personeEntity);
        }

        public void Delete(Guid id) {
            _personRepositiry.Delete(id);
        }
    }
}
