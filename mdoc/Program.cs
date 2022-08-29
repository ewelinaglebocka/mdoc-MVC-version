using mdoc.DataBase.Models;
using Microsoft.EntityFrameworkCore;
using FirebirdSql.Data.FirebirdClient;
using Dapper;
using System.Diagnostics;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

FbConnectionStringBuilder csb = new FbConnectionStringBuilder();
csb.DataSource = "192.168.2.89";
csb.Port = 3050;
csb.Database = @"C:\\zmiana_technologii\\MARDOM_ALL.FDB";
csb.UserID = "SYSDBA";
csb.Password = "masterkey";
csb.ServerType = FbServerType.Default;

FbConnection db = new FbConnection(csb.ToString());
db.Open();

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
