using Microsoft.EntityFrameworkCore;
using Infrastructure;
using Abstraction.Interface;
using Application.Handler;
using Abstraction.Repositories;
using Infrastructure.Repositories;
using Application.Command.Employe;
using Microsoft.AspNetCore.Mvc;
using Application.Handler.Employe;
using Application.Command.EmployeFonction;
using Application;
using Application.Handler.EmployeFonction;
using Application.Query.EmployeFonction;
using Application.Dtos;
using Application.Handler.EmployeFonction.Query;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

 builder.Services.AddControllers();
var _connectionStrings = builder.Configuration.GetConnectionString("DefaultConnection");


var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                      policy =>
                      {
                          policy.WithOrigins("http://example.com",
                                              "http://www.contoso.com");
                      });
});

//builder.Services.AddCors();

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
builder.Services.AddScoped<IEmployeRepository, EmployeRepository>();
builder.Services.AddScoped<IEmployeFonctionRepository, EmployeFonctionRepository>();

builder.Services.AddScoped<ICommandHandler<AddEmployeFonctionCommand,ObjectResponse<string>>, AddEmployeFonctionCommandHandler>();
builder.Services.AddScoped<IRequestHandler<GetEmployeFonctionQuery, ObjectResponse<EmployeFonctionDto>>, GetEmployeFonctionQueryHandler>();


var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.UseCors();

//suite ajout swagger
if (app.Environment.IsDevelopment() || app.Environment.IsProduction())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.Run();
