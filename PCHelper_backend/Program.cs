using PC_helper.Data.Repositories;
using PC_helper.Data.Repositories.Interfaces;
using PC_helper.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var constring = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<DataContext>(options => options.UseNpgsql(constring));

builder.Services.AddControllers();
builder.Services.AddScoped<IGPURepository, GPURepository>();
builder.Services.AddScoped<ICPURepository, CPURepository>();
builder.Services.AddScoped<IMotherboardRepository, MotherboardRepository>();
builder.Services.AddScoped<IRAMRepository, RAMRepository>();

var app = builder.Build();

app.UseCors(options => options.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
app.MapControllers();


app.Run();
