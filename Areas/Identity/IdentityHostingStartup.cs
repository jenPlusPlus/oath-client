using System;
using System.Diagnostics;
using IdeaBox.Areas.Identity.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(IdeaBox.Areas.Identity.IdentityHostingStartup))]
namespace IdeaBox.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            Debug.WriteLine("***HERE***");
            // builder.ConfigureServices((context, services) => {
            //     services.AddDbContext<IdeaBoxIdentityDbContext>(options =>
            //         options.UseSqlServer(
            //             context.Configuration.GetConnectionString("IdeaBoxIdentityDbContextConnection")));

            //     services.AddDefaultIdentity<IdentityUser>()
            //         .AddEntityFrameworkStores<IdeaBoxIdentityDbContext>();
            // });
        }
    }
}