using Microsoft.EntityFrameworkCore;
using SchoolApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

// Enable CORS
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.AllowAnyOrigin()    // allow requests from any origin (for dev)
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});


builder.Services.AddDbContext<SchoolDbContext>(options =>
    options.UseMySql(
        builder.Configuration.GetConnectionString("DefaultConnection"),
        new MySqlServerVersion(new Version(8, 0, 36))
    ));

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();


app.UseCors();

app.UseAuthorization();

app.MapControllers();

app.Run();
