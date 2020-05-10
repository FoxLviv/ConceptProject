using AutoMapper;
using Reporter.Common.DTOs;
using Reporter.DL;
using Reporter.DL.Entities;
using System.Collections.Generic;
using System.Linq;

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

        public void Create(DepatrmentDTO depatrment) {
            _dbContext.Departments.Add(_mapper.Map<DepartmentEntity>(depatrment));
            _dbContext.SaveChanges();
        }

        public void Update(DepatrmentDTO depatrment) {
            _dbContext.Departments.Add(_mapper.Map<DepartmentEntity>(depatrment));
            _dbContext.SaveChanges();
        }

        public void Delete(int id) {
            DepartmentEntity depatrment = _dbContext.Departments.Find(id);
            if (depatrment != null) {
                _dbContext.Departments.Remove(depatrment);
                _dbContext.SaveChanges();
            }
        }

        public IEnumerable<PersonDTO> GetListPersones(int departmentID) {
            return _dbContext.Persons.Where(person => person.DepartmentId == departmentID).Select(person => _mapper.Map<PersonDTO>(person));
        }
    }
}
