using AutoMapper;
using Reporter.DL;

namespace Reporter.BL.Services.Roles
{
    public class RoleService 
    {
        private IMapper _mapper;
        private ReporterDBContext _dbContext;

        public RoleService(IMapper mapper, ReporterDBContext dbContext) 
        {
            this._mapper = mapper;
            this._dbContext = dbContext;
        }
    }
}
