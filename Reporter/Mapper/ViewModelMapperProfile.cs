using AutoMapper;
using Reporter.Common.DTOs.Person;
using Reporter.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reporter.UI.Mapper
{
    public class ViewModelMapperProfile: Profile
    {
        public ViewModelMapperProfile()
        {
            this.CreateMap<PersonViewModel, PersonDTO>()
                .ForMember(dest => dest.Id, opts => opts.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opts => opts.MapFrom(src => src.Name))
                .ForMember(dest => dest.FirstName, opts => opts.MapFrom(src => src.FirstName))
                .ForMember(dest => dest.LastName, opts => opts.MapFrom(src => src.LastName))
                .ForMember(dest => dest.FacultieId, opts => opts.MapFrom(src => src.FacultieId))
                .ForMember(dest => dest.DepartmentId, opts => opts.MapFrom(src => src.DepartmentId))
                .ForMember(dest => dest.Email, opts => opts.MapFrom(src => src.Password))
                .ForMember(dest => dest.Password, opts => opts.MapFrom(src => src.Password));

            this.CreateMap<PersonDTO, PersonViewModel>()
                .ForMember(dest => dest.Id, opts => opts.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opts => opts.MapFrom(src => src.Name))
                .ForMember(dest => dest.FirstName, opts => opts.MapFrom(src => src.FirstName))
                .ForMember(dest => dest.LastName, opts => opts.MapFrom(src => src.LastName))
                .ForMember(dest => dest.FacultieId, opts => opts.MapFrom(src => src.FacultieId))
                .ForMember(dest => dest.DepartmentId, opts => opts.MapFrom(src => src.DepartmentId))
                .ForMember(dest => dest.Email, opts => opts.MapFrom(src => src.Password))
                .ForMember(dest => dest.Password, opts => opts.MapFrom(src => src.Password));
        }
    }
}
