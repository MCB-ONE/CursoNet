//1. Usings para trabajar con EF
using BussinesLogic.Data;
using BussinesLogic.Logic;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using UniversityApiBE.Dtos.StudentDto;
using UniversityApiBE.Dtos.UserDto;
using UniversityApiBE.Services;

var builder = WebApplication.CreateBuilder(args);


//2. Conectarse a BDD SQL Express
const string CONNECTIONNAME = "UniversityDB";
var connectionString = builder.Configuration.GetConnectionString(CONNECTIONNAME);


//3. A�adimos el contexto al servicio del builder
builder.Services.AddDbContext<UniversityDBContext>(options => options.UseSqlServer(connectionString));


// Add services to the container.

builder.Services.AddControllers();

// 4. A�adir servicios personalizados (carpeta services)
builder.Services.AddScoped<IStudentsService, StudentsServices>();

//TODO: A�adair el resto de los servicios 
// 4.1 A�adir servicio de repositorio
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

// 4.2 Servicio automapper
builder.Services.AddAutoMapper(typeof(UserProfiles));
builder.Services.AddAutoMapper(typeof(StudentProfiles));


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


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

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseStatusCodePagesWithReExecute("/errors", "?code={0}");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

// Aplicar CORS a la app
app.UseCors("CorsPolicity");

app.Run();
