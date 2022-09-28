using BussinesLogic.Data;
using BussinesLogic.Logic;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Serilog;
using System.Text.Json.Serialization;
using UniversityApiBE.Dtos.Students;
using UniversityApiBE.Dtos.Users;
using UniversityApiBE.Middleware;
using UniversityApiBE.Security;

var builder = WebApplication.CreateBuilder(args);


// 10. Configurar serilog (proveedor de loggin)
builder.Host.UseSerilog((hostBuilderCtx, loggerConfig) =>
{
    loggerConfig
    .WriteTo.Console() 
    .WriteTo.Debug() 
    .ReadFrom.Configuration(hostBuilderCtx.Configuration); 
}); 

//2. Conectarse a BDD SQL Express
const string CONNECTIONNAME = "UniversityDB";
var connectionString = builder.Configuration.GetConnectionString(CONNECTIONNAME);


//3. A�adimos el contexto al servicio del builder
builder.Services.AddDbContext<UniversityDBContext>(options => options.UseSqlServer(connectionString));


//6. A�adir Jwt Autorization service
builder.Services.AddJwtTokenServices(builder.Configuration);


// 9. Localizaci�n
builder.Services.AddLocalization(options => options.ResourcesPath= "Resources");

// Add services to the container.
// Configuramos los controladores para que ignoren los posibles ciclos de entidades anidadas/ relacionadas
builder.Services.AddControllers().AddJsonOptions(options =>
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

// 4. A�adir servicios personalizados (carpeta services)
// 4.1 A�adir servicio generico
builder.Services.AddScoped(typeof(IGenericService<>), typeof(GenericService<>));
// 4.2 Servicios determinados
builder.Services.AddScoped<IStudentsService, StudentsServices>();
builder.Services.AddScoped<ICoursesServices, CoursesServices>();
builder.Services.AddScoped<IIndexesService, IndexesService>();

// 8. A�adir politica de autorizaci�n
builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("UserOnlyPolicy", policy => policy.RequireClaim("UserOnly", "User1"));
});


// 4.2 Servicio automapper
builder.Services.AddAutoMapper(typeof(UserProfiles));
builder.Services.AddAutoMapper(typeof(StudentProfiles));


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

// 9 Configurar Swagger para que tenga encuenta la autorizaci�n
builder.Services.AddSwaggerGen(options =>
{
    // Definimos la seguridad
    options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Name = "Authorizaion",
        Type = SecuritySchemeType.Http,
        Scheme = "Bearer",
        BearerFormat = "JWT",
        In = ParameterLocation.Header,
        Description = "JWT Authorization Header using Bearer Scheme"
    });

    options.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            new string[]{}
        }
    });
});


// 5. Habilitar CORS (Que entornos, que tipo de m�todos y cabeceras pueden acceder ala API y enviar peticiones
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "CorsPolicity", builder =>
    {
        builder.AllowAnyOrigin();
        builder.AllowAnyMethod();
        builder.AllowAnyHeader();
    });
});

//TODO: Controlar posible excepci�n?
var app = builder.Build();


// 9.1 CULTURAS SOPORTADAS
// 9.1.1 Declaramos las culturas que vana ser soportadas
var supportedCultures = new[]
{
    "en-US", // Ingl�s de Estados Unidos
    "es-ES", // Espa�ol de Espa�a 
    "fr-FR", // Franc�s de fRANCIA
    "de-DE" // Alem�n de Alemania
};

// 9.1.2 Setteamos todoas las culturas que son soportadas por la aplicaci�n, cual viene por defecto y culturas soportadas por la Interfaz de Usuario (UI) por ejemplo usando MVC
var localizationOptions = new RequestLocalizationOptions()
    .SetDefaultCulture(supportedCultures[0]) // "en-US"=> por defecto
    .AddSupportedCultures(supportedCultures)
    .AddSupportedUICultures(supportedCultures);

// 9.2 A�ADIR LA CONFIGURACI�N DE LOCALIZACI�N A LA APP
app.UseRequestLocalization(localizationOptions);

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// 11. Activar Serilog en la app
app.UseSerilogRequestLogging();

app.UseMiddleware<ExceptionMiddleware>();

app.UseStatusCodePagesWithReExecute("/errors", "?code={0}");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

// Aplicar CORS a la app
app.UseCors("CorsPolicity");

app.Run();
