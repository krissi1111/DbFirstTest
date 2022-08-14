using Core.Interfaces;
using Data.EF;
using Data.EF.Repositories;
using Microsoft.EntityFrameworkCore;
using Service;
using Service.DTOs;
using Service.Interfaces;

var builder = WebApplication.CreateBuilder(args);

var configuration = builder.Configuration;
var services = builder.Services;

string connectionString = configuration.GetConnectionString("NewsAppDb");
services.AddDbContext<NewsAppDbContextContext>(x => x.UseSqlServer(connectionString));

services.AddAutoMapper(typeof(MappingProfile));

services.AddScoped<INewsItemRepository, NewsItemRepository>();
services.AddScoped<INewsFeedRepository, NewsFeedRepository>();
services.AddScoped<INewsService, NewsService>();

services.AddControllers();

var app = builder.Build();

app.MapControllers();

app.Run();
