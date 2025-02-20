using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Configuration;
using App.Infra.Db.SqlServer.SqlServerDb;
using App.Domain.Core.ServiceOn.Config;
using App.Domain.Core.ServiceOn.Category.Data.Repository;
using App.Domain.Core.ServiceOn.User.Data.Repository;
using App.Domain.Core.ServiceOn.Orders.Data.Repository;
using App.Domain.Core.ServiceOn.AllService.Data.Repository.cs;
using App.Domain.Core.ServiceOn.FeedBack.Data.Repository;
using App.Domain.Core.ServiceOn.Address.Data.Repository;
using App.Infra.Repository.Ef.ServiceOn.Costomer;
using App.Infra.Repository.Ef.ServiceOn.Expert;
using App.Infra.Repository.Ef.ServiceOn.Operator;
using App.Infra.Repository.Ef.ServiceOn.CostomerRequest;
using App.Infra.Repository.Ef.ServiceOn.ExpertRequest;
using App.Infra.Repository.Ef.ServiceOn.Category;
using App.Infra.Repository.Ef.ServiceOn.SubCategories;
using App.Infra.Repository.Ef.ServiceOn.Allservice;
using App.Infra.Repository.Ef.ServiceOn.FeedBack;
using App.Infra.Repository.Ef.ServiceOn.Address;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();



var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
var siteSettings = configuration.GetSection("SiteSetting").Get<SiteSetting>();
builder.Services.AddSingleton(siteSettings);

builder.Services.AddDbContext<ServiceOnDbContext>(options =>
    options.UseSqlServer(siteSettings.ConnectionString.SqlConnection)
    .ConfigureWarnings(warnings => warnings.Ignore(RelationalEventId.PendingModelChangesWarning)));


// Add services to the container.



builder.Services.AddScoped<ICostomerRepository, CostomerRepository>();
builder.Services.AddScoped<IExpertrepository, ExpertRepository>();
builder.Services.AddScoped<IOperatorRepository, OperatorRepository>();
builder.Services.AddScoped<ICostomerRequestRepository, CostomerRequserRepository>();
builder.Services.AddScoped<IExpertRequestRepository, ExpertRequestRepository>();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<ISubcategoryRepository, SubCategoryRepository>();
builder.Services.AddScoped<IAllServicerepository, AllServicerepository>();
builder.Services.AddScoped<IFeedBackRepository, FeedBackRepository>();
builder.Services.AddScoped<IAddressRepository, AddressRepository>();


var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");

    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseRouting();


app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
