//1. Usings para trabajar con EF
using Microsoft.EntityFrameworkCore;
using UniversityApiBE.DataAcces;
using UniversityApiBE.Services;

var builder = WebApplication.CreateBuilder(args);


//2. Conectarse a BDD SQL Express
const string CONNECTIONNAME = "UniversityDB";
var connectionString = builder.Configuration.GetConnectionString(CONNECTIONNAME);


//3. Añadimos el contexto al servicio del builder
builder.Services.AddDbContext<UniversityDBContext>(options => options.UseSqlServer(connectionString));

// Add services to the container.

builder.Services.AddControllers();

// 4. Añadir servicios personalizados (carpeta services)
builder.Services.AddScoped<IStudentsService, StudentsServices>();
//TODO: Añadair el resto de los servicios 

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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

// Aplicar CORS a la app
app.UseCors("CorsPolicity");

app.Run();
