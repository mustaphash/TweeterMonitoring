using Core.Commands;
using DAL;
using DAL.Commands.CreateAccountCommands;
using DAL.Commands.CreateTwitterAccountsCommands;
using DAL.Commands.UpdateAccountsCommands;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<TwitterContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnectionStrings")));

builder.Services.AddScoped<ICommandHandler<CreateTwitterAccountCommand>, CreateTwitterAccountCommandHandler>();
builder.Services.AddScoped<ICommandHandler<UpdateTwitterAccountCommand>, UpdateTwitterAccountCommandHandler>();

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
