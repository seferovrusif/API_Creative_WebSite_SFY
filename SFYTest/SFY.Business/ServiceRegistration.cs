using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;
using SFY.Business.DTOs.SizeDTOs;
using SFY.Business.ExternalServices.Implements;
using SFY.Business.ExternalServices.Interfaces;
using SFY.Business.Profiles;
using SFY.Business.Repositories.Implements;
using SFY.Business.Repositories.Interfaces;
using SFY.Business.Services.Implements;
using SFY.Business.Services.Interfaces;

namespace SFY.Business
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<ISizeRepository, SizeRepository>();
            services.AddScoped<IColorRepository, ColorRepository>();
            services.AddScoped<IMaterialRepository, MaterialRepository>();
            services.AddScoped<IBagRepository, BagRepository>();
            return services;    
        }
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IBagService, BagService>();
            services.AddScoped<ISizeService, SizeService>();
            services.AddScoped<IMaterialService, MaterialService>();
            services.AddScoped<IColorService, ColorService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<ITokenService, TokenService>();
            return services;
        }
        public static IServiceCollection AddBusinessLayer(this IServiceCollection services)
        {
            services.AddFluentValidation(x => x.RegisterValidatorsFromAssemblyContaining<SizeCreateDTOValidator>());
            services.AddAutoMapper(typeof(SizeMappingProfile).Assembly);
            return services;
        }
    }
}
