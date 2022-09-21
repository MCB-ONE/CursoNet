using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;

namespace UniversityApiBE.Security
{
    // Clse que permite añadir nuestros JWTSetings al programa
    public static class AddJwtTokenServicesExtensions
    {
        public static void AddJwtTokenServices(this IServiceCollection Services, IConfiguration Configuration)
        {
            // Aañadir JwtSettings
            var bindJwtSettings = new JwtSettings();

            // Unimos a la configuración del proyecto los settings de JsonWebToken que tenemos en appsettings.json (evitamos tener que ponerlos manualmente)
            Configuration.Bind("JsonWebTokenKeys", bindJwtSettings);

            // Añadir Singleton de JWT Settings
            Services.AddSingleton(bindJwtSettings);

            // Añadir la autenticación
            Services.AddAuthentication(options =>
            {
                // Indicamos que nuestra app va autilizar un sistema Jwt Bearer de autenticación
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(options =>
            {
                options.RequireHttpsMetadata = false;
                options.SaveToken = true;
                options.TokenValidationParameters = new TokenValidationParameters()
                {
                    ValidateIssuerSigningKey = bindJwtSettings.ValidateIssuerSigningKey,
                    IssuerSigningKey = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(bindJwtSettings.IssuerSigningKey)),
                    ValidateIssuer = bindJwtSettings.ValidateIssuer,
                    ValidIssuer = bindJwtSettings.ValidIssuer,
                    ValidateAudience = bindJwtSettings.ValidateAudience,
                    ValidAudience = bindJwtSettings.ValidAudience,
                    RequireExpirationTime = bindJwtSettings.RequireExpirationTime,
                    ValidateLifetime = bindJwtSettings.ValidateLifetime,
                    ClockSkew = TimeSpan.FromDays(1)
                };
            });
        }
    }
}
