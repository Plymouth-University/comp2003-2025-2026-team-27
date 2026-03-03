using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using LmsModernApp.Data;
using Lms.Data;
using Lms.Data.Models.Delib;
using Lms.Data.Models.Decat;
using Lms.Data.Models.Delocal;
using Lms.Data.Models.Deweb;
using Lms.Data.Models.Destats;
using Lms.Data.Models.Dereport;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));

var delibConnectionString = builder.Configuration.GetConnectionString("DelibConnection") ?? throw new InvalidOperationException("Connection string 'DelibConnection' not found.");
builder.Services.AddDbContext<DelibContext>(options =>
    options.UseSqlServer(delibConnectionString));

var catConnectionString = builder.Configuration.GetConnectionString("CatConnection") ?? throw new InvalidOperationException("Connection string 'CatConnection' not found.");
builder.Services.AddDbContext<DecatContext>(options =>
    options.UseSqlServer(catConnectionString));

var localConnectionString = builder.Configuration.GetConnectionString("LocalConnection") ?? throw new InvalidOperationException("Connection string 'LocalConnection' not found.");
builder.Services.AddDbContext<DelocalContext>(options =>
    options.UseSqlServer(localConnectionString));

var webConnectionString = builder.Configuration.GetConnectionString("WebConnection") ?? throw new InvalidOperationException("Connection string 'WebConnection' not found.");
builder.Services.AddDbContext<DewebContext>(options =>
    options.UseSqlServer(webConnectionString));

var statsConnectionString = builder.Configuration.GetConnectionString("StatsConnection") ?? throw new InvalidOperationException("Connection string 'StatsConnection' not found.");
builder.Services.AddDbContext<DestatsContext>(options =>
    options.UseSqlServer(statsConnectionString));

var reportConnectionString = builder.Configuration.GetConnectionString("ReportConnection") ?? throw new InvalidOperationException("Connection string 'ReportConnection' not found.");
builder.Services.AddDbContext<DereportContext>(options =>
    options.UseSqlServer(reportConnectionString));

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

// Custom Staff/Operator Authentication
builder.Services.AddAuthentication("StaffAuth")
    .AddCookie("StaffAuth", options =>
    {
        options.LoginPath = "/Account/Login";
        options.LogoutPath = "/Account/Logout";
        options.AccessDeniedPath = "/Account/AccessDenied";
        options.Cookie.Name = "LmsStaffAuth";
    });

builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();


//Repository
builder.Services.AddScoped<IDashboardRepository, DashboardRepository>();
builder.Services.AddScoped<IOperatorRepository, OperatorRepository>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}


app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();
app.UseSession();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();

app.MapRazorPages()
   .WithStaticAssets();

app.Run();
