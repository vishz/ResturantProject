using Microsoft.EntityFrameworkCore;
using RebornResturantApp.Data;
using RebornResturantApp.Repositories.Implementations;
using RebornResturantApp.Repositories.Interfaces;
using RebornResturantApp.Services.Implementation;
using RebornResturantApp.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers(); 
builder.Services.AddScoped<IRestaurantService, RestaurantService>();
builder.Services.AddScoped<IRestaurantAuthenticationService, RestaurantAuthenticationService>();
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped<IRestaurantRepository, RestaurantRepository>();
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
  app.UseDeveloperExceptionPage(); 
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

app.MapControllers(); 

app.Run();
