
using Microsoft.EntityFrameworkCore;
using MVCECOMMERCE.Application.Abstarcts;
using MVCECOMMERCE.Application.Concrete;
using MVCECOMMERCE.DataAcces.Abstracts;
using MVCECOMMERCE.DataAcces.Concrete.EfEntityFramework;
using MVCECOMMERCE.Domain.Entities;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
var conn = builder.Configuration.GetConnectionString("Default");
builder.Services.AddDbContext<EcommerceContext>(opt =>
opt.UseSqlServer(conn));
builder.Services.AddScoped<ICategoryService,CategoryService>();
builder.Services.AddScoped<IProductService,ProductService>();    
builder.Services.AddScoped<IProductDal,EFProductDal>();
builder.Services.AddScoped<ICategoryDal,EFCategoryDal>();
builder.Services.AddSession();
builder.Services.AddSingleton< IHttpContextAccessor, HttpContextAccessor>();
////
var app = builder.Build();


if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
