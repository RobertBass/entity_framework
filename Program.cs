using entity_framework;
using entity_framework.config;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//builder.Services.AddDbContext<TaskContext>(options => options.UseInMemoryDatabase("TasksDB"));
builder.Services.AddNpgsql<TaskContext>(DBTask_Connection.GetConnectionInfo());

var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("/dbconnetion", async ([FromServices] TaskContext dbContext) =>
{
    dbContext.Database.EnsureCreated();
    return Results.Ok("Base de datos en memoria: " + dbContext.Database.IsInMemory());
});

app.Run();
