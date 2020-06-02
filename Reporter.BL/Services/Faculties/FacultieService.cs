using AutoMapper;
using Reporter.Common.DTOs;
using Reporter.DL;
using Reporter.DL.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Reporter.Common.DTOs.Person;

namespace Reporter.BL.Services.Faculties
{
    public class FacultieService: IFacultiesService 
    {
        private IMapper _mapper;
        private ReporterDBContext _dbContext;

        public FacultieService(IMapper mapper, ReporterDBContext dbContext) {
            this._mapper = mapper;
            this._dbContext = dbContext;
        }

        public async Task Create(FacultieDTO facultie) {
            await _dbContext.Faculties.AddAsync(_mapper.Map<FacultieEntity>(facultie));
            await _dbContext.SaveChangesAsync();
        }

        public async Task Update(FacultieDTO facultie) {
            await _dbContext.Faculties.AddAsync(_mapper.Map<FacultieEntity>(facultie));
            await _dbContext.SaveChangesAsync();
        }

        public async Task Delete(int id) {
            FacultieEntity facultie = await _dbContext.Faculties.FindAsync(id);
            if (facultie != null) {
                _dbContext.Faculties.Remove(facultie);
                await _dbContext.SaveChangesAsync();
            }
        }

        public IEnumerable<PersonDTO> GetListPersones(int facultieId) {
            return _dbContext.Persons.Where(person => person.FacultieId == facultieId).Select(person => _mapper.Map<PersonDTO>(person));
        }

        public IEnumerable<FacultieDTO> GetAll() {
            return _mapper.Map<IEnumerable<FacultieDTO>>(_dbContext.Faculties);
        }

        public FacultieDTO GetById(int id) {
            return _mapper.Map<FacultieDTO>(_dbContext.Faculties.Find(id));
        }
    }
}
