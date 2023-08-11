

using Microsoft.EntityFrameworkCore;
using ProjectTry.Coree.Interfaces;
using ProjectTry.Infrastructuree;
using ProjectTry.Infrastructuree.Repositories;
using ProjectTry.Servicess;
using ProjectTry.Servicess.Interfacess;
using ProjectTry.Infrastructuree.ServiceExtension;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

/*builder.Services.AddDbContext<DbContextClass>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});*/

builder.Services.AddDIServices(builder.Configuration);
builder.Services.AddTransient<IProductService, ProductService>();
builder.Services.AddTransient<ICategoryService, CategoryService>();
//builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
//builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
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
