using Application.Mappings;
using AutoMapper;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Application
{
    public static class ServiceRegistration
    {
        public static void AddApplicationServices(this IServiceCollection services)
        {
            var assm = Assembly.GetExecutingAssembly();
            //services.AddMediatR();
            services.AddAutoMapper(opt =>
            {
                opt.AddProfiles(new List<Profile>
                {
                    new ActorProfile(),

                    new CustomerProfile(),

                    new DirectorProfile(),

                    new MovieProfile(),

                    new OrderProfile()
                });
            });
        }
    }
}
