using Microsoft.EntityFrameworkCore;
using Task.BLL;
using Task.BLL.Interfaces;
using Task.DAL;
using Task.DAL.Interfaces;
using Task.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// database config
builder.Services.AddDbContext<DbtaskContext>(option => { 
    option.UseSqlServer(builder.Configuration.GetConnectionString("SQLString"));
});

builder.Services.AddScoped<IRepository<Tarea>, RepositoryTarea>();
builder.Services.AddScoped<IServiceTarea, ServiceTarea>();

// automapper config
builder.Services.AddAutoMapper(typeof(Program));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
