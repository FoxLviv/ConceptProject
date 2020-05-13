using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using Reporter.BL.Mapper;

namespace Reporter.UI.Mapper
{
    public static class AddExtension
    {
        public static void AddMapper(this IServiceCollection services)
        {

            var mappingConfig = new MapperConfiguration(mc => {
                mc.AddProfile(new ServicesMapperProfile());
                mc.AddProfile(new ViewModelMapperProfile());
                mc.AllowNullCollections = true;
            });

            var mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);
        }
    }
}
