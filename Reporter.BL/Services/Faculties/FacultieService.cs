using AutoMapper;
using Reporter.Common.DTOs;
using Reporter.DL;
using Reporter.DL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reporter.BL.Services.Faculties {
    public class FacultieService {
        private IMapper _mapper;
        private ReporterDBContext _dbContext;

        public FacultieService(IMapper mapper, ReporterDBContext dbContext) {
            this._mapper = mapper;
            this._dbContext = dbContext;
        }

        public void Create(FacultieDTO facultie) {
            _dbContext.Faculties.Add(_mapper.Map<FacultieEntity>(facultie));
            _dbContext.SaveChanges();
        }

        public void Update(FacultieDTO facultie) {
            _dbContext.Faculties.Add(_mapper.Map<FacultieEntity>(facultie));
            _dbContext.SaveChanges();
        }

        public void Delete(int id) {
            FacultieEntity facultie = _dbContext.Faculties.Find(id);
            if (facultie != null) {
                _dbContext.Faculties.Remove(facultie);
                _dbContext.SaveChanges();
            }
        }

        public IEnumerable<PersonDTO> GetListPersones(int facultieId) {
            return _dbContext.Persons.Where(person => person.FacultieId == facultieId).Select(person => _mapper.Map<PersonDTO>(person));
        }
    }
}
