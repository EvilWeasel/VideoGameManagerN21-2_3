
// In Dotnet5: Program.cs
// Erzeugen eines neuen WebApplication-Builders
using Microsoft.EntityFrameworkCore;
using PflegeboxAPI.DataAccess;

var builder = WebApplication.CreateBuilder(args);


// Dependency-Injection
// In Dotnet5: in Startup.cs
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<DataModelContext>(options =>
    options.UseSqlServer(
        builder.Configuration["ConnectionStrings:DefaultConnection"]));

var app = builder.Build();


// Configurieren der HTTP-Request-Pipeline
// Hinzufügen von Middleware

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
