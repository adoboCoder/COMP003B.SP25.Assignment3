// Program.cs
/*
    Author: Your Full Name
    Course: COMP-003B: ASP.NET Core
    Faculty: Jonathan Cruz
    Purpose: Implements a Job Application Portal demonstrating routing, model binding, and validation.
*/
namespace COMP003B.SP25.Assignment3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

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
                pattern: "{controller=JobApplication}/{action=Apply}/{id?}");

            app.Run();
        }
    }
}
