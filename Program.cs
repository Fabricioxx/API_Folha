using Microsoft.EntityFrameworkCore;
using Data; //DataContext

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new() { Title = "My API_Folha", Version = "v1" });
});

//configurado no arquivo DataContext.cs e banco de dados sqlite
builder.Services.AddDbContext<DataContext>(options => options.UseSqlite("DataSource=database.db;Cache=shared"));

var app = builder.Build(); // Build the application.

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
