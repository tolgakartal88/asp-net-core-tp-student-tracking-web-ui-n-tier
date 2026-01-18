using TPStudentTracking.Data.Context;
using TPStudentTracking.Data.Repositories;
using TPStudentTracking.Bussines.Services;
using Microsoft.EntityFrameworkCore;
using TPStudentTracking.Bussines.Services.Interfaces;
using TPStudentTracking.Data.Repositories.Interfaces;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection")));
// Generic Repository
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

// Services
builder.Services.AddScoped<IStudentService, StudentService>();
builder.Services.AddScoped<IClassRoomService, ClassRoomService>();

// Mapping
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
