using Microsoft.EntityFrameworkCore;
using Infrastructure;
using Abstraction.Interface;
using Application.Handler;
using Abstraction.Repositories;
using Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
var _connectionStrings = builder.Configuration.GetConnectionString("DefaultConnection");

//builder.Services.AddCors(options =>
//{
//    options.AddPolicy("AllowAll",
//               builder => builder.AllowAnyOrigin()
//                          .AllowAnyMethod()
//                                     .AllowAnyHeader());
//});

builder.Services.AddCors();

//Ajout du context
builder.Services.AddDbContext<Infrastructure.ApplicationContext>(option => {
     option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

//ajout de swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//injection des dépendances
builder.Services.AddScoped<IServiceRepository, ServiceRepository>();
builder.Services.AddScoped<IFonctionRepository, FonctionRepository>();


var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

//suite ajout swagger
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.Run();
