using System.Text;
using AutoMapper;
using Reporter.Common.DTOs;
using Reporter.DL.Entities;

namespace Reporter.BL.Mapper
{
    /// <summary>
    ///     Mapping profile.
    /// </summary>
    public class ServicesMapperProfile : Profile
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="ServicesMapperProfile"/> class.
        /// </summary>
        public ServicesMapperProfile()
        {
            this.CreateMap<CommentEntity, CommentDTO>()
                .ForMember(dest => dest.ID, opts => opts.MapFrom(src => src.Id))
                .ForMember(dest => dest.AuthorUid, opts => opts.MapFrom(src => src.AuthorId))
                .ForMember(dest => dest.ReportID, opts => opts.MapFrom(src => src.ReportId))
                .ForMember(dest => dest.CreateAt, opts => opts.MapFrom(src => src.CreateAt))
                .ForMember(dest => dest.Comment, opts => opts.MapFrom(src => src.Comment));

            this.CreateMap<DepartmentEntity, DepatrmentDTO>()
                .ForMember(dest => dest.ID, opts => opts.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opts => opts.MapFrom(src => src.Name));

            this.CreateMap<FacultieEntity, FacultieDTO>()
                .ForMember(dest => dest.ID, opts => opts.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opts => opts.MapFrom(src => src.Name));

            this.CreateMap<PersonEntity, PersonDTO>()
                .ForMember(dest => dest.Id, opts => opts.MapFrom(src => src.Id))
                .ForMember(dest => dest.FirstName, opts => opts.MapFrom(src => src.FirstName))
                .ForMember(dest => dest.LastName, opts => opts.MapFrom(src => src.LastName))
                .ForMember(dest => dest.Email, opts => opts.MapFrom(src => src.Email))
                .ForMember(dest => dest.Password, opts => opts.MapFrom(src => Encoding.ASCII.GetString(src.PasswordHash) + Encoding.ASCII.GetString(src.PasswordSalt)))
                .ForMember(dest => dest.FacultieId, opts => opts.MapFrom(src => src.FacultieId))
                .ForMember(dest => dest.DepartmentId, opts => opts.MapFrom(src => src.DepartmentId));

            this.CreateMap<ReportEntity, ReportDTO>()
                .ForMember(dest => dest.ID, opts => opts.MapFrom(src => src.Id))
                .ForMember(dest => dest.AuthorUID, opts => opts.MapFrom(src => src.AuthorId))
                .ForMember(dest => dest.Report, opts => opts.MapFrom(src => src.Report));
        }
    }
}