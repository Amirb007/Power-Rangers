using FluentAssertions.Common;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Context;
using WebApplication1.Controllers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<CRUDContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("master")));
builder.Services.AddSwaggerGen(c => {
    c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
    {
        Title = "Booking Api",
        Version = "v1"
    });

});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    
}

app.UseSwaggerUI(c => {

    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Hotel booking Api");

});

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
