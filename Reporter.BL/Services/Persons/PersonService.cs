using AutoMapper;
using Reporter.BL.Helpers;
using Reporter.Common.DTOs.Person;
using Reporter.DL;
using Reporter.DL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace Reporter.BL.Services.Persons {
    public class PersonService : IPersonService {
        private IMapper _mapper;
        private ReporterDBContext _dbContext;
        private RandomGenerator _randomGenerator;
        private UserManager<PersonEntity> _userManager;

        public PersonService(IMapper mapper, ReporterDBContext dbContext, UserManager<PersonEntity> usrMgr) {
            this._mapper = mapper;
            this._dbContext = dbContext;
            this._randomGenerator = new RandomGenerator();
            this._userManager = usrMgr;
        }

        //public bool hasAccount(string email, string password) {
        //    var existingPerson = _dbContext.Persons.Where(elem => elem.Email == email).First();
        //    var existingPassword = Encoding.ASCII.GetString(existingPerson.PasswordHash) + Encoding.ASCII.GetString(existingPerson.PasswordSalt);

        //    return (existingPassword == password) ? true : false;
        //}

        //public async Task<PersonDTO> CreatePersonAsync(CreatePersonDTO createPersonDTO) {
        //    var personeEntity = _mapper.Map<PersonEntity>(createPersonDTO);

        //    await _dbContext.Persons.AddAsync(personeEntity);
        //    await _dbContext.SaveChangesAsync();

        //    var personDTO = _mapper.Map<PersonDTO>(personeEntity);
        //    return personDTO;
        //}

        public async Task<PersonDTO> Create(PersonDTO person) {
            var personeEntity = _mapper.Map<PersonEntity>(person);

            IdentityResult result = await this._userManager.CreateAsync(personeEntity, person.Password);

            return person;
        }

        public async Task<PersonDTO> GetByIdAsync(string id) {
            var person = await _dbContext.Persons.FindAsync(id);
            var results = _mapper.Map<PersonDTO>(person);

            return results;
        }

        public async Task Update(PersonDTO person) {
            var personeEntity = _mapper.Map<PersonEntity>(person);
            _dbContext.Persons.Update(personeEntity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeletePersonAsync(string id) {
            PersonEntity personEntity = await _dbContext.Users.FirstOrDefaultAsync(x => x.Id == id);

            if (personEntity != null)
            {
                _dbContext.Users.Remove(personEntity);
                await _dbContext.SaveChangesAsync();
            }
        }

        public bool hasAccount(string email, string password)
        {
            throw new NotImplementedException();
        }
    }
}
