using Microsoft.EntityFrameworkCore;
using Project.Server.Suite.Data.Context;
using Project.Server.Suite.Data.Interfaces;
using Project.Server.Suite.Data.Repositories;
using Project.Server.Suite.Services;
using Project.Server.Suite.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddSqlite<PsSuiteContext>("DataSource=file:PsSuite.db;Mode=ReadWrite");
builder.Services.AddScoped<DbContext, PsSuiteContext>();

builder.Services.AddScoped<ITriggerRepositoryCrud, TriggerRepository>();
builder.Services.AddScoped<ITriggerService, TriggerService>();

builder.Services.AddScoped<IProjectServerRepositoryCrud, ProjectServerRepository>();
builder.Services.AddScoped<IProjectServerService, ProjectServerService>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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

app.Run();
