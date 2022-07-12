using Arthes_2022.Data;
using Arthes_2022.Data.Interfaces;
using Arthes_2022.Data.Mappings;
using Arthes_2022.Data.Repositories;
using Arthes_2022.Models.Validators;

using FluentValidation.AspNetCore;

using Microsoft.EntityFrameworkCore;

using System.Globalization;

WebApplicationBuilder? builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddControllers().AddFluentValidation(f =>
    {
        f.ValidatorOptions.LanguageManager.Culture = new CultureInfo("pt-BR");
        f.RegisterValidatorsFromAssemblyContaining<CadastraRevistaValidator>();
    });

builder.Services.AddAutoMapper(
    typeof(CadastraRevistaMappingProfile));

builder.Services.AddDbContext<ArthesContext>(options => options.UseSqlServer(builder.
    Configuration.GetConnectionString("ArthesConn")));

builder.Services.AddScoped<IRevistaRepository, RevistaRepository>();



WebApplication? app = builder.Build();

// Configure the HTTP request pipeline.
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
    pattern: "{controller=Home}/{action=Index}/{id?}"
);

app.Run();
