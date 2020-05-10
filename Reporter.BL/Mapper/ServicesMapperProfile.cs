using System;
using System.Collections.Generic;
using System.Text;

namespace Reporter.BL.Mapper
{
    class ServicesMapperProfile
    {
    }
}
/*
 using AutoMapper;
using System.Linq;
using UStarter.Domain.Entities;
using UStarter.Services.Models.Comments;
using UStarter.Services.Models.FAQs;
using UStarter.Services.Models.Locations;
using UStarter.Services.Models.Organizations;
using UStarter.Services.Models.Projects;
using UStarter.Services.Models.Roles;
using UStarter.Services.Models.Users;
using UStarter.Services.Models.Logins;

namespace UStarter.Mappers
{
    /// <summary>
    /// Class for defining maps for UStarter.Services.
    /// </summary>
    public class ServicesMapperProfile : Profile
    {
        /// <summary>
        /// Add map between DTO and Entity for UStarter.Services.
        /// </summary>
        public ServicesMapperProfile()
        {
            CreateMap<CreateCommentDTO, CommentEntity>();
            CreateMap<UpdateCommentDTO, CommentEntity>();
            CreateMap<CommentEntity, CommentDTO>();

            CreateMap<CreateFAQDTO, FAQEntity>();
            CreateMap<UpdateFAQDTO, FAQEntity>();
            CreateMap<FAQEntity, FAQDTO>();

            CreateMap<CreateLocationDTO, LocationEntity>();
            CreateMap<UpdateLocationDTO, LocationEntity>();
            CreateMap<LocationEntity, LocationDTO>();

            CreateMap<LoginEntity, LoginDTO>()
                 .ForMember(dto => dto.Location, opt => opt
                    .MapFrom(ent => ent.Location));

            CreateMap<CreateOrganizationDTO, OrganizationEntity>();
            CreateMap<UpdateOrganizationDTO, OrganizationEntity>();
            CreateMap<OrganizationEntity, OrganizationDTO>()
                .ForMember(dto => dto.Location, opt => opt.MapFrom(ent => ent.Location));

            CreateMap<CreateProjectDTO, ProjectEntity>();
            CreateMap<UpdateProjectBasicsDTO, ProjectEntity>();
            CreateMap<UpdateProjectFundingDTO, ProjectEntity>();
            CreateMap<UpdateProjectPeopleDTO, ProjectEntity>();
            CreateMap<UpdateProjectStoryDTO, ProjectEntity>();
            CreateMap<ProjectEntity, ProjectDTO>()
                .ForMember(dto => dto.Creator, opt => opt
                    .MapFrom(ent => ent.Creator))
                .ForMember(dto => dto.Collaborators, opt => opt
                    .MapFrom(ent => ent
                        .UserProjects.Select(up => up.User).ToList()))
                .ForMember(dto => dto.Location, opt=> opt
                    .MapFrom(ent => ent.Location))
                .ForMember(dto => dto.FAQs, opt => opt
                    .MapFrom(ent => ent.FAQs.ToList()))
                .ForMember(dto => dto.Comments, opt => opt
                    .MapFrom(ent => ent.Comments.ToList()))
                .ReverseMap()
                .ForMember(ent => ent.ContactPerson, opt => opt.Ignore());

            CreateMap<RoleEntity, RoleDTO>();

            CreateMap<CreateUserDTO, UserEntity>();
            CreateMap<UserLoginDTO, UserEntity>();
            CreateMap<UpdateUserPasswordDTO, UserEntity>();
            CreateMap<UpdateUserDTO, UserEntity>();
            CreateMap<UserEntity, UserDTO>()
                .ForMember(dto => dto.Roles, opt => opt
                    .MapFrom(ent => ent
                        .UserRoles.Select(ur => ur.Role)))
                .ForMember(dto => dto.Location, opt => opt
                    .MapFrom(ent => ent.Location))
                .ForMember(dto => dto.Logins, opt => opt
                    .MapFrom(ent => ent.Logins.ToList()));
        }
    }
}


     */
