using Microsoft.EntityFrameworkCore;
using Serilog;
using WordManipulationDotNet7.Configuration;
using WordManipulationDotNet7.Data;
using WordManipulationDotNet7.Models;
using WordManipulationDotNet7.Services;

namespace WordManipulationDotNet7
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Configure Serilog
            Log.Logger = new LoggerConfiguration()
                .ReadFrom.Configuration(builder.Configuration)
                .Enrich.FromLogContext()
                .CreateLogger();

            builder.Host.UseSerilog();

            // Configure settings
            builder.Services.Configure<CompanySettings>(builder.Configuration.GetSection("CompanySettings"));
            builder.Services.Configure<DocumentSettings>(builder.Configuration.GetSection("DocumentSettings"));
            builder.Services.Configure<PricingSettings>(builder.Configuration.GetSection("PricingSettings"));

            // Add Database
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
                options.UseNpgsql(
                    builder.Configuration.GetConnectionString("DefaultConnection"),
                    npgsqlOptions => npgsqlOptions.EnableRetryOnFailure()
                ));

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddScoped<DocXService>();
            builder.Services.AddScoped<ILocalizationService, LocalizationService>();
            builder.Services.AddScoped<DropDownGenerator>();
            builder.Services.AddScoped<DropDownGeneratorDb>();

            var app = builder.Build();

            // Seed database
            using (var scope = app.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    var context = services.GetRequiredService<ApplicationDbContext>();
                    context.Database.Migrate();
                    DbSeeder.SeedData(context);
                }
                catch (Exception ex)
                {
                    Log.Error(ex, "An error occurred seeding the database.");
                }
            }

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseSerilogRequestLogging();

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            try
            {
                Log.Information("Starting web application");
                app.Run();
            }
            catch (Exception ex)
            {
                Log.Fatal(ex, "Application terminated unexpectedly");
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }
    }
}
