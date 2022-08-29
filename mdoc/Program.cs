using mdoc.DataBase.Models;
using Microsoft.EntityFrameworkCore;
using FirebirdSql.Data.FirebirdClient;
using Dapper;
using System.Diagnostics;
using mdoc;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<mdocContext>(
    o => o.UseFirebird(builder.Configuration.GetConnectionString("mdocDb")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
