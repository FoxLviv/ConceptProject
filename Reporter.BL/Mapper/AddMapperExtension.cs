using AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace Reporter.BL.Mapper
{
    public static class AddExtension
    {
        public static void AddMapper(this IServiceCollection services)
        {

            var mappingConfig = new MapperConfiguration(mc =>
            {
                //mc.AddProfile(new ServicesMapperProfile());
                mc.AllowNullCollections = true;
            });

            var mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);
        }
    }
}
