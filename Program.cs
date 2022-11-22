using CRUD_Api.CRUD.BLL;
using CRUD_Api.CRUD.EF.Data;
using CRUD_Api.services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddCors();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddScoped<IProductServise, ProductServise>();
builder.Services.AddScoped<IProductRepo, ProductRepo>();
builder.Services.AddScoped<IOrderservice, OrderService>();
builder.Services.AddScoped<IOrderRepo, OrderRepo>();
builder.Services.AddSwaggerGen();
builder.Services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<ApplicationDBContext>();
builder.Services.AddDbContext<ApplicationDBContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"),
b => b.MigrationsAssembly(typeof(ApplicationDBContext).Assembly.FullName)));



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors(c => c.WithOrigins("http://localhost:4200")
.AllowAnyHeader()
.AllowAnyMethod()
.SetIsOriginAllowed(origin => true)
.AllowCredentials());
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
