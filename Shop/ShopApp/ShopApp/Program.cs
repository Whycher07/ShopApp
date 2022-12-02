using Microsoft.EntityFrameworkCore;
using ShopApp.Data.Entities;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ShopContext>(opt =>
{
    opt.UseSqlServer("server=10.20.10.125;User Id=ardatorun;password=ATorun*22+23;Datebase=Junior");
});
var app = builder.Build();


app.MapDefaultControllerRoute();


app.Run();
