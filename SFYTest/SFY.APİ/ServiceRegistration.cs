using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using SFY.Core.Entities;
using SFY.DAL.Contexts;
using static SFY.APİ.ServiceRegistration;
using System.Text;

namespace SFY.APİ
{
    public static class ServiceRegistration
    {
        public class Jwt
        {
            public string Issuer { get; set; }
            public string Audience { get; set; }
            public string Key { get; set; }
        }
        public static IServiceCollection AddUserIdentity(this IServiceCollection services)
        {
            services.AddIdentity<AppUser, IdentityRole>(opt =>
            {
                opt.Password.RequireNonAlphanumeric = false;
            }).AddDefaultTokenProviders().AddEntityFrameworkStores<SFYTestContext>();
            return services;
        }

        public static IServiceCollection AddAuth(this IServiceCollection services, Jwt jwt)
        {
            services.AddAuthentication(opt =>
            {
                opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                opt.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
                opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(opt =>
            {
                opt.TokenValidationParameters = new TokenValidationParameters()
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,

                    ValidIssuer = jwt.Issuer,
                    ValidAudience = jwt.Audience,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwt.Key)),
                    LifetimeValidator = (nb, exp, token, _) => token != null ? exp > DateTime.UtcNow && nb < DateTime.UtcNow : false
                };
            });
            services.AddAuthorization();
            return services;
        }
    }
}