using AutoMapper;
using Reporter.Common.DTOs;
using Reporter.Common.DTOs.Person;
using Reporter.DL;
using Reporter.DL.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reporter.BL.Services.Departmens
{
    public class DepartmentService : IDepartmentService
    {
        private IMapper _mapper;
        private ReporterDBContext _dbContext;

        public DepartmentService(IMapper mapper, ReporterDBContext dbContext) {
            this._mapper = mapper;
            this._dbContext = dbContext;
        }

        public async Task Create(DepatrmentDTO depatrment) {
            _dbContext.Departments.AddAsync(_mapper.Map<DepartmentEntity>(depatrment));
            await _dbContext.SaveChangesAsync();
        }

        public async Task Update(DepatrmentDTO depatrment) {
            _dbContext.Departments.Update(_mapper.Map<DepartmentEntity>(depatrment));
            await _dbContext.SaveChangesAsync();
        }

        public async Task Add(DepatrmentDTO depatrment) {
            _dbContext.Departments.AddAsync(_mapper.Map<DepartmentEntity>(depatrment));
            await _dbContext.SaveChangesAsync();
        }

        public async Task Delete(int id) {
            DepartmentEntity depatrment = await _dbContext.Departments.FindAsync(id);
            if (depatrment != null) {
                _dbContext.Departments.Remove(depatrment);
                await _dbContext.SaveChangesAsync();
            }
        }

        public IEnumerable<PersonDTO> GetListPersones(int departmentID) {
            return _dbContext.Persons.Where(person => person.DepartmentId == departmentID).Select(person => _mapper.Map<PersonDTO>(person));
        }

        public IEnumerable<DepatrmentDTO> GetAll() {
            return _mapper.Map<IEnumerable<DepatrmentDTO>>(_dbContext.Departments);
        }

        public DepatrmentDTO GetById(int id) {
            return _mapper.Map<DepatrmentDTO>(_dbContext.Departments.Find(id));
        }
    }
}
