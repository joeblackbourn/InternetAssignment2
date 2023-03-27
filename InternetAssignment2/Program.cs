using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using InternetAssignment2.Data;
using Microsoft.Identity;
using Microsoft.SqlServer.Server;
using Microsoft.Data.Sqlite;
using Microsoft.Build;
using Microsoft.Data;
using Microsoft.Extensions.Logging;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<AppDataContext>(options =>
	options.UseSqlite(connectionString));

builder.Services.AddHttpContextAccessor();

builder.Services.AddDefaultIdentity<IdentityUser>()
	.AddRoles<IdentityRole>()
	.AddEntityFrameworkStores<AppDataContext>();
builder.Services.AddRazorPages();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
	
}
else
{
	app.UseExceptionHandler("/Error");
	app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.MapRazorPages();
app.Run();
app.UseAuthentication();
app.UseAuthorization();

