using entity_framework;
using entity_framework.config;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//builder.Services.AddDbContext<TaskContext>(options => options.UseInMemoryDatabase("DBTasks"));
builder.Services.AddNpgsql<TaskContext>(DBTask_Connection.GetConnectionInfo());

var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("/dbconnect", async ([FromServices] TaskContext dbContext) =>
{
    dbContext.Database.EnsureCreated();
    //create await response
    var response = await dbContext.Categories.ToListAsync();
    return Results.Ok("Base de datos en memoria: " + dbContext.Database.IsInMemory() + " response: " + response.Count);
});

app.Run();
