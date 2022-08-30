using Microsoft.EntityFrameworkCore;
using FirebirdSql.Data.FirebirdClient;
using Dapper;
using System.Diagnostics;
using mdoc;
using mdoc.Services;
using mdoc.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection"); ;

builder.Services.AddDbContext<mdocContext>(options =>
    options.UseFirebird(connectionString)); ;

builder.Services.AddScoped<IExecutiveDocumentationService, ExecutiveDocumentationService>();
builder.Services.AddScoped<IExecutiveDocumentationRepository, ExecutiveDocumentationRepository>();

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
