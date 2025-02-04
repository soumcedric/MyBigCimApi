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

//injection des d�pendances
builder.Services.AddScoped<IServiceRepository, ServiceRepository>();
builder.Services.AddScoped<IFonctionRepository, FonctionRepository>();
builder.Services.AddScoped<IEmployeRepository, EmployeRepository>();


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
