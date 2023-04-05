using dotnet_learning.Models;
using dotnet_learning.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddSingleton<IInMemoryObjectStoreService, InMemoryObjectStoreService>();
builder.Services.AddDbContext<RestaurantReviewContext>(options => 
    options.UseInMemoryDatabase("RestaurantReviews"));

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();