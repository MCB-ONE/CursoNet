//1. Usings para trabajar con EF
using BussinesLogic.Data;
using BussinesLogic.Logic;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;
using UniversityApiBE.Dtos.Students;
using UniversityApiBE.Dtos.Users;
using UniversityApiBE.Middleware;

var builder = WebApplication.CreateBuilder(args);


//2. Conectarse a BDD SQL Express
const string CONNECTIONNAME = "UniversityDB";
var connectionString = builder.Configuration.GetConnectionString(CONNECTIONNAME);


//3. Añadimos el contexto al servicio del builder
builder.Services.AddDbContext<UniversityDBContext>(options => options.UseSqlServer(connectionString));


// Add services to the container.
// Configuramos los controladores para que ignoren los posibles ciclos de entidades anidadas/ relacionadas
builder.Services.AddControllers().AddJsonOptions(options => 
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

// 4. Añadir servicios personalizados (carpeta services)
// 4.1 Añadir servicio generico
builder.Services.AddScoped(typeof(IGenericService<>), typeof(GenericService<>));
// 4.2 Servicios determinados
builder.Services.AddScoped<IStudentsService, StudentsServices>();
builder.Services.AddScoped<ICoursesServices, CoursesServices>();
builder.Services.AddScoped<IIndexesService, IndexesService>();




// 4.2 Servicio automapper
builder.Services.AddAutoMapper(typeof(UserProfiles));
builder.Services.AddAutoMapper(typeof(StudentProfiles));


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


// 5. Habilitar CORS (Que entornos, que tipo de métodos y cabeceras pueden acceder ala API y enviar peticiones
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "CorsPolicity", builder =>
    {
        builder.AllowAnyOrigin();
        builder.AllowAnyMethod();
        builder.AllowAnyHeader();
    });
});

//TODO: Controlar posible excepción?
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseMiddleware<ExceptionMiddleware>();

app.UseStatusCodePagesWithReExecute("/errors", "?code={0}");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
 
// Aplicar CORS a la app
app.UseCors("CorsPolicity");

app.Run();
