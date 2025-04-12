using Microsoft.EntityFrameworkCore;
using midterm_project.Migrations;
using midterm_project.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<PetDbContext>(options => 
    options.UseSqlite(builder.Configuration.GetConnectionString("PetsDB")));
builder.Services.AddScoped<IPetRepository, EFPetRepository>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Pet}/{action=List}/{id?}")
    .WithStaticAssets();


app.Run();
