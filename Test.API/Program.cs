using MediatR;
using Microsoft.EntityFrameworkCore;
using Test.Application.Features.Command.ItemCommand.Handler;
using Test.Application.Features.Command.UserCommand.Handler;
using Test.Application.Mapperprof;
using Test.Application.PersistenceInterface;
using Test.Infrastructure.Data;
using Test.Infrastructure.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<IUser, UserRepos>();
builder.Services.AddScoped<IItem, ItemRepos>();
builder.Services.AddMediatR(typeof(CreateUserQueryHandler).Assembly,
                            typeof(ItemCommandQueryHandler).Assembly
                              );
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddAutoMapper(typeof(MapperProfile));
builder.Services.AddDbContext<ApplicationDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
