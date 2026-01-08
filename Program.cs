using Microsoft.EntityFrameworkCore;
using Product.Api.Data;
using Product.Api.Services;
using Product.Api.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);
var connString = builder.Configuration["ConnectionStrings:DefaultConnection"];

// Add services to the container.
builder.Services.AddDbContext<AppDbContext>(options => 
        options.UseSqlServer(connString));

builder.Services.AddScoped<IProdutoService, ProdutoService>();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

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
