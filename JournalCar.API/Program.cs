using JournalCar.API.Data;
using JournalCar.API.Domain;
using JournalCar.API.Model.Mapping;
using JournalCar.API.Repository.User;
using Microsoft.EntityFrameworkCore;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<JournalCarDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("JournalCarDB")));

builder.Services.AddAutoMapper(typeof(AutoMapperProfiles));

builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUserDomain, UserDomain>();

//Logger
var logger = new LoggerConfiguration()
    .WriteTo.MSSqlServer(builder.Configuration.GetConnectionString("JournalCarDB"),"AppLogsEvent",autoCreateSqlTable: true)
    .MinimumLevel.Error().CreateLogger();

builder.Logging.ClearProviders();
builder.Logging.AddSerilog(logger);

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
