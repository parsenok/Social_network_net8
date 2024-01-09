using DB;
using FluentAssertions.Common;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace vk
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
            services.AddSingleton<YourDbContext>();
            services.AddDbContext<YourDbContext>(options =>
    options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
        }
        //public void Configure(IApplicationBuilder app)
        //{
        //    app.UseRouting();
        //    app.UseEndpoints(endpoints =>
        //    {
        //        endpoints.MapBlazorHub();
        //        endpoints.MapFallbackToPage("/_Host");
        //    });
        //}
        public class UserService : IUserService
        {
            public bool UserExists(string login, string password)
            {
                throw new NotImplementedException();
            }
        }
    }
}
