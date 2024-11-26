using Microsoft.EntityFrameworkCore;
using JpMorganChase_Co_MortGageLoan_BusinessEntities.Interfaces;
using JpMorganChase_Co_MortGageLoan_RepositoryLayer;
using JpMorganChase_Co_MortGageLoan_ServiceLayer;
using JpMorganChase_Co_MortGageLoan_DBContext.HotelmanagementContext;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IUserRegistrationRepository, UserRegistrationRepository>();
builder.Services.AddScoped<IUserRegistrationServices, UserRegistrationServices>();
builder.Services.AddDbContext<HotelmanagementContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("HotelManagmentConn")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
